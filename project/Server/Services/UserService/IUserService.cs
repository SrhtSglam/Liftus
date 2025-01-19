using project.Shared;

namespace project.Server.Services.UserService
{
    public interface IUserService
    {
        Task<ServiceResponse<List<User>>> GetUsers();
    }
}
