using FluentValidation;
using Microsoft.EntityFrameworkCore;
using PetSitter.API.Middlewares;
using PetSitter.Application;
using PetSitter.Application.Abstractions;
using PetSitter.Application.Validators;
using PetSitter.Infrastructure;
using PetSitter.Infrastructure.Repository;
using SharpGrip.FluentValidation.AutoValidation.Mvc.Extensions;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddScoped<AnimalService>();
builder.Services.AddScoped<IAnimalsRepository, AnimalRepository>();

builder.Services.AddApplication();

builder.Services.AddFluentValidationAutoValidation(configuration =>
{
    configuration.OverrideDefaultResultFactoryWith<CustomResultFactory>();
});


builder.Services.AddScoped<IUserRepository, UserRepository>();

builder.Services.AddScoped<PetSitterDbContext>();

var app = builder.Build();

app.UseMiddleware<ExceptionMiddleware>();

// using (var scope = app.Services.CreateScope())
// {
//     var dbContext = scope.ServiceProvider.GetRequiredService<PetSitterDbContext>();
//     dbContext.Database.Migrate();
// }

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseAuthorization();

app.MapControllers();

app.Run();