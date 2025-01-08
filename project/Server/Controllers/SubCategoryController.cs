using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace project.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SubCategoryController : ControllerBase
    {
        private readonly ISubCategoryService _subCategoryService;

        public SubCategoryController(ISubCategoryService subCategoryService)
        {
            _subCategoryService = subCategoryService;
        }

        [HttpGet]
        public async Task<ActionResult<ServiceResponse<List<SubCategory>>>> GetSubCategories()
        {
            var result = await _subCategoryService.GetSubCategories();
            return Ok(result);
        }

        // [HttpGet("admin"), Authorize(Roles = "Admin")]
        // public async Task<ActionResult<ServiceResponse<List<Category>>>> GetAdminCategories()
        // {
        //     var result = await _subCategoryService.GetAdminCategories();
        //     return Ok(result);
        // }

        // [HttpDelete("admin/{id}"), Authorize(Roles = "Admin")]
        // public async Task<ActionResult<ServiceResponse<List<Category>>>> DeleteCategory(int id)
        // {
        //     var result = await _subCategoryService.DeleteCategory(id);
        //     return Ok(result);
        // }

        // [HttpPost("admin"), Authorize(Roles = "Admin")]
        // public async Task<ActionResult<ServiceResponse<List<Category>>>> AddCategory(Category category)
        // {
        //     var result = await _subCategoryService.AddCategory(category);
        //     return Ok(result);
        // }

        // [HttpPut("admin"), Authorize(Roles = "Admin")]
        // public async Task<ActionResult<ServiceResponse<List<Category>>>> UpdateCategory(Category category)
        // {
        //     var result = await _subCategoryService.UpdateCategory(category);
        //     return Ok(result);
        // }
    }
}
