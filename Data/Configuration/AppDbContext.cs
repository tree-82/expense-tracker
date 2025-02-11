using ExpensesTracker.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace ExpensesTracker.Data.Configuration
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        public DbSet<Expenses> Expenses { get; set; } = default!;

        public DbSet<Note> Notes { get; set; } = default!;

        public DbSet<Fund> Funds { get; set; } = default!;
    }
}