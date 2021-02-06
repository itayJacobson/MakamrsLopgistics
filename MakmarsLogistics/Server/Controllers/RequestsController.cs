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
    class RequestsController : ApiController
    {
        public IEnumerable<Request> Get()
        {
            using (var session = NHibernateConfiguration.OpenSession())
            {
                return session.CreateCriteria<Request>().List<Request>();
            }
        }

        public Request Get(int id)
        {
            using (var session = NHibernateConfiguration.OpenSession())
            {
                return session.Get<Request>(id);
            }
        }

        // POST api/values 
        public void Post([FromBody] Request value)
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
        public void Put(int id, [FromBody] Request value)
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
