using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using DaD___DialogArtDream.Models;

namespace DaD___DialogArtDream.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        // тестовая модель DbSet для моделей
        public DbSet<TestModel> TestModel { get; set; }
    }
}
