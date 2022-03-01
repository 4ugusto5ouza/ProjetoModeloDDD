using Microsoft.EntityFrameworkCore;
using ProjetoModeloDDD.Domain.Entities;
using ProjetoModeloDDD.Infra.Data.EntitiesConfig;

namespace ProjetoModeloDDD.Infra.Data.Context
{
    public class ProjetoModeloDDDContext : DbContext
    {
        public ProjetoModeloDDDContext()
        {                
        }

        public ProjetoModeloDDDContext(DbContextOptions<ProjetoModeloDDDContext> options) 
            : base(options)
        {
            Database.EnsureCreated();
        }

        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Produto> Produtos { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=DESKTOP-AUGUSTO\\SQLEXPRESS;Initial Catalog=ProjetoModeloDDDDB;Integrated Security=SSPI;Persist Security Info=False;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration<Cliente>(new ClienteMap());
            modelBuilder.ApplyConfiguration<Produto>(new ProdutoMap());
            //new ClienteMap().Configure(modelBuilder.Entity<Cliente>());
            //new ProdutoMap().Configure(modelBuilder.Entity<Produto>());
        }
    }
}
