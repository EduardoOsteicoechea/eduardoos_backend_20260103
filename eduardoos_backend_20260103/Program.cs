var builder = WebApplication.CreateSlimBuilder(args);

var app = builder.Build();

app.MapGet("/", () =>
{
    return "Hello";
});

app.Run();
