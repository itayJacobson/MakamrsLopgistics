using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentNHibernate;
using FluentNHibernate.Mapping;
using Server.Models;

namespace Server.Mapping
{
    public class AccountMapping : ClassMap<Account>
    {
        public AccountMapping()
        {
            Table("Accounts");

            Id(x => x.Id);

            Map(x => x.Password);
        }
    }
}
