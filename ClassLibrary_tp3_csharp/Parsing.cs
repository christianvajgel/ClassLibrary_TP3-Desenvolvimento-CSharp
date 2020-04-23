using System;
using System.Threading;

namespace ClassLibrary_tp3_csharp
{
    class Parsing
    {
        public static int StringToInt(string n)
        {
            return Int32.Parse(n);
        }

        public static DateTime ConvertToDateTimeObject(string day, string month, string year)
        {
            return new DateTime(StringToInt(year), StringToInt(month), StringToInt(day),
                   new System.Globalization.CultureInfo(Thread.CurrentThread.CurrentCulture.Name, false).Calendar);
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
