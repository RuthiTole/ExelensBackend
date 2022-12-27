using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class ClientDTO
    {
        public int Id_Client { get; set; }
        public string hebrew_name { get; set; }
        public string english_name { get; set; }
        public Nullable<System.DateTime> born_date { get; set; }
        public Nullable<int> city_code { get; set; }
        public string bank { get; set; }
        public string branch { get; set; }
        public string account_number { get; set; }
        public string identity_card { get; set; }

    }
}
