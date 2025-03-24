using EmployeeBonusManagementSystem.Application.Features.Employees.Common;
using MediatR;

namespace EmployeeBonusManagementSystem.Application.Features.Employees.Queries;

public record GetAllEmployeesQuery() : IRequest<List<EmployeeDto>>;

