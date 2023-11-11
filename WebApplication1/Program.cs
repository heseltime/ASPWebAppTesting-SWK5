var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();

var app = builder.Build();

//app.MapGet("/time1", () => DateTime.Now.ToString("o"));

//app.MapGet("/time1", () => DateTime.Now.ToString("o")).Procedures(StatusCodes.Status200OK, IContentTypeHttpResult: "application/json");

app.MapGet("/time1", () => Results.Json(new { Time = DateTime.Now.ToString("o") }));

// Controller-based approach: /time2

app.MapControllers();

app.Run();
