namespace FirstProject
{
    internal class IsPangram
    {
        private static bool IP(string str)
        {
            string alph = string.Empty;

            foreach(var symb in str)
            {
                if (!char.IsLetter(symb))
                    continue;
                if (alph.Contains(symb.ToString().ToLower()))
                    continue;
                alph += symb.ToString().ToLower();
            }
            return (alph.Length == 26) ? true : false;
        }
    }
}
