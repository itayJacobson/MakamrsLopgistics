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
    public class ComputersController : ApiController
    {
        public IEnumerable<Computer> Get()
        {
            using (var session = NHibernateConfiguration.OpenSession())
            {
                return session.CreateCriteria<Computer>().List<Computer>();
            }
        }

        public Computer Get(int id)
        {
            using (var session = NHibernateConfiguration.OpenSession())
            {
                return session.Get<Computer>(id);
            }
        }

        // POST api/values 
        public void Post([FromBody] Computer value)
        {
            using (var session = NHibernateConfiguration.OpenSession())
            {
                using (var transaction = session.BeginTransaction())
                {
                    session.Save(value);
                    transaction.Commit();
                }
            }
        }

        // PUT api/values/5 
        public void Put(int id, [FromBody] Computer value)
        {
            using (var session = NHibernateConfiguration.OpenSession())
            {
                using (var transaction = session.BeginTransaction())
                {
                    session.Update(value);
                    transaction.Commit();
                }
            }
        }

        // DELETE api/values/5 
        public void Delete(int id)
        {
        }
    }
}
