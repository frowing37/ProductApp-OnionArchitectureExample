using AutoMapper;
using MediatR;
using ProductApp.Application.Dto;
using ProductApp.Application.Interfaces.Repository;
using ProductApp.Application.Wrappers;

namespace ProductApp.Application.Features.Queries.GetAllProducts;

public class GetAllProductsQuery : IRequest<ServiceResponse<List<ProductViewDto>>>
{
    public class GetAllProductsQueryHandler : IRequestHandler<GetAllProductsQuery, ServiceResponse<List<ProductViewDto>>>
    {
        private readonly IProductService _productService;
        private readonly IMapper _mapper;

        public GetAllProductsQueryHandler(IProductService productService, IMapper mapper)
        {
            _productService = productService;
            _mapper = mapper;
        }

        public async Task<ServiceResponse<List<ProductViewDto>>> Handle(GetAllProductsQuery request, CancellationToken cancellationToken)
        {
            var products = await _productService.GetAllAsync();

            var viewModel = _mapper.Map<List<ProductViewDto>>(products);

            return new ServiceResponse<List<ProductViewDto>>(viewModel);
        }
    }
}