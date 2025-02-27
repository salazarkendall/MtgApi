using Microsoft.EntityFrameworkCore;
using MtgApi.Models;

// 1. Create the builder
var builder = WebApplication.CreateBuilder(); // args is not always needed

// 2. Add Services (i.e. Swagger, SwaggerGen, CORS, DbContext, etc.)
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddCors(options =>
{
    // Default CORS policy
    options.AddDefaultPolicy(configuration =>
    {
        configuration.AllowAnyOrigin();
        configuration.AllowAnyHeader();
        configuration.AllowAnyMethod();
    });
    // Custom CORS policy:
    options.AddPolicy(name: "CustomCORSPolicy", configuration =>
    {
        configuration.AllowAnyOrigin();
        configuration.AllowAnyHeader();
        configuration.WithMethods("GET");
    });
});
builder.Configuration.AddUserSecrets<Program>();
builder.Services.AddDbContext<ApplicationDbContext>(options =>
    options.UseSqlServer(
        builder.Configuration.GetConnectionString("DefaultConnection"))
    );

// 3. Build the app
var app = builder.Build();

// 4. Middlewares and MinimalAPI endpoints
app.UseAuthorization();
app.UseHttpsRedirection();
app.UseCors();

// 4.1 Make use of appsettings.json configurations (depending of the env):
if (app.Configuration.GetValue<bool>("UseSwagger"))
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

if (app.Configuration.GetValue<bool>("UseDeveloperExceptionPage"))
{
    app.UseDeveloperExceptionPage();
}
else
{
    app.UseExceptionHandler("/error");
}

app.MapGet("/error", () => Results.Problem());
app.MapControllers().RequireCors("CustomCORSPolicy");

// 5. Run the app
app.Run();