using MediatR;

namespace EmployeeBonusManagementSystem.Application.Features.Employees.Commands.ChaingePassword
{
    public record ChangePasswordCommand(string currentPassword, string newPassword) : IRequest<ChangePasswordDto>;
}
