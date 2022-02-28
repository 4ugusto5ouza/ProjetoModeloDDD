using Microsoft.EntityFrameworkCore;
using ProjetoModeloDDD.Domain.Entities;

namespace ProjetoModeloDDD.Infra.Data.Context
{
    public class ProjetoModeloDDDContext : DbContext
    {
        public ProjetoModeloDDDContext(DbContextOptions<ProjetoModeloDDDContext> options) 
            : base(options)
        {
            Database.EnsureCreated();
        }

        DbSet<Cliente> Cliente { get; set; }
    }
}
