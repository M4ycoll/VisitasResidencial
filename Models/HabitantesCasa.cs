using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Visitas_residencial.Models;

public class HabitantesCasa
{
    [ForeignKey("Id")]
    public Guid Id { get; set; }

    [Required]
    [MaxLength(250)]
    public Guid? CasaId { get; set; }

    [Required]
    [MaxLength(250)]
    public Guid? ResidenteId { get; set; }

    [MaxLength(250)]
    public string? Parentesco { get; set; }

    
    public virtual ICollection<Casa> ?Casas { get; set; }
    public virtual ICollection<Residente> ?Residentes { get; set; }
}