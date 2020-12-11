using AutoMapper;
using Artisan.Entity;
using Artisan.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Artisan.Setting
{
    public class AutoMapperProfile :Profile 
    {
        public AutoMapperProfile()
        {
            CreateMap<Users, UserModel>();
            CreateMap<RegisterModel, Users>();
        }
    }
}
