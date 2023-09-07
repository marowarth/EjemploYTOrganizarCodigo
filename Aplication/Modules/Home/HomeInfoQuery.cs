using Core.Interfaces;
using Domain.Home.IRepositories;
using Repositories.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplication.Modulos.Home
{
    public class HomeInfoQuery : IQueryViews<Domain.Home.Entities.Home>
    {
        
        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public Domain.Home.Entities.Home DoQuery()
        {
            HomeRepository _home_repository = new HomeRepository();
            return _home_repository.getHome();
        }
    }
}
