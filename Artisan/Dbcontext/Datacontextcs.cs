using Artisan.Entity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Artisan.Dbcontext
{
    public class Datacontextcs: DbContext
    {
        public Datacontextcs(DbContextOptions<Datacontextcs> options) : base(options)
        {


        }
        public DbSet<Users> Users { get; set; }
       
        
        public DbSet<Categorie> categories { get; set; }

        public DbSet<Produit> produits { get; set; }
        public DbSet<Reclamations> reclamations { get; set; }







    }


}






 
