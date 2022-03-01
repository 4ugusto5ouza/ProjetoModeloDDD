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
                   .HasColumnName("Nome")
                   .IsRequired()
                   .HasMaxLength(38);

            builder.Property(c => c.Sobrenome)
                   .HasColumnName("Sobrenome")
                   .IsRequired()
                   .HasMaxLength(48);

            builder.Property(c => c.Email)
                   .HasColumnName("Email")
                   .IsRequired()
                   .HasMaxLength(28);

            builder.Property(c => c.DataCadastro)
                   .HasColumnName("DataCadastro")
                   .IsRequired();

            builder.Property(c => c.Ativo)
                   .HasColumnName("Ativo")
                   .IsRequired();
        }
    }
}
