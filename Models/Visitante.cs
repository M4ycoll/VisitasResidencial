using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Visitas_residencial.Models;

public class Visitante
{
    [ForeignKey("Id")]
    public Guid Id { get; set; }

    [Required]
    [MaxLength(250)]
    public int? Identificacion { get; set; }

    [Required]
    [MaxLength(250)]
    public string? Nombre { get; set; }

    public sexo Sexo { get; set; } 
    public enum sexo{
        Masculino,
        Femenino,
        NoEspecificar,

    }



    [MaxLength(250)]
    public int? Edad { get; set; }

    
    public virtual ICollection<Visita> ?Visitas { get; set; }
}