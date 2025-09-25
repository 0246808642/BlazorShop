using AutoMapper;
using BlazorShop.Api.Model;
using BlazorShop.Api.Repository;
using BlazorShop.Models.DTOs;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BlazorShop.Api.Controllers;

[Route("api/[controller]")]
[ApiController]
public class ProductController : ControllerBase
{
    private readonly IProduct _productRepository;
    private readonly IMapper _mapper;

    public ProductController(IProduct productRepository, IMapper mapper)
    {
        _productRepository = productRepository;
        _mapper = mapper;
    }

    [HttpGet]
    public async Task<ActionResult<IEnumerable<ProductDto>>> GetItems()
    {
        try
        {
            var products = await _productRepository.GetItens();
            if (products == null)
                return NotFound();

            var productsDto = _mapper.Map<IEnumerable<ProductDto>>(products);
            return Ok(productsDto);
        }
        catch(Exception ex)
        {
            throw new Exception(ex.Message);
        }
    }

}
