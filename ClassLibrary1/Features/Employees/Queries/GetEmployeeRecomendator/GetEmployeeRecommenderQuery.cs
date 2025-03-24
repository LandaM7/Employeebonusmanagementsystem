using MediatR;

namespace EmployeeBonusManagementSystem.Application.Features.Employees.Queries.GetEmployeeRecomendator
{
    public record GetEmployeeRecommenderQuery() : IRequest<List<GetEmployeeRecommenderDto>>
    {
        public int UserId { get; set; }
    }

}
