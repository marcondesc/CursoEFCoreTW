using EFCoreExample.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EFCoreExample.EntityConfigs;

public class EnderecoEntityConfig : IEntityTypeConfiguration<Endereco>
{
    public void Configure(EntityTypeBuilder<Endereco> builder)
    {
        builder.ToTable("enderecos");

        builder.Property(endereco => endereco.Id)
            .HasColumnName("id")
            .HasColumnType("int");

        builder.HasKey(endereco => endereco.Id);

        builder.Property(endereco => endereco.Estado)
            .IsRequired()
            .HasColumnName("estado")
            .HasColumnType("nvarchar(2)");

        builder.Property(endereco => endereco.Cidade)
            .IsRequired()
            .HasColumnName("cidade")
            .HasColumnType("nvarchar(100)");

        builder.Property(endereco => endereco.Bairro)
            .IsRequired()
            .HasColumnName("bairro")
            .HasColumnType("nvarchar(100)");

        builder.Property(endereco => endereco.Logradouro)
            .IsRequired()
            .HasColumnName("logradouro")
            .HasColumnType("nvarchar(max)");

        builder.Property(endereco => endereco.Numero)
            .IsRequired()
            .HasColumnName("numero")
            .HasColumnType("nvarchar(10)");

        builder.HasOne<Cliente>()
            .WithOne(cliente => cliente.Endereco)
            .HasForeignKey<Endereco>(endereco => endereco.ClienteId)
            .OnDelete(DeleteBehavior.Cascade);
    }
}
