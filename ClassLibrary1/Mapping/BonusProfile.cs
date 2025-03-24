using EmployeeBonusManagementSystem.Application.Features.Employees.Queries.GetEmployeeBonus;
using EmployeeBonusManagementSystem.Domain.Entities;

namespace EmployeeBonusManagementSystem.Application.Mapping
{
    public class BonusProfile : Profile
    {
        public BonusProfile()
        {
            CreateMap<BonusEntity, GetEmployeeBonusDto>();

        }
    }
}
