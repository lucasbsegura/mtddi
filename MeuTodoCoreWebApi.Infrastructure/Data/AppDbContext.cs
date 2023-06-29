using MeuTodoCoreWebApi.Infrastructure.Models;
using Microsoft.EntityFrameworkCore;

namespace MeuTodoCoreWebApi.Infrastructure.Data
{
    public class AppDbContext : DbContext
    {
        public DbSet<Todo> Todos { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) => optionsBuilder.UseSqlite("DataSource=MeuTDCore.db;Cache=Shared");

    }
}
