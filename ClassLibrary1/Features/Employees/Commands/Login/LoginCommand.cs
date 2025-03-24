using EmployeeBonusManagementSystem.Application.Features.Employees.Common;
using MediatR;

namespace EmployeeBonusManagementSystem.Application.Features.Employees.Commands.Login
{
    public record LoginCommand : IRequest<AuthResponse>
    {
        public LoginDto LoginDto { get; }

        public LoginCommand(LoginDto loginDto)
        {
            LoginDto = loginDto;
        }
    }
}