using System;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using Swashbuckle.AspNetCore.Annotations;
using TechTestWebApi.Dtos;
using TechTestWebApi.Models;
using TechTestWebApi.Repositories;

namespace TechTestWebApi.Controllers;

[ApiController]
[Route("api/[controller]")]
public class ProductsController : ControllerBase
{
    private readonly ILogger<ProductsController> _logger;
    private readonly IProductRepository _productRepository;

    public ProductsController(
        ILogger<ProductsController> logger,
        IProductRepository productRepository)
    {
        _logger = logger;
        _productRepository = productRepository;
    }

    /// <summary>
    /// Get products for a given page
    /// </summary>
    [HttpGet]
    public async Task<ActionResult<Paginate<Product>>> GetProducts([FromQuery] PaginateParams query)
    {
        var products = await _productRepository.GetProductsAsync();
        var paginate = new Paginate<Product>(
            products.Skip((query.page - 1) * query.pageSize).Take(query.pageSize),
            products.Count(),
            query
        );
        return Ok(paginate);
    }

    /// <summary>
    /// Get specific product with the given id
    /// </summary>
    [HttpGet("{id}")]
    // [SwaggerResponse(StatusCodes.Status409NotFound)]
    public async Task<ActionResult<Product>> GetProductById(int id)
    {
        var product = await _productRepository.GetProductByIdAsync(id);
        if (product == null) return NotFound();
        return Ok(product);
    }

    /// <summary>
    /// Create a new product
    /// </summary>
    [HttpPost]
    [SwaggerResponse(StatusCodes.Status400BadRequest)]
    public async Task<ActionResult<Product>> CreateProduct([FromBody] Product body)
    {
        var product = await _productRepository.CreateProductAsync(body);
        return CreatedAtAction(nameof(GetProductById), new { id = product.Id }, product);
    }

    /// <summary>
    /// Update specific product with the given id
    /// </summary>
    [HttpPut("{id}")]
    [SwaggerResponse(StatusCodes.Status400BadRequest)]
    [SwaggerResponse(StatusCodes.Status404NotFound)]
    public async Task<ActionResult<Product>> UpdateProduct(int id, [FromBody] Product body)
    {
        var product = await _productRepository.UpdateProductAsync(id, body);
        if (product == null) return NotFound();
        return Ok(product);
    }

    /// <summary>
    /// Delete specific product with the given id
    /// </summary>
    [HttpDelete("{id}")]
    [SwaggerResponse(StatusCodes.Status204NoContent)]
    public IActionResult DeleteProduct(int id)
    {
        _productRepository.DeleteProduct(id);
        return NoContent();
    }
}
