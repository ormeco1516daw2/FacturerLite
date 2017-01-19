using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;

namespace FacturerLitePro
{
    [Table("productes")]
    public class Productes
    {
        [Key]
        [Column("id_Producte")]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int idProducte { get; set; }

        [Column("Producte")]
        public string Producte { get; set; }

        [Column("Preu")]
        public float Preu { get; set; }
    }
}
