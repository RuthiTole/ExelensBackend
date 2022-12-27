using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
   public class CityBL
    {
        public static List<DTO.CityDTO> GetAllCities()
        {
            return Converts.CityConvert.GetAllClientsDTO(DAL.CityDAL.GetAllCities());
        }
    }
}
