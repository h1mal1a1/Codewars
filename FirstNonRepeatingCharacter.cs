namespace FirstProject
{
    internal class FirstNonRepeatingCharacter
    {
        public static string FirstNonRepeatingLetter(string s)
        {
            if (s.Length == 0)
                return "";
            for (int i = 0; i < s.Length; i++)
            {
                for (int j = i + 1; j < s.Length; j++)
                {
                    if (string.Equals(s[j].ToString().ToUpperInvariant(), s[i].ToString().ToUpperInvariant()))
                    {
                        s = s.Replace(s[i].ToString(), string.Empty);
                        return FirstNonRepeatingLetter(s);
                    }
                }
            }
            return s[..1];
        }



        public static void Main()
        {
            string s = "sstress";
            s = "abdeeac";
            string nonRepeatLetter = FirstNonRepeatingLetter(s);
            Console.WriteLine(nonRepeatLetter);
        }
    }
}
