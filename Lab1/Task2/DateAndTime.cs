using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1.Task2
{
    abstract class DateAndTime
    {
        protected StringBuilder DataTimeString { get; set; } = new StringBuilder();
        private string formatTime, formatData;
        CultureInfo culture;

        protected DateAndTime(string formatTime, string formatData, CultureInfo culture)
        {
            this.formatData = formatData;
            this.formatTime = formatTime;
            this.culture = culture;

            DataTimeString.Append("Текущая дата: " + DateTime.Now.ToString(this.formatData, this.culture) + "\n");
            DataTimeString.Append("Текущее время: " + DateTime.Now.ToString(this.formatTime, this.culture) + "\n");
        }

        public virtual void PrintDataAndTime() =>
            System.Console.WriteLine(DataTimeString);

        public virtual void UpdateDataAndTime()
        {
            while (true)
            {
                Console.SetCursorPosition(0, 0);
                DataTimeString.Clear();
                DataTimeString.Append("Текущая дата: " + DateTime.Now.ToString(this.formatData, this.culture) + "\n");
                DataTimeString.Append("Текущее время: " + DateTime.Now.ToString(this.formatTime, this.culture) + "\n");
                PrintDataAndTime();
                if (Console.KeyAvailable && Console.ReadKey(true).Key == ConsoleKey.Escape)
                    break;
            }
        }
    }
}
