using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace inv.reg.ped.online.models
{
    public class PermisosUsers
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string TipoDeCuenta { get; set; }
        public bool AgrProducto { get; }
        public bool Agrventa { get; }
        public bool Deleteunidadesven { get; }
        public bool DeletePruducto { get; set; }
        public bool DeleteVentatotal { get; }
        public bool ConsulVenta { get; }
        public bool Consulestadopedido { get; }

     }
}
