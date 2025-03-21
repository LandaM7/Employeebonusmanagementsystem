﻿using EmployeeBonusManagementSystem.Application.Features.Employees.Commands;
using EmployeeBonusManagementSystem.Application.Features.Employees.Commands.AddEmployee;
using EmployeeBonusManagementSystem.Application.Mapping;
using EmployeeBonusManagementSystem.Domain.Entities;
using EmployeeBonusManagementSystem.Persistence;
using Microsoft.AspNetCore.Identity;


// Add services to the container.
var builder = WebApplication.CreateBuilder(args);
{
    builder.Services.AddControllers();
    // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
    builder.Services.AddEndpointsApiExplorer();
    builder.Services.AddSwaggerGen(); 
    builder.Services.AddAutoMapper(typeof(EmployeeProfile));



	builder.Services.AddMediatR(cfg => cfg.RegisterServicesFromAssembly(typeof(AddEmployeeCommand).Assembly));


	builder.Services.AddPersistence(builder.Configuration);
     
}

// Configure the HTTP request pipeline.
var app = builder.Build();
{
    //if (app.Environment.IsDevelopment())
    //{
    //    app.UseSwagger();
    //    app.UseSwaggerUI();
    //}

    app.UseSwagger();

    app.UseSwaggerUI();

    app.UseHttpsRedirection();

	app.UseAuthentication();

	app.UseAuthorization();

	app.MapControllers();

    app.Run();
}

