using project.Shared;

namespace project.Client.Services.CategoryService
{
    public interface ISubCategoryService
    {
        event Action OnChange;
        List<SubCategory> SubCategories { get; set; }
        // List<Category> AdminCategories { get; set; }
        Task GetSubCategories();
        // Task GetAdminCategories();
        // Task AddCategory(Category category);
        // Task UpdateCategory(Category category);
        // Task DeleteCategory(int categoryId);
        // Category CreateNewCategory();
    }
}
