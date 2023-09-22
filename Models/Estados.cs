using PizzeriaPlace.BLL;

namespace PizzeriaPlace.Models
{
    public class Estados
    {
        public MenuLocal Menu { get; set; }  = new MenuLocal();
        public CestaDCompras cestaDCompras { get; } = new CestaDCompras();
        public InterfazUsuario Interfaz { get; set; } = new InterfazUsuario();
        public decimal PrecioTotal => cestaDCompras.Pedidos.Sum(Id => Menu.ObtenerPizzas(Id)!.Precio);


    }
}
