using PizzeriaPlace.BLL;

namespace PizzeriaPlace.Models
{
    public class Estados
    {
        public MenuBLL Menu { get; set; }  = new MenuBLL();
        public CestaDCompras CestaDCompras { get; } = new CestaDCompras();
        public InterfazUsuario Interfaz { get; set; } = new InterfazUsuario();
        public decimal PrecioTotal => CestaDCompras.Pedidos.Sum(Id => Menu.ObtenerPizzas(Id)!.Precio);


    }
}
