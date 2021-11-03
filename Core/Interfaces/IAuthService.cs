using Core.Entities;
using Core.Models.Models;
using System.Threading.Tasks;

namespace Core.Interfaces
{
    public interface IAuthService
    {
        Task<ServiceResponse<int>> RegisterAsync(User user, string password);
        Task<ServiceResponse<string>> LoginAsync(string username, string password);
        Task<bool> UserExistsAsync(string username);
    }
}