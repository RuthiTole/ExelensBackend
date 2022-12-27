using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.Converts
{
    public static class ClientConvert
    {
        public static ClientDTO GetClientDTO(clients client)
        {
            ClientDTO dto = new ClientDTO()
            {
                Id_Client = client.Id_Client,
                hebrew_name = client.hebrew_name,
                english_name = client.english_name,
                bank = client.bank,
                branch = client.branch,
                account_number = client.account_number,
                born_date = client.born_date,
                city_code = client.city_code,
                identity_card = client.identity_card
            };
            return dto;
        }
        public static clients GetClient(ClientDTO clientDTO)
        {
            clients client = new clients()
            {
                Id_Client = clientDTO.Id_Client,
                hebrew_name = clientDTO.hebrew_name,
                english_name = clientDTO.english_name,
                bank = clientDTO.bank,
                branch = clientDTO.branch,
                account_number = clientDTO.account_number,
                born_date = clientDTO.born_date,
                city_code = clientDTO.city_code,
                identity_card = clientDTO.identity_card
            };
            return client;
        }
        public static List<ClientDTO> GetAllClientsDTO(List<clients> clientList)
        {
            List<ClientDTO> list = new List<ClientDTO>();
            clientList.ForEach(a => list.Add(GetClientDTO(a)));
            return list;
        }
    }
}
