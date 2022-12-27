using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAL
{
    public class ClientDAL
    {
        public static List<clients> GetAllClients()
        {
            try
            {
                using (testEntities ctx = new testEntities())
                {
                    return ctx.clients.ToList();
                }
            }
            catch (Exception e)
            {
                return null;
            }
        }
      
        public static bool CreateClient(clients user)
        {
            try
            {
                using (testEntities ctx = new testEntities())
                {
                   
                    
                        ctx.clients.Add(user);
                        ctx.SaveChanges();
                       
           
                        return true;
                    
                  
                }
            }
            catch(Exception e)
            {
                return false;
            }
        }

        
    }
}
