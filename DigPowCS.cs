namespace FirstProject
{
    internal class DigPowCS
    {
        public static long BinaryPow(long numb, long exp)
        {
            long result = 1;
            while (exp > 0)
            {
                if ((exp & 1) == 1)
                    result *= numb;
                numb *= numb;
                exp >>= 1;
            }
            return result;
        }

        public static long DigPow(int n, int p)
        {
            long newNumb = 0;
            foreach (var numb in n.ToString())
                newNumb += BinaryPow(int.Parse(numb.ToString()), p++);
            return (newNumb % n == 0) ? newNumb / n : -1;
        }
    }
}
