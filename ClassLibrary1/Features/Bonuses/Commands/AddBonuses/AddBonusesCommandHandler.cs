using EmployeeBonusManagementSystem.Application.Contracts.Persistence;
using EmployeeBonusManagementSystem.Domain.Entities;
using MediatR;

namespace EmployeeBonusManagementSystem.Application.Features.Bonuses.Commands.AddBonuses;

public class AddBonusesQueryHandler(
    IUnitOfWork unitOfWork
    /*JsonWebToken როლები*/)
    : IRequestHandler<AddBonusesQuery, List<AddBonusesDto>>
{
    public async Task<List<AddBonusesDto>> Handle(
        AddBonusesQuery request,
        CancellationToken cancellationToken)

    {
        // თანამშრომლის ნახვა PersonalNumber ით
        try
        {
            await unitOfWork.OpenAsync();
            await unitOfWork.BeginTransactionAsync();

            var employeeExists = await unitOfWork.EmployeeRepository.GetEmployeeExistsByPersonalNumberAsync(request.PersonalNumber);
            if (!employeeExists.Item1)
            {
                throw new Exception($"თანამშრომელი პირადი ნომრით {request.PersonalNumber} არ მოიძებნა.");
            }


            var bonuses = await unitOfWork.BonusRepository.AddBonusAsync(new BonusEntity
            {
                EmployeeId = employeeExists.Item2,
                Amount = request.BonusAmount
            });

            await unitOfWork.CommitAsync();

            return bonuses;
        }

        catch (Exception ex)
        {
            await unitOfWork.RollbackAsync();
            throw new Exception(ex.Message);
        }
        finally
        {
            await unitOfWork.CloseAsync();
        }
    }
}

