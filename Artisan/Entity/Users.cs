using System;
using System.Collections.Generic;

namespace Artisan.Entity
{
    public class Users
    {
        [System.ComponentModel.DataAnnotations.Key]
        public int Userid { get; set; }
        public string FirstName { get; set; }
        public string Email { get; set; }
        public string Username { get; set; }
        public byte[] PasswordHash { get; set; }
        public byte[] PasswordSalt { get; set; }
        public string Roles { get; set; }
        public string Token { get; set; }
        public string adresse { get; set; }
        public int telephone { get; set; }
        public string etat { get; set; }
       
        public string image { get; set; }
        
        
    }
}
