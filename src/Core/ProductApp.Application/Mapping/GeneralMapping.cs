using AutoMapper;
using ProductApp.Application.Dto;
using ProductApp.Application.Features.Commands.CreateProduct;
using ProoductApp.Domain.Entities;

namespace ProductApp.Application.Mapping;

public class GeneralMapping : Profile
{
    public GeneralMapping()
    {
        CreateMap<Product, ProductViewDto>().ReverseMap();
        CreateMap<Product, CreateProductCommand>().ReverseMap();
    }
}