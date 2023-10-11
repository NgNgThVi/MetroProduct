using MetroDelivery.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MetroDelivery.Identity.Configurations.EntityConfiguration
{
    public class ProductConfiguration : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.HasData(
                new Product
                {
                    Id = Guid.Parse("45DA4260-BA13-489B-995A-1F6ADB13AB75"),
                    CategoryID = Guid.Parse("175D4C8D-D2F0-441B-85CB-45A1CB0B6756"),
                    ProductName = "Keo bông gòn",
                    Image = null,
                    ProductDescription = "Kẹo thơm ngon được tạo ra từ các loại đường, được làm nóng và tạo nên hương vị ngọt ngào",
                    Price = 5000.500
                },
                new Product

                {
                    Id = Guid.Parse("7D661A30-E180-498C-9A77-CB6112A7CB22"),
                    CategoryID = Guid.Parse("175D4C8D-D2F0-441B-85CB-45A1CB0B6756"),
                    ProductName = "Kẹo lạc",
                    Image = null,
                    ProductDescription = "Kẹo lạc thơm ngon, giòn tan",
                    Price = 3000
                },
                new Product

                {
                    Id = Guid.Parse("7DA34092-5747-42B7-B059-4A5AAD57E740"),
                    CategoryID = Guid.Parse("175D4C8D-D2F0-441B-85CB-45A1CB0B6756"),
                    ProductName = "Kẹo chup",
                    Image = null,
                    ProductDescription = "Kẹo lạc thơm ngon, giòn tan",
                    Price = 3000
                },
                new Product
                {
                    Id = Guid.Parse("B834CF11-CC28-4E7D-9846-2ACC8AD33D8C"),
                    CategoryID = Guid.Parse("8908EA98-B421-420B-9634-03ED356BB921"),
                    ProductName = "Khoai tây chiên",
                    Image = null,
                    ProductDescription = "Khoai tây chiên giòn tan",
                    Price = 10000
                },
                new Product
                {
                    Id = Guid.Parse("6D60BF44-B775-4D87-BB47-AACE85D49AC4"),
                    CategoryID = Guid.Parse("175D4C8D-D2F0-441B-85CB-45A1CB0B6756"),
                    ProductName = "Kẹo dẻo",
                    Image = null,
                    ProductDescription = "Kẹo dẻo mềm, đàn hồi",
                    Price = 2500

                }, new Product
                {
                    Id = Guid.Parse("1616CC05-8C82-4F8B-A6E0-F60AB3DE0D38"),

                    CategoryID = Guid.Parse("9AFCDFAC-1A27-496B-84E5-0C8E5804E40E"),
                    ProductName = "Cơm gà xé",
                    Image = null,
                    ProductDescription = "Cơm gà xé thơm ngon",
                    Price = 30000
                },
                new Product
                {
                    Id = Guid.Parse("D4FE048D-FF12-4715-93E7-3250F49C15C8"),
                    CategoryID = Guid.Parse("9B2CCCB2-F5FA-4358-8265-0FE4F7A52253"),
                    ProductName = "Bánh quy giòn",
                    Image = null,
                    ProductDescription = "Bánh quy giòn tan trong miệng",
                    Price = 5000
                },
                new Product
                {
                    Id = Guid.Parse("F31C789C-4A46-45C7-9009-D36681D788C5"),
                    CategoryID = Guid.Parse("175D4C8D-D2F0-441B-85CB-45A1CB0B6756"),
                    ProductName = "Kẹo Socola",
                    Image = null,
                    ProductDescription = "Kẹo sô cô la ngọt thanh",
                    Price = 10000

                },
                new Product
                {
                    Id = Guid.Parse("4ECD72E3-F43D-490F-8B46-8E92EA29F85C"),
                    CategoryID = Guid.Parse("175D4C8D-D2F0-441B-85CB-45A1CB0B6756"),
                    ProductName = "Kẹo dâu",
                    Image = null,
                    ProductDescription = "Kẹo dâu tây thơm ngon",
                    Price = 15000
                },
                new Product

                {
                    Id = Guid.Parse("0C308B93-B26A-4224-9D63-28294711AA15"),
                    CategoryID = Guid.Parse("9AFCDFAC-1A27-496B-84E5-0C8E5804E40E"),
                    ProductName = "Gà rán",
                    Image = null,
                    ProductDescription = "Gà rán giòn tan thơm ngon",
                    Price = 50000
                },
                new Product
                {
                    Id = Guid.Parse("107F1F75-B23B-4BC4-92D7-F2E90D067D1F"),
                    CategoryID = Guid.Parse("9AFCDFAC-1A27-496B-84E5-0C8E5804E40E"),
                    ProductName = "Cá chiên",
                    Image = null,
                    ProductDescription = "Cá chiên giòn rụm",
                    Price = 65000

                },
                new Product

                {
                    Id = Guid.Parse("55265D3B-FA02-4E09-84DB-D4E8C8A9A9B5"),
                    CategoryID = Guid.Parse("175D4C8D-D2F0-441B-85CB-45A1CB0B6756"),
                    ProductName = "Kẹo bạc hà",
                    Image = null,
                    ProductDescription = "Kẹo bạc hà mát lạnh",
                    Price = 5000
                },
                new Product

                {
                    Id = Guid.Parse("FFB05663-954D-4AF3-8A41-91AF39446F81"),
                    CategoryID = Guid.Parse("175D4C8D-D2F0-441B-85CB-45A1CB0B6756"),
                    ProductName = "Kẹo mút",
                    Image = null,
                    ProductDescription = "Kẹo mút mềm dẻo",
                    Price = 2500

                },
                new Product
                {
                    Id = Guid.Parse("4C9EC4B9-1C16-4C7A-90BF-D620AAB257B6"),
                    CategoryID = Guid.Parse("9AFCDFAC-1A27-496B-84E5-0C8E5804E40E"),
                    ProductName = "Gà nướng",
                    Image = null,
                    ProductDescription = "Gà nướng thơm phức",
                    Price = 80000
                },
                new Product
                {
                    Id = Guid.Parse("43203CE4-D82C-4C78-8794-2AEF22D7EC5B"),
                    CategoryID = Guid.Parse("9AFCDFAC-1A27-496B-84E5-0C8E5804E40E"),
                    ProductName = "Cơm chiên dương châu",
                    Image = null,
                    ProductDescription = "Cơm chiên dương châu thơm ngon",
                    Price = 25000
                },
                new Product
                {
                    Id = Guid.Parse("E802B6C5-F08E-4EFF-B7E7-AF95514B4341"),
                    CategoryID = Guid.Parse("B7A3A853-73C6-4F02-913B-9765019E9BD0"),
                    ProductName = "Bánh mì Sài Gòn",
                    Image = null,
                    ProductDescription = "Bánh mì siêu topping thịt trứng cút, ăn là ghiền!!!",
                    Price = 25000
                }
                );
        }
    }


}
