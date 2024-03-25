using System;
using System.Text.RegularExpressions;

namespace FirstProject
{
    internal class RegexValidatePINCode
    {
        public static bool ValidatePin(string pin)
        {
            Regex re = new(@"[0-9]");
            MatchCollection mc = re.Matches(pin);
            if (mc.Count != pin.Length)
                return false;
            if(pin.Length != 4 || pin.Length != 6) 
                return false;

            return true;
        }

        public static void Main()
        {
            List<string> lstPins = ["1234"];
            lstPins.ForEach(pin => { Console.WriteLine(ValidatePin(pin)); });
        }
    }
}
