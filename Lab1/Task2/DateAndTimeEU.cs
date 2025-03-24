using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1.Task2
{
    class DateAndTimeEU : DateAndTime
    {
        public DateAndTimeEU() : base("T", "D", new CultureInfo("en-GB")) { }
    }
}
