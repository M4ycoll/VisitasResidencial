using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Visitas_residencial.Models;

public class Residente
{
    [ForeignKey("Id")]
    public Guid Id { get; set; }

    [Required]
    [MaxLength(250)]
    public int? Identificacion { get; set; }

    [MaxLength(250)]
    public string? Nombre { get; set; }

    [MaxLength(250)]
    public int? Telefono { get; set; }

     public virtual ICollection<HabitantesCasa> ?HabitantesCasas { get; set; }
}