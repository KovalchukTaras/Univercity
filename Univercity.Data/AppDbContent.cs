using Univercity.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace Univercity.Data;

public class AppDbContent: DbContext
{
    public AppDbContent(DbContextOptions<AppDbContent> options) : base(options)
    {

    }

    public DbSet<Course> Courses { get; set; }
    public DbSet<Group> Groups { get; set; }
    public DbSet<Student> Students { get; set; }
}

