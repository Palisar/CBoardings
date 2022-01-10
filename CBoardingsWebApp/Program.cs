var builder = WebApplication.CreateBuilder(args);
//var connectionString = builder.Configuration.GetConnectionString("BoardingDbContext"); //Home Database
var connectionString = builder.Configuration.GetConnectionString("BoardingDbContextLap"); //Laptop Database
// Add services to the container.
builder.Services.AddRazorPages();

//builder.Services.AddSingleton<IBoardingData, InMemoryBoardingData>();// In memory data for testing purposes
builder.Services.AddScoped<IBoardingData, SqlBoardingData>();
builder.Services.AddDbContext<BoardingDbContext>(options =>
    options.UseSqlServer(connectionString)
    );

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

//MigrateDatabase(app);

//static void MigrateDatabase(WebApplication app)
//{
//    using (var scoped = app.Services.CreateScope())
//    {
//        var db = scoped.ServiceProvider.GetRequiredService<BoardingDbContext>();
//        db.Database.Migrate();
//    }
//}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapRazorPages();

app.Run();
