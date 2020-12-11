using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Artisan.Entity
{
    public class Reclamations
    {
        public int  Id { get; set; }
        public string message { get; set; }
        public int Userid { get; set; }
        [ForeignKey("Userid")]
        public virtual Users users { get; set; }
    }
}
