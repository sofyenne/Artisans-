using Artisan.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Artisan.Services
{
    public interface ICategorieService
    {
        IEnumerable<Categorie> GetAll();
        Categorie creatcat(Categorie categorie);

    }
}
