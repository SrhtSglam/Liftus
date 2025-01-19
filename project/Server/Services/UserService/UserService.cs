using Microsoft.EntityFrameworkCore;
using project.Server.Data;
using project.Shared;

namespace project.Server.Services.UserService
{
    public class UserService : IUserService
    {
        private readonly DataContext _context;

        public UserService(DataContext context)
        {
            _context = context;
        }

        public async Task<ServiceResponse<List<User>>> GetUsers()
        {
            var users = await _context.Users
                .ToListAsync();
            
            return new ServiceResponse<List<User>>{
                Data = users
            };
        }
    }
}
