using System.ComponentModel.DataAnnotations;

namespace PizzeriaPlace.Models
{
    public class Clientes
    {
        [Key]
        public int ClienteId { get; set; } 

        [Required(ErrorMessage = "Proporcione su nombre")]
        public string Nombre { get; set; } = default!;
        [Required(ErrorMessage = "Ingrese una calle con el numero de la casa")]
        public string Calle { get; set; } = default!;
        [Required(ErrorMessage = "Ingrese una ciudad")]
        public string Ciudad { get; set; } = default!;
    }
}
