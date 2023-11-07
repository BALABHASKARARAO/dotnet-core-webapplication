var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => "java home , dontet applciation");

app.Run();
