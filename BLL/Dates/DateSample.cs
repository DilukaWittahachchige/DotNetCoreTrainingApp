
using System;

namespace BLL.Dates
{
    public static class DateSample
    {
        public static void ShowDateType()
        {
            //DateTime object does not hold the timezone information
            var nowInUtc = DateTime.UtcNow;//UTC dates

            //Rails - To - Windows mapping constant in C#
            //string windowsZoneId = TZConvert.RailsToWindows("Central Time (US & Canada)");

            var nowInSingapore = TimeZoneInfo.ConvertTimeFromUtc(nowInUtc,
            TimeZoneInfo.FindSystemTimeZoneById("Singapore Standard Time"));//timezone conversion

            //var nowInTokyo = TimeZoneInfo.ConvertTimeFromUtc(nowInUtc,
            // TimeZoneInfo.FindSystemTimeZoneById(windowsZoneId));//timezone conversion

            Console.WriteLine(nowInUtc);
            Console.WriteLine(nowInSingapore);

            var tomorrow = nowInUtc.AddDays(1);
            Console.WriteLine(tomorrow);
            Console.WriteLine(nowInSingapore > nowInUtc); // Should be true

            // NPM package - https://nodatime.org/
        }
    }
}
