// using Alumno.Menu;
// using UserData.Menu;
// using ProfessorData.Menus;
// using Cordinator.Menus;
// using Almacenista.Menu;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();


//Hacer la conexion a la base de datos, en vez de WorkingWithEFCore.AutoGen.Northwind, seria el using
// correspondiente a la tabla que le toca, como yo hice referencia a Northwind
//hice referencia hacia todas las tablas, si pudieramos hacer eso
//nos ahorraria hacer un ADDDbContext para cada tabla o hacernos mas bolas con las tablas
//Ademas, en GetConnectionString("Northwind"), es el nombre del archivo creo, o del tipo
//En este caso era Nortwind
//Dudas, pregunten a Penilla, o pregunten a chatgpt como funciona toda la linea de abajo comentada
//tambien pueden preguntar a perplexity.ia (Asi busquenlo en google), sobre la linea de codio
//o a copilot


// builder.Services.AddDbContext<WorkingWithEFCore.AutoGen.Northwind>(options =>
//     options.UseSqlite(builder.Configuration.GetConnectionString("Northwind")));

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
