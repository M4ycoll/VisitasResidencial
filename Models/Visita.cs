using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Visitas_residencial.Models;

public class Visita
{
    [ForeignKey("Id")]
    public Guid Id { get; set; }

    [Required]
    [MaxLength(250)]
    public DateOnly FechaEntrada { get; set; }

    [Required]
    [MaxLength(250)]
    public DateOnly FechaSalida { get; set; }

    [MaxLength(250)]
    public string? VisitanteId { get; set; }

    [MaxLength(250)]
    public Guid? CasaId { get; set; }

    [MaxLength(250)]
    public string? CodigoQR { get; set; }

    [MaxLength(250)]
    public estado Estado { get; set; }
    public enum estado{
        Soltero,
        Casado,
    }

    public virtual ICollection<Casa> ?Casas { get; set; }
    public virtual ICollection<Visitante> ?Visitantes { get; set; }
}