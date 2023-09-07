using Dto.Modulos.Home.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Interfaces;

namespace Dto.Modulos.Home.Converter
{
    public class HomeConverter : IConverter<Domain.Home.Entities.Home, HomeDto>
    {
        public HomeDto Convert(Domain.Home.Entities.Home entity)
        {
            return new HomeDto
            {
                cerveza = entity.cerveza,
                grados = entity.grados
            };
        }

        public Domain.Home.Entities.Home ConvertBack(HomeDto entity)
        {
            throw new NotImplementedException();
        }

        public List<HomeDto> ConvertBulk(List<Domain.Home.Entities.Home> entities)
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }
    }
}
