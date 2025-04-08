using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace inv.reg.ped.online.models
{
    class IdentificadoresDeUsers
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string idUser { get; set; }
        [ForeignKey("idUser")]
        public int TipoDePermiso { get; set; }


        


     }
}
