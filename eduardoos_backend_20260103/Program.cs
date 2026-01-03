var builder = WebApplication.CreateSlimBuilder(args);

var app = builder.Build();

app.MapGet("/api", () =>
{
    return "Hello there testing service after setting port";
});

app.Run();
