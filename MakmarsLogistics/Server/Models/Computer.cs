using Server.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server.Models
{
    public class Computer
    {
        public virtual int Id { get; set; }
        public virtual ComputerType Type { get; set; }
        public virtual Place Place { get; set; }
        public virtual Soldier Soldier { get; set; }
    }
}
