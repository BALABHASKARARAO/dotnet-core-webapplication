var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => "java home , dontet applciation, node js, python");

app.Run();
