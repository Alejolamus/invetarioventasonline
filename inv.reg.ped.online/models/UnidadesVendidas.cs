using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace inv.reg.ped.online.models
{
    public class UnidadesVendidas
    {
        [Key]
        public int Id { get; set; }

        public int IdVenta { get; set; }
        [ForeignKey("IdVenta")]
        public Ventas Venta { get; set; }
        public int IdProducto { get; set; }
        [ForeignKey("IdProducto")]
        public Productos Producto { get; set; }
        public string nProducto { get; set; }
        public int CantidadVendida { get; set; }

    }
}
