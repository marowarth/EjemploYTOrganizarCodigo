using Domain.Home.IRepositories;
using Core.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Home.Entities;

namespace Repositories.Repositories
{
    public class HomeRepository : Repository<Domain.Home.Entities.Home>, IHomeRepository
    {
        public Home getHome()
        {
            return new Home { 
                id=1,
                cerveza="Amstel",
                grados=decimal.Parse("4,5"),
                CreatedBy=1,
                ModifiedBy=1,
                Creation=DateTime.UtcNow,
                LastModified=DateTime.UtcNow,
            };
        }
    }
}
