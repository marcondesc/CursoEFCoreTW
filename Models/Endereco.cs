namespace EFCoreExample.Models;

public class Endereco
{
    //
    public int Id { get; set; }
    public string Estado { get; set; } = string.Empty;
    public string Cidade { get; set; } = string.Empty;
    public string Bairro { get; set; } = string.Empty;
    public string Logradouro { get; set; } = string.Empty;
    public string Numero { get; set; } = string.Empty;

    public int ClienteId { get; set; }
    //public Cliente Cliente { get; set; }
}