namespace FirstProject
{
    internal class Diamond
    {
        public static string? PrintDiamonds(int n)
        {
            if ((n < 0) || n % 2 == 0)
                return null;

            string str = string.Empty;
            for (int i = 1, j = (n / 2); j >= 0; i += 2, j--)
                str += $"{new string(' ', j)}{new string('*', i)}\n";

            for (int i = n - 2, j = 1; j <= (n / 2); i -= 2, j++)
                str += $"{new string(' ', j)}{new string('*', i)}\n";

            return str;
        }
    }
}