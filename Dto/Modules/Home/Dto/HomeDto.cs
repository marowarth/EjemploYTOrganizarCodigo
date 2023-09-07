using Core.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dto.Modulos.Home.Dto
{
    public class HomeDto : Core.Base.Dto
    {
        public int? id { get; set;}
        public string cerveza { get; set; }
        public decimal? grados { get; set; }
    }
}
