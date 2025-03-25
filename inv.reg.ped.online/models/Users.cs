using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inv.reg.ped.online.models
{
    class Users
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Nombre { get; set; }

        [Column("Tipo de cuenta")]
        public int TipoDeCuenta { get; set; }
        [ForeignKey("TiDeCuenta")]
        public Productos Producto { get; set; }
        //Valor asignado por otro otro Proyecto de contraseña y validacion entre bases de dada
        [Column("Valdidacion Pass")]
        public Boolean ValidacionPass { get; set; }
    }
}
