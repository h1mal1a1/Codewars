namespace FirstProject
{
    public class ASum
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
        public static long FindNb(long m)
        {
            long n = 1, newValue = 0;
            for (; newValue < m; n++)
                newValue += BinaryPow(n, 3);
            return (newValue == m) ? n - 1 : -1;
        }
    }
}
