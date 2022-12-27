using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
  public  class CityDAL
    {
        public static List< ssp_getCities_Result> GetAllCities()
        {
            try
            {
                using (testEntities ctx = new testEntities())
                {
                    return  ctx.ssp_getCities().ToList();
                   
                }
            }
            catch (Exception e)
            {
                return null;
            }
        }
    }
}
