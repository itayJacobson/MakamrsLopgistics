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
    public class LogisticMapping : SubclassMap<Logistic>
    {
        public LogisticMapping()
        {
            DiscriminatorValue("Logistic");
        }
    }
}
