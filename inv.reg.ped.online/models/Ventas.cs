using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace inv.reg.ped.online.models
{
    public class Ventas
    {
        [Key]  
        public int Id { get; set; }

        [Required]
        public string Cliente { get; set; }
      
        public int Recaudo { get; set; }

        public int CodTransaccion { get; set; }
        public List<UnidadesVendidas> UnidadesVendidas { get; set; } = new List<UnidadesVendidas>();
        public List<Pedidos> Pedidos { get; set; } = new List<Pedidos>();
    }
}
