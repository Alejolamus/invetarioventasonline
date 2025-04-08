using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace inv.reg.ped.online.models
{
    public class Pedidos
    {
        [Key]
        public int Id { get; set; }
        public int IdVenta { get; set; }
        [ForeignKey("IdVenta")]
        public Ventas Venta { get; set; }
        [Required] 
        public string Direccion { get; set; }
        [Required]
        public string Cliente { get; set; }
        public int SaldoFaltante { get; set; }
        [Required]
        public string Tel { get; set; }
        public string Correo { get; set; }
        public DateTime FechaEntrega { get; set; }

        public bool Entregado { get; set; }
    }
}
