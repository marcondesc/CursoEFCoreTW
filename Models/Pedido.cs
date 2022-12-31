namespace EFCoreExample.Models;

public class Pedido
{
    public int Id { get; set; }
    public string Descricao { get; set; } = string.Empty;
    public DateTime Data { get; set; }
    public int ClienteId { get; set; }

    public Cliente Cliente { get; set; } = null!;
}