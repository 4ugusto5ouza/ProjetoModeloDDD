using Microsoft.EntityFrameworkCore;
using ProjetoModeloDDD.Domain.Entities;
using ProjetoModeloDDD.Infra.Data.EntitiesConfig;

namespace ProjetoModeloDDD.Infra.Data.Context
{
    public class ProjetoModeloDDDContext : DbContext
    {
        public ProjetoModeloDDDContext(DbContextOptions<ProjetoModeloDDDContext> options) 
            : base(options)
        {
            Database.EnsureCreated();
        }

        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Produto> Produtos { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            new ClienteMap().Configure(modelBuilder.Entity<Cliente>());
            new ProdutoMap().Configure(modelBuilder.Entity<Produto>());
        }
    }
}
