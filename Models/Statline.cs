﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AllPurposeStats.Models
{
    public class Statline
    {
        public int ID { get; set; }
        public Week WeekOf { get; set; }
        public StatCategory Category { get; set; }

    }
}
