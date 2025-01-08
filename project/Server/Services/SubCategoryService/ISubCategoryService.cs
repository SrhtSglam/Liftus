using project.Shared;

namespace project.Server.Services.CategoryService
{
    public interface ISubCategoryService
    {
        Task<ServiceResponse<List<SubCategory>>> GetSubCategories();
        // Task<ServiceResponse<List<Category>>> GetAdminCategories();
        // Task<ServiceResponse<List<Category>>> AddCategory(Category category);
        // Task<ServiceResponse<List<Category>>> UpdateCategory(Category category);
        // Task<ServiceResponse<List<Category>>> DeleteCategory(int id);
    }
}
