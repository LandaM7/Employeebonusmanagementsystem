using EmployeeBonusManagementSystem.Application.Features.Employees.Common;
using MediatR;

namespace EmployeeBonusManagementSystem.Application.Features.Employees.Commands.Login
{
    internal class LoginCommandHandler : IRequestHandler<LoginCommand, AuthResponse>
    {
        private readonly IAuthService _authService;

        public LoginCommandHandler(IAuthService authService)
        {
            _authService = authService;
        }

        public async Task<AuthResponse> Handle(LoginCommand request, CancellationToken cancellationToken)
        {
            return await _authService.LoginAsync(request.LoginDto);
        }
    }
}