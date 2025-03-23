using System.Data;

namespace EmployeeBonusManagementSystem.Application.Contracts.Persistence
{
    public interface IDbConnectionFactory
    {
        IDbConnection CreateConnection();

    }
}