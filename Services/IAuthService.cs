using System.Threading.Tasks;
using UserManagementAPI.DTOs;


namespace UserManagementAPI.Services
{
    public interface IAuthService
    {
        Task<string> Authenticate(LoginDto loginDto);
    }
}
