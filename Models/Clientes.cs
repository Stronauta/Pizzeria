using System.ComponentModel.DataAnnotations;

namespace PizzeriaPlace.Models
{
    public class Clientes
    {
        [Key]
        public int ClienteId { get; set; }
        public string Nombre { get; set; }
        public string Calle { get; set; }
        public string Ciudad { get; set; }
    }
}
