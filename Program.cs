using api;
using api.Data;
using api.models;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args); //

// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddDbContext<ApplicationDbContext>(options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"));
});


var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

// app.MapGet("/company/{id}", async (int id, ApplicationDbContext db) =>
//     await db.Todos.FindAsync(id)
//         is Company company
//         ? Results.Ok(company)
//         : Results.NotFound());
//
//
// app.MapPost("/company", async (Company company, ApplicationDbContext db) =>
// {
//     db.Todos.Add(company);
//     await db.SaveChangesAsync();
//     return Results.Created("/company/{id}", company);
// });


app.UseHttpsRedirection();
app.Run();