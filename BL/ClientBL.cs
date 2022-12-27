using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAL;
namespace BL
{
    public class ClientBL
    {
        public static List<DTO.ClientDTO> GetAllClients()
        {
            return Converts.ClientConvert.GetAllClientsDTO(DAL.ClientDAL.GetAllClients());
        }

        public static bool CreateClient(ClientDTO client)
        {
            return DAL.ClientDAL.CreateClient(Converts.ClientConvert.GetClient(client));
        }

    }
}
