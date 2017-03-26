using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.OData;
using WebAppOData.Web.Models;

namespace WebAppOData.Web.Controllers
{
    public class ValuesController : ApiController
    {

        private readonly List<Car> _cars = new List<Car>
        {
            new Car
            {
                Id = 6,
                Make = "Eagle",
                Model = "Talon"
            },
            new Car
            {
                Id = 7,
                Make = "VW",
                Model = "Golf"
            },
            new Car
            {
                Id = 8,
                Make = "VW",
                Model = "Jetta"
            }
        };

        // GET api/values
        [EnableQuery]
        public IEnumerable<Car> Get()
        {
            return _cars;
        }

        // GET api/values/5
        public string Get(int id)
        {
            return "value";
        }

        // POST api/values
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        public void Delete(int id)
        {
        }
    }
}
