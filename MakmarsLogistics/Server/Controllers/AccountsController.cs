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
    public class AccountsController : ApiController
    {
        public IEnumerable<Account> Get() 
        {
            using (var session = NHibernateConfiguration.OpenSession())
            {
                return session.CreateCriteria<Account>().List<Account>();
            }
        }

        public Account Get(int id)
        {
            using (var session = NHibernateConfiguration.OpenSession())
            {
                return session.Get<Account>(id);
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
