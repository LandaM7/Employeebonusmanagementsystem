﻿using EmployeeBonusManagementSystem.Application.Contracts.Persistence;
using EmployeeBonusManagementSystem.Application.Contracts.Persistence.Common;
using EmployeeBonusManagementSystem.Application.Features.Bonuses.Commands.AddBonuses;
using EmployeeBonusManagementSystem.Domain.Entities;
using Microsoft.Extensions.Configuration;
using System.Data;

namespace EmployeeBonusManagementSystem.Persistence.Repositories;

public class BonusRepository(
        ISqlQueryRepository sqlQueryRepository,
        ISqlCommandRepository sqlCommandRepository,
        IConfiguration configuration)
        : IBonusRepository

{
    public async Task<List<AddBonusesDto>> AddBonusAsync(BonusEntity bonus)

    {
        try
        {
            var bonusesResult = await sqlQueryRepository.LoadMultipleData<AddBonusesDto, dynamic>(
            "[HRManagementEmployee].[dbo].[AddBonuses]",
            new { EmployeeId = bonus.EmployeeId, BonusAmount = bonus.Amount },
            configuration.GetConnectionString("DefaultConnection"),
            CommandType.StoredProcedure);

            //await unitOfWork.CommitAsync();

            return bonusesResult.ToList();
        }
        catch (Exception ex)
        {
            throw new Exception(ex.Message);
        }
    }
}