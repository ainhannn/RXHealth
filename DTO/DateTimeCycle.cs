using System;
using System.Collections.Generic;

namespace DTO
{
    public class DateTimeCycle
    {
        public DateTime Current { get; set; }
        public DateTime Next { get; set; }
        public string Cycle { get; set; } 
        public static List<string> CycleMenu { get; private set; } = new List<string>(new string[] {"Daily","Monthly", "Every 2 months", "Every 3 months", "Every 4 months", "Every 6 months"});
    }
}
