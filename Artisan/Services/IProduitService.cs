using Artisan.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Artisan.Services
{
   public  interface IProduitService
    {
        Task<IEnumerable<Produit>> getallprod();
        Task<IEnumerable<Produit>> getprodbyid(int x);
        Task<Produit> createprod(Produit produit);
        Task<Produit> deleteprod(int id);
        Task<IEnumerable<Produit>> getprodbyidcat( int x ); 
    }
}
