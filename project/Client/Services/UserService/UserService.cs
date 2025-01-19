using System.Net.Http.Json;
using project.Shared;

namespace project.Client.Services.UserService
{
    public class UserService : IUserService
    {
        private readonly HttpClient _http;

        public UserService(HttpClient http)
        {
            _http = http;
        }

        public List<User> Users { get; set; } = new List<User>();
        public string Message { get; set; }
        public event Action UsersChanged;

        public async Task GetUsers()
        {
            var result = await _http.GetFromJsonAsync<ServiceResponse<List<User>>>($"api/user/all");
            Users = result.Data;
        }
    }
}
