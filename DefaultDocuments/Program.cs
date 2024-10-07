var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

//rewrite the URL
var options = new DefaultFilesOptions();
options.DefaultFileNames.Clear();
options.DefaultFileNames.Add("zero-to-mastery.html");
app.UseDefaultFiles(options); // default.htm default.html index.htm index.html

//serves the file
app.UseStaticFiles();

app.Run();
