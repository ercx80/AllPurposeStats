using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AllPurposeStats.Models
{
    public class Player
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public PlayerPosition Position { get; set; }
        public int PlayerID { get; set; }

    }
}
