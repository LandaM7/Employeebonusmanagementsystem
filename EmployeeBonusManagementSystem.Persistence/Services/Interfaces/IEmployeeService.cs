using EmployeeBonusManagementSystem.Application.Features.Employees.Common;

namespace EmployeeBonusManagement.Application.Services.Interfaces
{
    public interface IEmployeeService<T>
    {
        //Task AddEmployeeAsync(EmployeeDto employeeDto, string role);
        Task<IEnumerable<EmployeeDto>> GetAllEmployeesAsync();
        //Task<EmployeeDto> GetEmployeeByIdAsync(string id);
    }
}