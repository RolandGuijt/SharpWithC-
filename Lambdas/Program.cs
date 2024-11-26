using Globomantics.Backend.Repositories;
using Microsoft.AspNetCore.Mvc;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddScoped<HouseRepository>();

var app = builder.Build();

//C# 10 features: lambda natural types + attributes on lambdas
app.MapGet("/houses", ([FromServices] HouseRepository repo) => repo.GetAll());

app.Run();

//this didn't work before C# 10
var del = (string s) => int.Parse(s);

PassingOn(del);

PassingOn((string s) => int.Parse(s));

PassingOn(object (string s) => s == "Zero" ? s : int.Parse(s));

static void PassingOn(Delegate converter)
{

}