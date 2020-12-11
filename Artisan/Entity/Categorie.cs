 using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Artisan.Entity
{
    public class Categorie
    {
        [Key]
        public int CategorieId { get; set; }
        public  string name  { get; set; }
        public List<Produit> produit  { get; set; }



    }
    
}
