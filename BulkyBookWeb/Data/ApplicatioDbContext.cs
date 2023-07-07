using BulkyBookWeb.Models;
using Microsoft.EntityFrameworkCore;

namespace BulkyBookWeb.Data
{
    public class ApplicatioDbContext : DbContext
    {
        public ApplicatioDbContext(DbContextOptions<ApplicatioDbContext> options) : base(options)
        {

        }

        public DbSet<Category> Categories { get; set; }
    }
}
