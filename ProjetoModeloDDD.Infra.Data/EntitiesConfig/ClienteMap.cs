using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ProjetoModeloDDD.Domain.Entities;

namespace ProjetoModeloDDD.Infra.Data.EntitiesConfig
{
    public class ClienteMap : IEntityTypeConfiguration<Cliente>
    {
        public void Configure(EntityTypeBuilder<Cliente> builder)
        {
            builder.ToTable("Cliente");

            builder.HasKey(c => c.Id);

            builder.Property(c => c.Nome)
                   .IsRequired()
                   .HasColumnName("Nome")
                   .HasMaxLength(38);

            builder.Property(c => c.Sobrenome)
                   .IsRequired()
                   .HasColumnName("Sobrenome")
                   .HasMaxLength(48);

            builder.Property(c => c.Email)
                   .IsRequired()
                   .HasColumnName("Email")
                   .HasMaxLength(28);

            builder.Property(c => c.DataCadastro)
                   .IsRequired()
                   .HasColumnName("DataCadastro");

            builder.Property(c => c.Ativo)
                   .IsRequired()
                   .HasColumnName("Ativo");
        }
    }
}
