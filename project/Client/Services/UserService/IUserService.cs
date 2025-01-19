using project.Shared;

namespace project.Client.Services.UserService
{
    public interface IUserService
    {
        event Action UsersChanged;
        List<User> Users { get; set; }
        Task GetUsers();
    }
}
