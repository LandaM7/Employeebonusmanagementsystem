using EmployeeBonusManagementSystem.Application.Features.Employees.Commands.Login;
using EmployeeBonusManagementSystem.Application.Features.Employees.Common;

namespace EmployeeBonusManagementSystem.Application.Contracts.Persistence
{
    public interface IAuthService
    {

        Task<AuthResponse> LoginAsync(LoginDto loginDto);
        bool ValidatePassword(string password, out string errorMessage);

    }
}
