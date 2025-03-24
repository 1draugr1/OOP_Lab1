using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1.Task2
{
    class DateAndTimeUS : DateAndTime
    {
        public DateAndTimeUS() : base("T", "D", new CultureInfo("en-US")) { }
    }
}
