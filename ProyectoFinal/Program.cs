using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.IdentityModel.Tokens;
using Microsoft.OpenApi.Models;
using Newtonsoft.Json;
using ProyectoFinal.Core.DTOs.Common;
using ProyectoFinal.Core.DTOs.Response;
using ProyectoFinal.Core.Interfaces.IServices;
using ProyectoFinal.Infraestructure.IoC;
using ProyectoFinal.Infraestructure.Services.ExecuteStoredProcedureServiceService;
using ProyectoFinal.Infraestructure.Services.SendEmailService;
using ProyectoFinal.Infraestructure.Services.SqlCommandService;
using Swashbuckle.AspNetCore.Filters;
using System.Net;
using System.Reflection;
using System.Text;


var builder = WebApplication.CreateBuilder(args);
var services = builder.Services;
var configuration = new ConfigurationBuilder()
    .SetBasePath(AppContext.BaseDirectory)
    .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
    .AddEnvironmentVariables()
    .Build();


services.AddProyectoFinal(configuration);
services.AddScoped<IExecuteStoredProcedureServiceService, ExecuteStoredProcedureServiceService>();
services.AddScoped<ISqlCommandService, SqlCommandService>();
services.AddScoped<ISendEmailService, SendEmailService>();
var appSettingSection = configuration.GetSection("AppSettings");
builder.Services.Configure<AppSettings>(appSettingSection);


var appSettings = appSettingSection.Get<AppSettings>();
var key = Encoding.ASCII.GetBytes(appSettings.SecretToken);


builder.Services.AddAuthentication(d =>
{
    d.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
    d.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
})
    .AddJwtBearer(d =>
    {
        d.RequireHttpsMetadata = false;
        d.SaveToken = true;
        d.TokenValidationParameters = new TokenValidationParameters
        {
            ValidateIssuerSigningKey = true,
            IssuerSigningKey = new SymmetricSecurityKey(key),
            ValidateIssuer = false,
            ValidateAudience = false,
        };
        d.Events = new JwtBearerEvents
        {
            OnChallenge = context =>
            {
                context.HandleResponse();

                if (!context.Response.HasStarted)
                {
                    context.Response.StatusCode = (int)HttpStatusCode.Unauthorized;
                    context.Response.ContentType = "application/json";
                    var respuesta = new ResponseDTO
                    {
                        IsSuccess = false,
                        Message = "Unauthorized: Invalid credentials or access denied.",
                        Data = null
                    };

                    var result = JsonConvert.SerializeObject(respuesta);

                    return context.Response.WriteAsync(result);
                }

                return Task.CompletedTask;
            }
        };
    });


builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();


builder.Services.AddSwaggerGen(c =>
{


    c.SwaggerDoc("v1", new OpenApiInfo
    {
        Title = "MultiStock Enterprise Suite",
        Version = "v1",
        Description = ""
    });
    c.AddSecurityDefinition("Bearer", new OpenApiSecurityScheme
    {
        Description = "Token de autenticación Bearer",
        Type = SecuritySchemeType.Http,
        Scheme = "bearer"
    });

    c.AddSecurityRequirement(new OpenApiSecurityRequirement
    {
        {
            new OpenApiSecurityScheme
            {
                Reference = new OpenApiReference
                {
                    Type = ReferenceType.SecurityScheme,
                    Id = "Bearer"
                }
            },
            new List<string>()
        }
    });



    c.ExampleFilters();
    var xmlFile = $"{Assembly.GetExecutingAssembly().GetName().Name}.xml";
    var xmlPath = Path.Combine(AppContext.BaseDirectory, xmlFile);
    c.IncludeXmlComments(xmlPath);
});
builder.Services.AddSwaggerExamplesFromAssemblies(Assembly.GetEntryAssembly());

var app = builder.Build();
{
    app.UseSwagger();

    app.UseSwaggerUI(
        c =>
        {
            c.SwaggerEndpoint("/swagger/v1/swagger.json", "MultiStock Enterprise Suite, SENA");
            c.DefaultModelsExpandDepth(-1);
        }); app.UseSwagger();
}

app.UseHttpsRedirection();

app.UseAuthentication();

app.UseAuthorization();

app.MapControllers();

app.Run();

