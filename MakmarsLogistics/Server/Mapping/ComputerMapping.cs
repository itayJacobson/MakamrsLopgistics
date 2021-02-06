using FluentNHibernate.Mapping;
using Server.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server.Mapping
{
    public class ComputerMapping : ClassMap<Computer>
    {
        public ComputerMapping()
        {
            Table("Computers");

            Id(x => x.Id).Column("ComputerId");

            Map(x => x.Type).Column("Type");

            Map(x => x.Place).Column("Place");

            References(x => x.Soldier).Column("SoldierId");
        }
    }
}
