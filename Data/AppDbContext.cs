using Microsoft.EntityFrameworkCore;
using slimeTAP.Models;

namespace SlimeTAP.RazorPages.Data {
    public class AppDbContext : DbContext
    {
        public DbSet<UsuarioModel>? Cliente { get; set; }
        public object? Usuario { get; internal set; }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
            => options.UseSqlite("DataSource=seu_banco_de_dados.db;Cache=Shared");
        protected override void OnModelCreating(ModelBuilder modelBuilder) {
        modelBuilder.Entity<UsuarioModel>().ToTable("Usuario").HasKey(p => p.Id);
            modelBuilder.Entity<UsuarioModel>().Property(i => i.Id).ValueGeneratedOnAdd();
        }    
    }
}  