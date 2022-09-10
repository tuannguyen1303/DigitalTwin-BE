using DigitalTwin.Api.Middlewares;
using DigitalTwin.Common.Extensions;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AutoRegisterServices(builder.Configuration,
    typeof(Program).Assembly,
    typeof(DigitalTwin.Business.Assembly).Assembly,
    typeof(DigitalTwin.Common.Assembly).Assembly,
    typeof(DigitalTwin.Models.Assembly).Assembly,
    typeof(DigitalTwin.Data.Assembly).Assembly);

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    // Enable middleware to serve generated Swagger as a JSON endpoint.
    app.UseSwagger();

    // Enable middleware to serve swagger-ui (HTML, JS, CSS, etc.),
    // specifying the Swagger JSON endpoint.
    app.UseSwaggerUI(c =>
    {
        c.SwaggerEndpoint("/swagger/v1/swagger.json", "PET Digital Twin v1");
    });
    
    app.UseDeveloperExceptionPage();
}

app.UseUrlRewriter(builder.Configuration);

app.UseDefaultFiles();

app.UseStaticFiles();

app.UseMiddleware<HeaderMiddleware>();

app.UseMiddleware<LoggerMiddleware>();

app.UseCustomExceptionHandler(app.Environment);

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
