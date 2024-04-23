namespace FirstProject
{
    internal class AddingBigNumbers
    {
        public static string Add(string a, string b)
        {
            bool additionalUnit = false;
            string result = string.Empty;

            while (a.Length != b.Length)
            {
                if (a.Length > b.Length)
                    b = b.Insert(0, "0");
                else if (b.Length > a.Length)
                    a = a.Insert(0, "0");
            }

            for (int i = a.Length - 1; i >= 0; i--)
            {
                int numb = int.Parse(a[i].ToString()) + int.Parse(b[i].ToString());
                if (additionalUnit)
                    numb += 1;

                if (numb >= 10)
                {
                    numb %= 10;
                    additionalUnit = true;
                }
                else
                    additionalUnit = false;

                result = result.Insert(0, numb.ToString());
            }
            if (additionalUnit)
                result = result.Insert(0, "1");

            return result;
        }
    }
}
