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
    public class DB : DbContext
    {
        public DB() : base(nameOrConnectionString: "fabric") { }
        public DbSet<Productes> Productes { get; set; }
    }

}
