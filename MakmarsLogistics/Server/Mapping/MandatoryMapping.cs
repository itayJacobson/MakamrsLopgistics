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
    class MandatoryMapping : SubclassMap<Mandatory>
    {
        public MandatoryMapping()
        {
            //DiscriminatorValue(SoldierJob.Mandatory.ToString());
            DiscriminatorValue("Mandatory");
        }
    }
}
