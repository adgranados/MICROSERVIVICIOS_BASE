using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using DATABASE_MODELS.Models;
using Microsoft.EntityFrameworkCore;


namespace API_EMPLEO.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {

        private readonly SISEContext db;


        public ValuesController(SISEContext ctx) {
            this.db = ctx;
        }



        // GET api/values
        [HttpGet]
        public ActionResult<IEnumerable<Cargos>> Get()
        {
            
            var cargos = db.Cargos;
            return cargos;
            //return new string[] { "value1", "value2" };
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public ActionResult<Cargos> Get(int id)
        {
     
            var cargos = db.Cargos.FirstOrDefaultAsync(x => x.CargoId == id.ToString()).Result;
            return cargos;
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }


        
    }
}
