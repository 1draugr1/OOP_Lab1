using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1.Task2
{
    abstract class DateAndTimeDecorator : DateAndTime
    {
        protected DateAndTime obj;
        protected DateAndTimeDecorator(string formatTime, string formatData, CultureInfo culture, DateAndTime obj)
            : base(formatTime, formatData, culture)
        {
            this.obj = obj;
        }
    }
}
