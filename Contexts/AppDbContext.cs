using EFCoreExample.Models;
using EFCoreExample.EntityConfigs;
using Microsoft.EntityFrameworkCore;

namespace EFCoreExample.Contexts;

public class AppDbContext : DbContext
{
    public DbSet<Cliente> Clientes => Set<Cliente>();
    public DbSet<Endereco> Enderecos => Set<Endereco>();
    protected override void OnConfiguring(DbContextOptionsBuilder options)
    {
        options.UseSqlServer("Server=MCWS\\SQL2019;Database=EFCoreExample;Trusted_Connection=True;");
    }

    // se não for utiliza DataAnnotations
    protected override void OnModelCreating(ModelBuilder builder)
    {
        builder.ApplyConfiguration<Cliente>(new ClienteEntityConfig());
        builder.ApplyConfiguration<Endereco>(new EnderecoEntityConfig());
    }

}