var builder = WebApplication.CreateSlimBuilder(args);

var app = builder.Build();

app.MapGet("/", () =>
{
    return "Hello there testing service after setting port";
});

app.Run();
