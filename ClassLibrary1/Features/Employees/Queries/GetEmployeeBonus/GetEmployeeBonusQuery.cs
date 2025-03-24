using MediatR;

namespace EmployeeBonusManagementSystem.Application.Features.Employees.Queries.GetEmployeeBonus
{
    public record GetEmployeeBonusQuery() : IRequest<List<GetEmployeeBonusDto>>

    {
        public int UserId { get; set; }

    }
}