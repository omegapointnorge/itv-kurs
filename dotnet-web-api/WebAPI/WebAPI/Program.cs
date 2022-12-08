using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.EntityFrameworkCore;
using Microsoft.Identity.Web;
using WebAPI.Database;
using WebAPI.Todo;

var builder = WebApplication.CreateBuilder(args);

// Setup in-Memory database
builder.Services.AddDbContext<TodoDb>(opt => opt.UseInMemoryDatabase("TodoList"));


builder.Services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme)
/* 
    In a modern authentication setup would you typically validate the incoming token towards a 
    central identity provider by configuring options as seen below

    .AddJwtBearer(options =>
    {
        options.Authority = builder.Configuration.GetValue<string>("AuthorityEndpointUrl");
        options.Audience = builder.Configuration.GetValue<string>("AuthorityEndpointUrl") + "/resources";
        options.SaveToken = true;
        options.Events = new JwtBearerEvents
        {
            OnTokenValidated = c => { return Task.CompletedTask; }
        };
    })
*/
    ;


// Microsoft offer a built in dependency injection container
builder.Services.AddTransient<ITodoRepository, TodoRepository>();

builder.Services.AddControllers();

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddAuthorization(
    options => { options.AddPolicy("UserLoggedIn", policy => policy.RequireClaim("scope", "access_as_user")); });

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthentication();
app.UseAuthorization();

app.MapControllers();

app.Run();

public partial class Program
{
}