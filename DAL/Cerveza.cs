using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class Cerveza
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int CervezaID { get; set; }
        public string Nombre { get; set; }
        public int MarcaID { get; set; }

        [ForeignKey("MarcaID")]
        public virtual Marca Marca { get; set; } 
    }
}
