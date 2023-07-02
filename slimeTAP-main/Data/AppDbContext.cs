using Microsoft.EntityFrameworkCore;
using slimeTAP.Models;
using Pomelo.EntityFrameworkCore.MySql.Infrastructure;

namespace SlimeTAP.RazorPages.Data {
    public class AppDbContext : DbContext
    {
        public DbSet<UsuarioModel>? Cliente { get; set; }
        public object? Usuario { get; internal set; }


         static readonly string connectionString = "Server=db_mysql;Port=3306;Database=slime;Uid=root;Pwd=slime;";
        protected override void OnConfiguring(DbContextOptionsBuilder options){
            options.UseMySql(connectionString,
            ServerVersion.AutoDetect(connectionString));
        }
             
        protected override void OnModelCreating(ModelBuilder modelBuilder) {
        modelBuilder.Entity<UsuarioModel>().ToTable("Usuario").HasKey(p => p.Id);
            modelBuilder.Entity<UsuarioModel>().Property(i => i.Id).ValueGeneratedOnAdd();
        }    
    }
}  