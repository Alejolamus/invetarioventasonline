using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inv.reg.ped.online.models
{
    class IdentificadoresDeUsers
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string TipoDeCuenta { get; set; }

        public int TiposDePermisos { get; set; }
        public int x { get; set; }
    }
}
