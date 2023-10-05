/*using AutoMapper;
using MediatR;
using MetroDelivery.Application.Contracts.Persistance;

namespace MetroDelivery.Application.Features.Menu_Product.Queries.GetListMenu_Product
{
    public class GetAllMenu_ProductsHandler : IRequestHandler<GetAllMenu_Products, List<Menu_ProductDto>>
    {
        private readonly IMenuProductRepository _menuProductRepository;
        private readonly IMapper _mapper;
        public GetAllMenu_ProductsHandler(IMenuProductRepository menuProductRepository, IMapper mapper)
        {
            this._menuProductRepository = menuProductRepository;
            this._mapper = mapper;
        }
        public async Task<List<Menu_ProductDto>> Handle(GetAllMenu_Products request, CancellationToken cancellationToken)
        {
            var menuProductList = await _menuProductRepository.GetAsync();

            var data = _mapper.Map<List<Menu_ProductDto>>(menuProductList);

            return data;
        }
    }
}
*/