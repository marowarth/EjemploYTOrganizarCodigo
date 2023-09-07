using Core.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Home.Entities
{
    public class Home : Entity
    {
        public string cerveza { get; set; }
        public decimal? grados {  get; set; }
    }
}
