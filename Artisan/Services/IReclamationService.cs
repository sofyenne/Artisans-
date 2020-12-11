using Artisan.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Artisan.Services
{
   public  interface IReclamationService
    {
        Task<IEnumerable<Reclamations>> getallrec();
        Task<Reclamations> createrec(Reclamations reclamation);
        Task<Reclamations> deleterec(int id);
    }
}
