using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Artisan.Dbcontext;
using Artisan.Entity;
using Artisan.Setting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;

namespace Artisan.Services
{
    public class ProduitService: IProduitService
    {
        private readonly AppSettings _appSettings;
        Datacontextcs db;
        private List<Produit> produit;



        public ProduitService(IOptions<AppSettings> appSettings, Datacontextcs _db)
        {
            _appSettings = appSettings.Value;
            db = _db;
            produit = new List<Produit>();

        }

        public async Task<IEnumerable<Produit>> getallprod()
        {
            var produit = await db.produits.Include(p => p.categorie).Include(p => p.users).ToListAsync();
            return produit;
        }

     
        public async Task<IEnumerable<Produit>> getprodbyid(int x)
        {
            var y = await db.produits.Where(p => p.Userid == x).ToListAsync();
            return y;
        }

        public async Task<IEnumerable<Produit>> getprodbyidcat(int x)
        {
            var y = await db.produits.Where(p => p.CategorieId == x).ToListAsync(); 
            return y;
        }
        public async Task<Produit>createprod(Produit produit)
        {
                  db.produits.Add(produit);
            await db.SaveChangesAsync();
            return produit;
        }

        public async Task<Produit> deleteprod(int id )
        {
            var produit = await db.produits.FirstOrDefaultAsync(p => p.produitId == id);
            db.produits.Remove(produit);
            await db.SaveChangesAsync();
            return produit;

        }
       
    }
}
