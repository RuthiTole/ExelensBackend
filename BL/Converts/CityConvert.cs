using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.Converts
{
 public   class CityConvert
    {
        public static CityDTO GetCityDTO(ssp_getCities_Result city)
        {
            CityDTO dto = new CityDTO()
            {
          city_code=city.city_code,
          city_name=city.city_name
            };
            return dto;
        }
        public static List<CityDTO> GetAllClientsDTO(List<ssp_getCities_Result> clientList)
        {
            List<CityDTO> list = new List<CityDTO>();
            clientList.ForEach(a => list.Add(GetCityDTO(a)));
            return list;
        }
    }
}
