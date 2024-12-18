
using cs_mvcs_and_apis_sprint.Models;
using cs_mvcs_and_apis_sprint.Services;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();

builder.Services.AddScoped<AuthorService>();
builder.Services.AddScoped<AuthorModel>();

builder.Services.AddScoped<BookService>();
builder.Services.AddScoped<BookModel>();

var app = builder.Build();

app.UseRouting();

app.UseEndpoints(endpoints =>
{
    _ = endpoints.MapControllers();
});

app.Run();
