using ControleDespesasApp.Infra.Database;
using ControleDespesasApp.Services;

var builder = WebApplication.CreateBuilder(args);
// Add  context db
builder.Services.AddDbContext<ControleDespesasContext>();

// Add injeção dependencia
builder.Services.AddScoped<IDespesaService, DespesaService>();

// Add services to the container.
builder.Services.AddControllersWithViews();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
}
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Despesa}/{action=Index}/{id?}");

app.Run();
