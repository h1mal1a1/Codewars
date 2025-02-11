using System.Linq;
using System.Text.RegularExpressions;

namespace FirstProject
{
    internal class SimplePigLatin
    {
        internal static string TaskWithRegEx(string str)
        {
            string ptrnAlWrds = @"[^\s]\w*";
            string ptrnWrdsWithoutSpecSymb = @"[^\s][A-z]\w*";

            var allMtchs = new Regex(ptrnAlWrds, RegexOptions.IgnoreCase).Matches(str);
            var mtchsOnlyWords = new Regex(ptrnWrdsWithoutSpecSymb, RegexOptions.IgnoreCase).Matches(str);

            string[] words = new string[allMtchs.Count];
            int counter = 0;

            foreach(Match mtch in allMtchs) 
            {
                if (!mtchsOnlyWords.Select(m=>m.Value).Contains(mtch.Value))
                    words[counter] = mtch.Value;
                else
                {
                    string ptrnFChar = @"^.";
                    var fL = new Regex(ptrnFChar, RegexOptions.IgnoreCase).Matches(mtch.Value).First();
                    words[counter] = $"{Regex.Replace(mtch.Value, ptrnFChar, string.Empty)}{fL.Value}ay";
                }
                counter++;
            }

            return string.Join(' ',words);
        }
    }
}
