using System.Linq;
using System.Text.RegularExpressions;

namespace CardAttendenceTracker
{
    public static class Extensions
    {
        public static string FilterSerial(this string input)
        {
            string output = null;
            Match m = Regex.Match(input, @"^\%?\D?(\d+)\^?");
            if (m.Groups[0].Success)
            {
                output = m.Groups[1].Value;
            }
            return output;
        }
    }
}
