using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Components;
using ProductApp.Application.Interfaces.Repository;

namespace ProductApp.WebApi.Controllers;

[Microsoft.AspNetCore.Mvc.Route("api/[controller]")]
[ApiController]
public class ProductController : ControllerBase
{
    private readonly IProductService _productService;

    public ProductController(IProductService productService)
    {
        _productService = productService;
    }
    
    
}