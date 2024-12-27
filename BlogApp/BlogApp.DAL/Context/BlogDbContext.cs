using BlogApp.Core.Entities;
using Microsoft.EntityFrameworkCore;

namespace BlogApp.DAL.Context;
public class BlogDbContext : DbContext
{
    public BlogDbContext(DbContextOptions options) : base(options)
    {
    }
    public DbSet<Category> Categories { get; set; }
}
