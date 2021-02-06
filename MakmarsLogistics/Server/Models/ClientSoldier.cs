using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server.Models
{
    public abstract class ClientSoldier : Soldier
    {
        public virtual IList<Computer> Computers { get; set; }
    }
}
