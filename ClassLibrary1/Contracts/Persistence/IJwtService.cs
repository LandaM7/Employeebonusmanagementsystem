using EmployeeBonusManagementSystem.Application.Features.Employees.Common;
using EmployeeBonusManagementSystem.Domain.Entities;


namespace EmployeeBonusManagement.Application.Services.Interfaces
{
    public interface IJwtService
    {
        AuthResponse GenerateToken(EmployeeEntity user, IList<string> roles);
        string GenerateRefreshToken();
    }
}


