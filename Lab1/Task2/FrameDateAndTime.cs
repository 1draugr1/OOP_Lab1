using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1.Task2
{
    class FrameDateAndTime : DateAndTimeDecorator
    {
        private StringBuilder frameBorder = new StringBuilder();
        public FrameDateAndTime(DateAndTime obj, char frameSymbol) : base("T", "D", GetCulture(obj), obj)
        {
            frameBorder.Append(new string(frameSymbol, 40));
        }

        private static CultureInfo GetCulture(DateAndTime obj) =>
            obj is DateAndTimeEU ? new CultureInfo("en-GB") : new CultureInfo("en-US");

        public override void PrintDataAndTime()
        {
            System.Console.WriteLine(frameBorder);
            base.PrintDataAndTime();
            System.Console.WriteLine(frameBorder);
        }

        public override void UpdateDataAndTime()
        {
            System.Console.WriteLine(frameBorder);
            base.UpdateDataAndTime();
            System.Console.WriteLine(frameBorder);
        }

    }
}
