var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () =>
{
    // Throws an error to demonstrate error handling
    throw new InvalidOperationException();
});

app.MapGet("/error", () => "Unfortunately, an error happened.");

if (app.Environment.IsDevelopment())
{
    app.UseDeveloperExceptionPage();
}

if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/error");
}

app.Run();
