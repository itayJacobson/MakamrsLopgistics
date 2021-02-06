using FluentNHibernate.Mapping;
using Server.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server.Mapping
{
    class ClientSoldierMapping : SubclassMap<ClientSoldier>
    {
        public ClientSoldierMapping()
        {
            HasMany(x => x.Computers)
                .Inverse()
                .Cascade.All()
                .Not.LazyLoad();
        }
    }
}
