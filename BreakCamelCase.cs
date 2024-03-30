namespace FirstProject
{
    internal class BreakCamelCase
    {
        public static string BreakCC(string str)
        {
            if (str.Length == 0)
                return str;

            string tmpStr = string.Empty;
            foreach(char symb in str)
                tmpStr += symb.ToString() == symb.ToString().ToUpper() ? $" {symb}" : symb;

            return tmpStr;
        }
    }
}
