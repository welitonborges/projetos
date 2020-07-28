using Microsoft.EntityFrameworkCore;
using ProAgil.API.Model;

namespace ProAgil.API.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) { }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        { 
            
            optionsBuilder.UseSqlite("Data Source=blog.db");
        }
        public DbSet<Evento> Eventos { get; set; }
    }
}