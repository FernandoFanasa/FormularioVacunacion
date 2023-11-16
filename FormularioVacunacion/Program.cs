using Formulario.AccesoDatos.MapeoFormularioVacunas;
using Formulario.AccesoDatos.Querys;
using Formulario.AccesoDatos.Querys.Interfaz;
using Formulario.AccesoDatos.Repositorios;
//using Formulario.AccesoDatos.Repositorios.IRepositorio;
using FormularioVacunacion.AccesoDAtos.Data;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System.Configuration;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
//var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");

//builder.Services.AddDbContext<ApplicationDbContext>(options =>
//    options.UseSqlServer(connectionString));
//builder.Services.AddDatabaseDeveloperPageExceptionFilter();

//builder.Services.AddDefaultIdentity<IdentityUser>(options => options.SignIn.RequireConfirmedAccount = true)
//    .AddEntityFrameworkStores<ApplicationDbContext>();

////----------------------------------
///
var strconf = builder.Configuration.GetConnectionString("DefaultConnection");


builder.Services.AddDbContext<DbContextoFormularioVacunas>(options =>
    options.UseSqlServer(strconf));
builder.Services.AddDatabaseDeveloperPageExceptionFilter();

builder.Services.AddDefaultIdentity<IdentityUser>(options => options.SignIn.RequireConfirmedAccount = true)
    .AddEntityFrameworkStores<DbContextoFormularioVacunas>();

//builder.Services.AddDbContext<DbContextoFormularioVacunas>(options =>
//        options.UseSqlServer(strconf,
//         o => o.EnableRetryOnFailure().UseQuerySplittingBehavior(QuerySplittingBehavior.SingleQuery)));


//var optionsBuilder = new DbContextOptionsBuilder<DbContextoFormularioVacunas>();
//optionsBuilder.UseSqlServer(strconf);
//using var context = new DbContextoFormularioVacunas(optionsBuilder.Options);

////----------------------------------
builder.Services.AddControllersWithViews();


//builder.Services.AddScoped<IRepositorio, Repositorio>();
builder.Services.AddScoped<IConsulta, ConsultasFormulario>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseMigrationsEndPoint();
}
else
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthentication();
app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{area=Farmacia}/{controller=Home}/{action=Index}/{id?}");
app.MapRazorPages();

app.Run();
