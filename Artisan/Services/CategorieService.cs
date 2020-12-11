using Artisan.Dbcontext;
using Artisan.Entity;
using Artisan.Setting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using System.Collections.Generic;
using System.Linq;

namespace Artisan.Services
{
    public class CategorieService : ICategorieService
    {
        private readonly AppSettings _appSettings;
        Datacontextcs db;
        private List<Categorie> categorie;


        public CategorieService(IOptions<AppSettings> appSettings, Datacontextcs _db)
        {
            _appSettings = appSettings.Value;
            db = _db;
            categorie = new List<Categorie>();

        }

        public Categorie creatcat(Categorie categorie)
        {
            db.categories.Add(categorie);
            db.SaveChanges();

            return categorie;
        }

        public IEnumerable<Categorie> GetAll()
        {
            return db.categories.ToList();
        

        }




    }
}
