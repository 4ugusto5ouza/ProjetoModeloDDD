using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ProjetoModeloDDD.Domain.Entities;

namespace ProjetoModeloDDD.Infra.Data.EntitiesConfig
{
    public class ProdutoMap : IEntityTypeConfiguration<Produto>
    {
        public void Configure(EntityTypeBuilder<Produto> builder)
        {
            builder.ToTable("Produto");

            builder.HasKey(p => p.Id);

            builder.Property(p => p.Descricao)
                .IsRequired()
                .HasColumnName("Descricao")
                .HasMaxLength(256);

            builder.Property(p => p.Preco)
                .IsRequired()
                .HasColumnName("Preco")
                .HasColumnType("decimal(18,4)");

            builder.Property(p => p.Disponivel)
                .IsRequired()
                .HasColumnName("Disponivel");

            builder.Property(p => p.ClienteId)
                .IsRequired()
                .HasColumnName("ClienteId");

            builder.HasOne(p => p.Cliente)
                .WithMany(c => c.Produtos)
                .HasForeignKey(p => p.ClienteId);

        }
    }
}
