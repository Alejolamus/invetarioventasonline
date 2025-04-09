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
        public int Cargo { get; set; }
        public Boolean EstadoVacacional { get; set; }
        public List<IdentificadoresDeUsers> IdentificadoresDeUsers { get; set; } = new List<IdentificadoresDeUsers>();

    }
}
