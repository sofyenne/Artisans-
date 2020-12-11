using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Artisan.Entity
{
    public class Produit
    {
        public int produitId { get; set; }
        public string name { get; set; }
        public string image { get; set;  }
        public int prix { get; set; }
        
        public int CategorieId { get; set; }
        [ForeignKey("CategorieId")]
        public virtual Categorie categorie { get; set; }
        public int Userid { get; set; }
        [ForeignKey("Userid")]
        public virtual Users users { get; set;  }

    }
}
