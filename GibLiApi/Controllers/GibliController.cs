using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using GibLiApi.Models;
using Microsoft.AspNetCore.Cors;

namespace GibLiApi.Controllers
{
    [Route("api/[controller]")]
    [EnableCors("MyPolicy")]
    public class GibliController : Controller
    {
        

        // GET api/values/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }


[HttpGet]
public List<GibliFilm> GetAll()
{
    var _films = new List<GibliFilm>();


    _films.Add(new GibliFilm{Title="First Title", Description= "First Description"});
    _films.Add(new GibliFilm{Title="Second Title", Description= "Second Description"});
    return _films;
}
    
}

}
