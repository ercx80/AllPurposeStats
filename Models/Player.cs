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
        public Enum Position { get; set; }
    }
}
