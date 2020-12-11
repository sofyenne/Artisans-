using Artisan.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Artisan.Services
{
    public interface IAdmin
    {
        Users GetById(int id);
        Task<Users> deleteuser(int id);
        IEnumerable<Users> GetAllArtisan();

        IEnumerable<Users> GetAll();

        void updateuser(int id);
    }
}
