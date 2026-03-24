using Ocelot.DependencyInjection;
using Ocelot.Middleware;

var builder = WebApplication.CreateBuilder(args);

// Load Ocelot.json routing configuration
builder.Configuration
    .SetBasePath(builder.Environment.ContentRootPath)
    .AddJsonFile("Ocelot.json", optional: false, reloadOnChange: true);

builder.Services.AddControllers();
builder.Services.AddOcelot();   // Register Ocelot services

var app = builder.Build();

app.UseHttpsRedirection();
app.UseRouting();
app.UseAuthorization();
app.MapControllers();

await app.UseOcelot();   // Add Ocelot middleware (must be LAST)

app.Run();

//// Add services to the container.

//builder.Services.AddControllers();
//builder.Services.AddOcelot();
//// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
//builder.Services.AddOpenApi();

//var app = builder.Build();

//// Configure the HTTP request pipeline.

//if (app.Environment.IsDevelopment())
//{
//    app.MapOpenApi();
//}


//app.UseHttpsRedirection();

//app.UseRouting();

//app.UseAuthorization();


//app.MapControllers();

//app.UseOcelot().Wait();

//app.Run();
