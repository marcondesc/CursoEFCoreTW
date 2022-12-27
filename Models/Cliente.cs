namespace EFCoreExample.Models;

public class Cliente
{
    public int Id { get; set; }

    public string Name { get; set; } = string.Empty;

    public string Cpf { get; set; } = string.Empty;

    public Endereco Endereco { get; set; } = null!;

    // só pra facilitar na hora de ler no console
    public override string ToString()
    {
        return $"{Id}. {Name} - {Cpf}";
    }
}


/*
exemplo usando Data Annotations:

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EFCoreExample.Models;

[Table("clientes")]
public class Cliente
{
    [Key]
    [Column("id")]
    public int Id { get; set; }

    [Column("nome", TypeName = "nvarchar(100)")]
    [MaxLength(100)]
    public string Name { get; set; } = string.Empty;

    [Column("cpf", TypeName = "nvarchar(14)")]
    public string Cpf { get; set; } = string.Empty;
}
*/