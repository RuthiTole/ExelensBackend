using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using System.Net;
using System.Net.Http;
using DTO;
using BL;
using System.Web.Http.Cors;
using System.Text;

namespace WebApi.Controllers
{
    [EnableCors(origins: "*", headers: "*", methods: "*")]
    [RoutePrefix("api/Client")]
    public class ClientController : ApiController
    {
        // GET api/values
        public IHttpActionResult GetUsers()
        {
            var clients = BL.ClientBL.GetAllClients();
            if (clients == null || clients.Count == 0)
                return NotFound();
            return Ok(clients);
        }
       
        [HttpPost]
        //POST api/values
        public IHttpActionResult PostCraeteClient([FromBody]DTO.ClientDTO client)
        {
            var result = ClientBL.CreateClient(client);
            if (result)
                return Ok(result);
            return NotFound();
        }
      

        
    }
}
