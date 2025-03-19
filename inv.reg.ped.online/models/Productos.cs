using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace inv.reg.ped.online.models
{
    public class Productos
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Nombre { get; set; }

        [Column("Cantidad en B")]
        public int CantidadEnB { get; set; }

        [Column("Cantidad Min")]
        public int CantidadMin { get; set; }

        public int Precio { get; set; }
        public List<UnidadesVendidas> UnidadesVendidas { get; set; } = new List<UnidadesVendidas>();
    }
}
