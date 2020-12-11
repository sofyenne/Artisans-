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
    public class Adminservicecs : IAdmin
    {
        private readonly AppSettings _appSettings;

        Datacontextcs db;
        private List<Users> users;

        public Adminservicecs(IOptions<AppSettings> appSettings, Datacontextcs _db)
        {
            _appSettings = appSettings.Value;
             db = _db;

        }

        public Users GetById(int id)
        {
            var user = db.Users.FirstOrDefault(x => x.Userid == id);
            return user.WithoutPassword();
        }


      
   
       public IEnumerable<Users>  GetAllArtisan()
        {
          
            return db.Users.WithoutPasswords();
        }

        public IEnumerable<Users> GetAll()
        {
            return db.Users.WithoutPasswords();
        }

        public void updateuser(int id)
        {

            var user = GetById(id);
            user.etat = "validé";
            db.Users.Update(user);
            db.SaveChanges();
        }

        public async Task<Users> deleteuser(int id)
        {
            var y = await db.Users.FirstOrDefaultAsync(x=>x.Userid == id );
            db.Users.Remove(y);
            await db.SaveChangesAsync();
            return y;
        }

    }
}
