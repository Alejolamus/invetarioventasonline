using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace inv.reg.ped.online.models
{
    public class Users
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Nombre { get; set; }
        public string TipoDeDoc { get; set; }
        public int NumeroDeDocumento { get; set; }
        public string Cargo { get; set; }
        [Required]
        public string Contraseña { get; set; }
        public Boolean EstadoVacacional { get; set; }

    }
}
