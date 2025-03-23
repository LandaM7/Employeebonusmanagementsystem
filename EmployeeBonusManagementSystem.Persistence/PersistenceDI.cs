﻿using EmployeeBonusManagementSystem.Application.Contracts.Persistence;
using EmployeeBonusManagementSystem.Application.Contracts.Persistence.Common;
using EmployeeBonusManagementSystem.Persistence.Repositories;
using EmployeeBonusManagementSystem.Persistence.Repositories.Common;
using EmployeeBonusManagementSystem.Persistence.Repositories.UOW;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace EmployeeBonusManagementSystem.Persistence;

public static class PersistenceDI
{
    public static IServiceCollection AddPersistence(
        this IServiceCollection services,
        IConfiguration configuration)
    {
        // DB კონტექსტის დამატება 
        services.AddDbContext<ApplicationDbContext>(options =>
            options.UseSqlServer(configuration.GetConnectionString("DefaultConnection")));

        services.AddScoped<IReportRepository, ReportRepository>();
        services.AddScoped<IEmployeeRepository, EmployeeRepository>();
        services.AddScoped<IBonusRepository, BonusRepository>();
        services.AddScoped<ISqlQueryRepository, SqlQueryRepository>();
        services.AddScoped<ISqlCommandRepository, SqlCommandRepository>();
        services.AddTransient<IUnitOfWork, UnitOfWork>();
        return services;

    }
}
