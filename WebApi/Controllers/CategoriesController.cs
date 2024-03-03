using Business.Abstract;
using Business.Dtos.Requests;
using Business.Dtos.Responses;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers;

[Route("api/[controller]")]
[ApiController]
public class CategoriesController : ControllerBase
{
    private readonly ICategoryService _categoryService;

    public CategoriesController(ICategoryService categoryService)
    {
        _categoryService = categoryService;
    }
    [HttpPost]
    public IActionResult Add(CreateCategoryRequest createCategoryRequest)
    {
        CreatedCategoryResponse createCategoryResponse = _categoryService.Add(createCategoryRequest);

        return Ok(createCategoryResponse);
    }
    [HttpGet]
    public IActionResult Get()
    {
        return Ok(_categoryService.GetList());
    }
}
