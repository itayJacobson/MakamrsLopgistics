using FluentNHibernate.Mapping;
using Server.Enums;
using Server.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server.Mapping
{
    public class SoldierMapping : ClassMap<Soldier>
    {
        public SoldierMapping()
        {
            Table("Soldiers");

            Id(x => x.Id).Column("SoldierId");

            DiscriminateSubClassesOnColumn("Job");

            Map(x => x.Place).Column("Place");

            Map(x => x.Name).Column("Name");
        }
    }
}