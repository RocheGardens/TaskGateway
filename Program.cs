using Ocelot.DependencyInjection;
using Ocelot.Middleware;

var builder = WebApplication.CreateBuilder(args);

// Add Ocelot to the service collection
builder.Services.AddOcelot();

var app = builder.Build();

// Use Ocelot middleware
app.UseRouting();

app.UseEndpoints(endpoints =>
{
    endpoints.MapControllers();
});

await app.UseOcelot(); // Ocelot middleware is added here

app.Run();
