using Server.DbContent;
using Server.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Http;

namespace Server.Controllers
{
    public class SoldiersController : ApiController
    {
        public IEnumerable<Soldier> Get()
        {
            using (var session = NHibernateConfiguration.OpenSession())
            {
                return session.CreateCriteria<Soldier>().List<Soldier>();
            }
        }

        public Soldier Get(int id)
        {
            using (var session = NHibernateConfiguration.OpenSession())
            {
                return session.Get<Soldier>(id);
            }
        }

        // POST api/values 
        public void Post([FromBody] string value)
        {
        }

        // PUT api/values/5 
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/values/5 
        public void Delete(int id)
        {

        }
    }
}
