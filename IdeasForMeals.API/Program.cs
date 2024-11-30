using IdeasForMeals.Core.Database;
using IdeasForMeals.Core.Repositories;
using IdeasForMeals.Core.Services;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

string environmentVariableName = "IdeasForMealsConnectionString";
string connectionString = Environment.GetEnvironmentVariable(environmentVariableName, EnvironmentVariableTarget.User) ?? "Environment variable was not found.";

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddScoped<IFoodRepository, FoodRepository>();
builder.Services.AddScoped<IUserFoodRepository, UserFoodRepository>();
builder.Services.AddScoped<IFoodGroupRepository, FoodGroupRepository>();
builder.Services.AddScoped<IIdeaForMealService, IdeaForMealService>();
builder.Services.AddScoped<IUserRepository, UserRepository>();
builder.Services.AddDbContext<AppDbContext>(options => options.UseNpgsql(connectionString));

builder.Services.AddCors(options =>
{
    options.AddDefaultPolicy(
        policy =>
        {
            policy.WithOrigins("http://localhost:4200").AllowAnyHeader().AllowAnyMethod().AllowCredentials();
        });
});

builder.Services.AddAuthentication(options =>
{
    options.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
    options.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
}).AddJwtBearer(options =>
{
    options.Authority = "https://philemonphilippin.eu.auth0.com/";
    options.Audience = "https://localhost:7273/api";
});


var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseCors();

app.UseAuthentication();
app.UseAuthorization();

app.MapControllers();

app.Run();
