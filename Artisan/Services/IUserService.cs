using Artisan.Entity;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Artisan.Services
{
    public interface IUserService
    {
        Users Create(Users user, string password);
        Users Authenticate(string email, string password);
        IEnumerable<Users> GetAll();
        Task<Users> GetbyId(int id);
        Users creatArtisan(Users user, string password);
        public IEnumerable<Users> Getart();
    }
}