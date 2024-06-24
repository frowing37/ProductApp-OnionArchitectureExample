using MediatR;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Components;
using ProductApp.Application.Features.Commands.CreateProduct;
using ProductApp.Application.Features.Queries.GetAllProducts;
using ProductApp.Application.Interfaces.Repository;

namespace ProductApp.WebApi.Controllers;

[Microsoft.AspNetCore.Mvc.Route("api/[controller]")]
[ApiController]
public class ProductController : ControllerBase
{
    private readonly IMediator _mediator;

    public ProductController(IMediator mediator)
    {
        _mediator = mediator;
    }

    [HttpGet]
    public async Task<IActionResult> Get()
    {
        var query = new GetAllProductsQuery();
        return Ok(await _mediator.Send(query));
    }

    [HttpPost]
    public async Task<IActionResult> Post(CreateProductCommand command)
    {
        return Ok(await _mediator.Send(command));
    }
    
}