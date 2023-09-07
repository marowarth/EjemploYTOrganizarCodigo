using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Home.IRepositories
{
    public interface IHomeRepository
    {
        public Entities.Home getHome();
    }
}
