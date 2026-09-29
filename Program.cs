using FitnessTracker.Data;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddRazorPages();
builder.Services.AddDbContext<FitnessDbContext>(options =>
    options.UseSqlite("Data Source=fitness.db"));

var app = builder.Build();
using (var scope = app.Services.CreateScope())
{
    var db = scope.ServiceProvider.GetRequiredService<FitnessDbContext>();
    db.Database.EnsureCreated();
    SeedData.Initialize(db);
}
app.UseStaticFiles();
app.MapRazorPages();
app.Run();