namespace EmployeeBonusManagementSystem.Application.Features.Employees.Queries.GetEmployeeBonus
{
    public class GetEmployeeBonusDto
    {
        public decimal Amount { get; set; }
        public DateTime DateOfBonus { get; set; }
        public string Reason { get; set; }

    }
}