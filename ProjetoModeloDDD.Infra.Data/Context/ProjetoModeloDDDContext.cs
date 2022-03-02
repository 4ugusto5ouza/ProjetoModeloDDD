using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using ProjetoModeloDDD.Domain.Entities;
using ProjetoModeloDDD.Infra.Data.EntitiesConfig;

namespace ProjetoModeloDDD.Infra.Data.Context
{
    public class ProjetoModeloDDDContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string connetionString = @"Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=ProjetoModeloDDDDB;Data Source=DESKTOP-AUGUSTO\SQLEXPRESS";
            optionsBuilder.UseSqlServer(connetionString);
        }

        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Produto> Produtos { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration<Cliente>(new ClienteMap());
            modelBuilder.ApplyConfiguration<Produto>(new ProdutoMap());
        }
    }
}
