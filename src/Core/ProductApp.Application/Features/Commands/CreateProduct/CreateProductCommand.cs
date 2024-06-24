using AutoMapper;
using MediatR;
using ProductApp.Application.Interfaces.Repository;
using ProductApp.Application.Wrappers;
using ProoductApp.Domain.Entities;

namespace ProductApp.Application.Features.Commands.CreateProduct;

public class CreateProductCommand : IRequest<ServiceResponse<Guid>>
{
    public string Name { get; set; }
    public int Quantity { get; set; }
    public decimal Value { get; set; }
    
    public class CreateProductCommandHandler : IRequestHandler<CreateProductCommand, ServiceResponse<Guid>>
    {
        private readonly IProductService _productService;
        private readonly IMapper _mapper;

        public CreateProductCommandHandler(IProductService productService, IMapper mapper)
        {
            _productService = productService;
            _mapper = mapper;
        }

        public async Task<ServiceResponse<Guid>> Handle(CreateProductCommand request, CancellationToken cancellationToken)
        {
            var product = _mapper.Map<Product>(request);
            await _productService.AddAsync(product);

            return new ServiceResponse<Guid>(product.Id);
        }
    }
}