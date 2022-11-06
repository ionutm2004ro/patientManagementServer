using Microsoft.AspNetCore.Mvc;
using Microsoft.OpenApi.Models;
using patientManagementServer.Data;
using Swashbuckle.AspNetCore.SwaggerUI;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen( swaggerGenOptions => 
{
    swaggerGenOptions.SwaggerDoc("v1", new OpenApiInfo { Title = "Patient Management", Version = "v1" });
});

var app = builder.Build();

app.UseSwagger();
app.UseSwaggerUI(swaggerUIOptions =>
{
    swaggerUIOptions.DocumentTitle = "Patient Management";
    swaggerUIOptions.SwaggerEndpoint("/swagger/v1/swagger.json", "Web Api for a Patient Model");
    swaggerUIOptions.RoutePrefix = string.Empty;
});

app.UseHttpsRedirection();

app.MapPost("/patients", async(Patient patientToCreate) =>
{
    bool createSuccessful = await PatientRepository.CreatePatientAsync(patientToCreate);

    if (createSuccessful)
    {
        return Results.Ok("Create successful.");
    }
    else
    {
        return Results.BadRequest();
    }
}).WithTags("Patients Endpoints");

app.MapGet("/patients", 
    async (string sortBy, string direction, string? town, string? firstname, string? lastname, string? patientsex, int? offset, int? limit) => 
    await PatientRepository.GetPatientsAsync(sortBy, direction,town,firstname,lastname,patientsex,offset,limit)).WithTags("Patients Endpoints");

app.Run();