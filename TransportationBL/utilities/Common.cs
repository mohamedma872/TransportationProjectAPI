using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TransportationBL.utilities
{
   public class Common
    {
        public static DateTime GetDateOfNow()
        {
            var timeZoneInfo = TimeZoneInfo.FindSystemTimeZoneById("Arab Standard Time");
            var dateTime = TimeZoneInfo.ConvertTime(DateTime.Now, TimeZoneInfo.Local, timeZoneInfo);
            return dateTime;

        }

        public static DateTime GetSpecificDate(DateTime date)
        {
            var timeZoneInfo = TimeZoneInfo.FindSystemTimeZoneById("Arab Standard Time");
            var dateTime = TimeZoneInfo.ConvertTime(date, TimeZoneInfo.Local, timeZoneInfo);
            return dateTime;

        }
    }
}
