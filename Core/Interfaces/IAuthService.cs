using Core.Entities;

using System.Threading.Tasks;

namespace Core.Interfaces
{
    public interface IAuthService
    {
        Task<ServiceResponse<int>> Register(User user, string password);
        Task<ServiceResponse<int>> Login(string username, string password);
        Task<bool> UserExists(string username);
     
    }
}