using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AllPurposeStats.Models
{
    public class Statline
    {
        public int WeekOf { get; set; }
        public double Yards { get; set; }
        public double Touchdowns { get; set; }
        public double YearToDate { get; set; }
    }
}
