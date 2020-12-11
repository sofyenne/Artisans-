using Artisan.Dbcontext;
using Artisan.Entity;
using Artisan.Setting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Artisan.Services
{
    public class ReclamationService : IReclamationService 
    {
        private readonly AppSettings _appSettings;
        Datacontextcs db;

        public ReclamationService(IOptions<AppSettings> appSettings, Datacontextcs _db)
        {
            _appSettings = appSettings.Value;
            db = _db;
            

        }
        public async Task<IEnumerable<Reclamations>> getallrec()
        {
            var rec = await db.reclamations.Include(r => r.users).ToListAsync();
            return rec; 
        }

        public async Task<Reclamations>createrec(Reclamations reclamation)
        {
            db.reclamations.Add(reclamation);
            await db.SaveChangesAsync();
            return reclamation;
        }

        public async Task<Reclamations>deleterec(int id)
        {
            var rec = await db.reclamations.FirstOrDefaultAsync(r => r.Id == id);
            db.reclamations.Remove(rec);
            await db.SaveChangesAsync();
            return rec;
        }
}
}
