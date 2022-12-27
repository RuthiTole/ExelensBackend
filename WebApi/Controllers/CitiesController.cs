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
    [RoutePrefix("api/Cities")]
    public class CitiesController : ApiController
    {
        [HttpGet]
        // GET: Cities
        public IHttpActionResult GetCities()
        {
            var cities = BL.CityBL.GetAllCities();
            if (cities == null || cities.Count == 0)
                return NotFound();
            return Ok(cities);
        }
    }
}