using MetroDelivery.Application.Models.Identity;
using MetroDelivery.Domain.IdentityModels;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.JsonWebTokens;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace MetroDelivery.API.Controllers.Auth
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthenticateController : ControllerBase
    {
        public readonly UserManager<ApplicationUser> _userManager;
        public readonly RoleManager<IdentityRole> _roleManager;
        public readonly IConfiguration _configuration;
        private readonly JwtSettings _jwtSettings;

        public AuthenticateController(UserManager<ApplicationUser> userManager, RoleManager<IdentityRole> roleManager, IConfiguration configuration, JwtSettings jwtSettings)
        {
            this._userManager = userManager;
            this._roleManager = roleManager;
            this._configuration = configuration;
            this._jwtSettings = jwtSettings;
        }

        [HttpPost]
        [Route("Register")]
        public async Task<IActionResult> Register([FromBody] RegistrationRequest request)
        {
            var userExist = await _userManager.FindByNameAsync(request.UserName);
            if(userExist != null) {
                return StatusCode(StatusCodes.Status500InternalServerError, "Existed!!!");
            }
            ApplicationUser user = new ApplicationUser()
            {
                Email = request.Email,
                SecurityStamp = Guid.NewGuid().ToString(),
                UserName = request.UserName,
                FirstName = request.FirstName,
                LastName = request.LastName,
            };
            var result = await _userManager.CreateAsync(user, request.Password);
            if(!result.Succeeded) {
                return StatusCode(StatusCodes.Status500InternalServerError, "Fail");
            }

            if(!await _roleManager.RoleExistsAsync("Admin")) {
                await _roleManager.CreateAsync(new IdentityRole("Admin"));
            }
            if (!await _roleManager.RoleExistsAsync("EndUser")) {
                await _roleManager.CreateAsync(new IdentityRole("EndUser"));
            }
            if (!await _roleManager.RoleExistsAsync("Admin")) {
                await _userManager.AddToRoleAsync(user, "Admin");
            }

            return Ok("Succesfully");
        }

        [HttpPost]
        [Route("Login")]
        public async Task<IActionResult> Login([FromBody] AuthRequest request)
        {
            var user = await _userManager.FindByEmailAsync(request.Email);

            var result = await _userManager.CheckPasswordAsync(user, request.Password);
            if (result && user != null) {
                var roles = await _userManager.GetRolesAsync(user);
                var authClaims = new List<Claim>
                {
                    new Claim(ClaimTypes.Name, user.UserName),
                    new Claim(System.IdentityModel.Tokens.Jwt.JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString()),
                    new Claim(System.IdentityModel.Tokens.Jwt.JwtRegisteredClaimNames.Email, user.Email),
                    new Claim("uid", user.Id)
                };
                foreach (var userRole in roles) {
                    authClaims.Add(new Claim(ClaimTypes.Role, userRole));
                }

                var symmetricSecurityKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_configuration["JWT:Secret"]));
                var sigingCredentials = new SigningCredentials(symmetricSecurityKey, SecurityAlgorithms.HmacSha256);
                var jwtSecurityToken = new JwtSecurityToken(
                issuer: _configuration["JWT:ValidIssuer"],
                audience: _configuration["JWT:ValidAudience"],
                claims: authClaims,
                expires: DateTime.Now.AddMinutes(60),
                signingCredentials: sigingCredentials);
                return Ok(new
                {
                    token = new JwtSecurityTokenHandler().WriteToken(jwtSecurityToken)
                });
            }
            return Unauthorized();
        }
    }
}
