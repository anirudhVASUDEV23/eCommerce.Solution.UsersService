using eCommerce.API.Middlewares;
using eCommerce.Core;
using eCommerce.Core.Mappers;
using eCommerce.Infrastructure;
using System.Text.Json.Serialization;

var builder = WebApplication.CreateBuilder(args);

//Adding infrastructure services and core services to the DI container
builder.Services.AddInfrastructure();
builder.Services.AddCore();

//Add controllers to the DI container
builder.Services.AddControllers()
    .AddJsonOptions(options =>
    {
        options.JsonSerializerOptions.Converters.Add(new JsonStringEnumConverter());
    })
    ;

//Adding the AutoMapper service to the DI container and specifying the assembly containing the mapping profiles
builder.Services.AddAutoMapper(cfg=>{ },typeof(ApplicationUserMappingProfile).Assembly);



var app = builder.Build();

//Exception handling middleware
app.UseExceptionHandlingMiddleware();

//Routing
app.UseRouting();


//Auth
app.UseAuthentication();
app.UseAuthorization();

//Controller routes
app.MapControllers();
app.Run();
