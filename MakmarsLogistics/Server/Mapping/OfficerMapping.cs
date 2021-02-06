using FluentNHibernate.Mapping;
using Server.Enums;
using Server.Models;

namespace Server.Mapping
{
    class OfficerMapping : SubclassMap<Officer>
    {
        public OfficerMapping()
        {
            DiscriminatorValue("Officer");
        }
    }
}
