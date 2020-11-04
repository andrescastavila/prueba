using PRUEBA.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace PRUEBA.Controllers
{
    public class DiscoController : ApiController
    {
        // GET: api/Disco
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/Disco/5
        public Discos Get(int id)
        {
            var repo = new DiscosRepository();
            Discos d =repo.Retrieve();
            return d;
        }

        // POST: api/Disco
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/Disco/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Disco/5
        public void Delete(int id)
        {
        }
    }
}
