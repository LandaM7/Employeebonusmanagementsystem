using MediatR;

namespace EmployeeBonusManagementSystem.Application.Features.Employees.Queries.GetEmployeeSalary
{
    public record GetEmployeeSalaryQuery() : IRequest<List<GetEmployeeSalaryDto>>
    {
        public int UserId { get; set; }
    }
}
