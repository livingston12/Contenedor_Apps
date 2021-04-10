using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidade
{
   public class Eproductos
    {
        public string a { get; set; }
        public int Id { get; set; }
        public string descripcion { get; set; }
        public string refencia { get; set; }
        public string marca { get; set; }
        public string fabricante { get; set; }
        public int cantidad { get; set; }
        public int precio_mayor { get; set; }
        public int precio_venta { get; set; }
        public int precio_compra { get; set; }

        public int total { get; set; }
    }
}
