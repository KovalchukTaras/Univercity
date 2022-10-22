using Univercity.Data.Interfaces;
using Univercity.Data;
using Microsoft.EntityFrameworkCore;
using Univercity.Data.Repository;
using Univercity.Application.Interfaces;
using Univercity.Application;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<AppDbContent>(options =>
{
options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"), b => b.MigrationsAssembly("Univercity.UI"));
});

builder.Services.AddRazorPages();
builder.Services.AddControllersWithViews();

builder.Services.AddTransient<ICourseRepository, CourseRepository>();
builder.Services.AddTransient<IGroupRepository, GroupRepository>();
builder.Services.AddTransient<IStudentRepository, StudentRepository>();
builder.Services.AddTransient<ICourseService, CourseService>();
builder.Services.AddTransient<IGroupService, GroupService>();
builder.Services.AddTransient<IStudentService, StudentService>();

builder.Services.AddMvc();


var app = builder.Build();

if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

var scope = app.Services.CreateScope();
AppDbContent content = scope.ServiceProvider.GetRequiredService<AppDbContent>();
DbObjects.Initial(content);

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Courses}/{action=AllCourses}/{id?}");

app.Run();