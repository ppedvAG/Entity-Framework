using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ppedv.Finex.Logic;
using ppedv.Finex.Model;

namespace ppedv.Finex.UI.Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MediApiController : ControllerBase
    {
        Core core = new Core();
        // GET: api/MediApi
        [HttpGet]
        public IEnumerable<Medikament> Get()
        {
            return core.Repository.Query<Medikament>().ToList();
        }

        // GET: api/MediApi/5
        [HttpGet("{id}", Name = "Get")]
        public Medikament Get(int id)
        {
            return core.Repository.GetById<Medikament>(id);
        }

        // POST: api/MediApi
        [HttpPost]
        public void Post([FromBody] Medikament value)
        {
             core.Repository.Add<Medikament>(value);
            core.Repository.SaveChanges();
        }

        // PUT: api/MediApi/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Medikament value)
        {
            core.Repository.Update<Medikament>(value);
            core.Repository.SaveChanges();

        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
