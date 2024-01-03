using System.Reflection;
using GasReact.BLL.Services;
using GasReact.DAL.Contexts;
using GasReact.DAL.Repositories;
using GasReact.DAL.Repositories.Implementation;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllersWithViews();

//Add DbContext in services
builder.Services.AddDbContext<GasReactorContext>();

// Injection Mapping
builder.Services.AddAutoMapper(Assembly.GetExecutingAssembly());

//DAL Dependency Injection
builder.Services.AddScoped<IFermentatorRepository, FermentatorRepository>();
builder.Services.AddScoped<ITypesIndicatorsRepository, TypesIndicatorsRepository>();
builder.Services.AddScoped<IRecordRepository, RecordRepository>();
builder.Services.AddScoped<IInicatorRepository, IndicatorRepository>();

//BLL Dependency Injection
builder.Services.AddScoped<FermentatorServices>();
builder.Services.AddScoped<TypesIndicatorsServices>();
builder.Services.AddScoped<IndicatorServices>();
builder.Services.AddScoped<ChartServices>();

var app = builder.Build();

app.UseDeveloperExceptionPage();
app.UseStatusCodePages();
app.UseStaticFiles();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();