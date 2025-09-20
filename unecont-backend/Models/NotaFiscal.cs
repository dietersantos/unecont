using System.ComponentModel.DataAnnotations;

namespace NotaFiscalApi.Models;

public class NotaFiscal
{
    [Key]
    public string Index { get; set; }
    public string Numero { get; set; }
    public string Cliente { get; set; }
    public double Valor { get; set; }
    public DateTime Emissao { get; set; }
    public DateTime Cadastro { get; set; } = DateTime.UtcNow;
}