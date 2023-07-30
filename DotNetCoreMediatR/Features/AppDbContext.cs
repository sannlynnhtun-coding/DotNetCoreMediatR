using DotNetCoreMediatR.Features.Blog;
using Microsoft.EntityFrameworkCore;

namespace DotNetCoreMediatR.Features
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        public DbSet<BlogDataModel> Blogs { get; set; }
    }
}
