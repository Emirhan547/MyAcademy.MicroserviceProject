using ECommerce.Catalog.Dtos.CategoryDtos;
using ECommerce.Catalog.Entities;
using ECommerce.Catalog.Repositories.CategoryRepositories;
using Mapster;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Runtime.InteropServices;

namespace ECommerce.Catalog.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoriesController(ICategoryRepository _repository) : ControllerBase
    {
        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var categories = await _repository.GetAllAsync();
            return Ok(categories.Adapt<List<ResultCategoryDto>>());

        }
        [HttpPost]
        public async Task<IActionResult> Create(CreateCategoryDto createCategoryDto)
        {
            var category = createCategoryDto.Adapt<Category>();
            await _repository.CreateAsync(category);
            return Ok();
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(string id)
        {
            var category = await _repository.GetByIdAsync(id);
            if (category == null)
            {
                return BadRequest("Category Not Found");
            }
            return Ok(category.Adapt<ResultCategoryDto>());
        }
        [HttpPut]
        public async Task<IActionResult>Update(UpdateCategoryDto updateCategoryDto)
        {
            var categories = await _repository.GetByIdAsync(updateCategoryDto.Id);
            if (categories == null)
            {
                return BadRequest("Category Not Found");
            }
             categories = updateCategoryDto.Adapt<Category>();
            await _repository.UpdateAsync(categories);
            return NoContent();
        }
        [HttpDelete("{id}")]
        public async Task<IActionResult>Delete(string id)
        {
            var categories = await _repository.GetByIdAsync(id);
            if(categories == null)
            {
                return BadRequest("Category Not Found");
            }
            await _repository.DeleteAsync(id);
            return NoContent();
        }
    }
}
