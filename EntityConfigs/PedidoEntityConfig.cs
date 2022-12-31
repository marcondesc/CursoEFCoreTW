using EFCoreExample.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EFCoreExample.EntityConfigs;

public class PedidoEntityConfig : IEntityTypeConfiguration<Pedido>
{
    public void Configure(EntityTypeBuilder<Pedido> builder)
    {
        builder.ToTable("pedidos");

        builder.Property(x => x.Id).HasColumnName("id");
        builder.HasKey(x => x.Id);

        builder.Property(x => x.Descricao)
        .HasColumnName("descricao")
        .HasColumnType("varchar(max)")
        .IsRequired();

        builder.Property(x => x.Data)
        .HasColumnName("data")
        .HasColumnType("datetime2")
        .IsRequired();

        //relacionamento 1:N - um cliente tem vários pedidos
        builder.HasOne(x => x.Cliente)
        .WithMany(x => x.Pedidos)
        .HasForeignKey(x => x.ClienteId)
        .IsRequired()
        .OnDelete(DeleteBehavior.Cascade);

    }
}