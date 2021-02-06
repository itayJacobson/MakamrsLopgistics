using Server.Enums;

namespace Server.Models
{
    public abstract class Soldier
    {
        public virtual int Id { get; set; }
        public virtual Place Place { get; set; }
        public virtual string Name { get; set; }
    }
}