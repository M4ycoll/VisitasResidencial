using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Visitas_residencial.Models;

public class Casa
{
    [ForeignKey("Id")]
    public Guid Id { get; set; }

    [Required]
    [MaxLength(250)]
    public int? Numero { get; set; }

    [MaxLength(250)]
    public int? Bloque { get; set; }

    [MaxLength(250)]
    public int? Calle { get; set; }

    [MaxLength(250)]
    public string? Referencia { get; set; }


    public virtual ICollection<Visita> ?Visitas { get; set; }
    public virtual ICollection<HabitantesCasa> ?HabitantesCasas { get; set; }
}