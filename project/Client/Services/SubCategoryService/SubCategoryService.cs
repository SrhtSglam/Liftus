using System.Net.Http.Json;
using project.Shared;

namespace project.Client.Services.CategoryService
{
    public class SubCategoryService : ISubCategoryService
    {
        private readonly HttpClient _http;

        public SubCategoryService(HttpClient http)
        {
            _http = http;
        }
        public List<SubCategory> SubCategories { get; set; } = new List<SubCategory>();
        // public List<Category> AdminCategories { get; set; } = new List<Category>();

        public event Action OnChange;

        // public async Task AddCategory(Category category)
        // {
        //     var response = await _http.PostAsJsonAsync("api/Category/admin", category);
        //     AdminCategories = (await response.Content
        //         .ReadFromJsonAsync<ServiceResponse<List<Category>>>()).Data;
        //     await GetCategories();
        //     OnChange.Invoke();
        // }

        // public Category CreateNewCategory()
        // {
        //     var newCategory = new Category { IsNew = true, Editing = true };
        //     AdminCategories.Add(newCategory);
        //     OnChange.Invoke();
        //     return newCategory;
        // }

        // public async Task DeleteCategory(int categoryId)
        // {
        //     var response = await _http.DeleteAsync($"api/Category/admin/{categoryId}");
        //     AdminCategories = (await response.Content
        //         .ReadFromJsonAsync<ServiceResponse<List<Category>>>()).Data;
        //     await GetCategories();
        //     OnChange.Invoke();
        // }

        // public async Task GetAdminCategories()
        // {
        //     var response = await _http.GetFromJsonAsync<ServiceResponse<List<Category>>>("api/Category/admin");
        //     if (response != null && response.Data != null)
        //         AdminCategories = response.Data;
        // }

        public async Task GetSubCategories()
        {
            var response = await _http.GetFromJsonAsync<ServiceResponse<List<SubCategory>>>("api/SubCategory");
            if (response != null && response.Data != null)
                SubCategories = response.Data;
        }

        // public async Task UpdateCategory(Category category)
        // {
        //     var response = await _http.PutAsJsonAsync("api/Category/admin", category);
        //     AdminCategories = (await response.Content
        //         .ReadFromJsonAsync<ServiceResponse<List<Category>>>()).Data;
        //     await GetCategories();
        //     OnChange.Invoke();
        // }
    }
}
