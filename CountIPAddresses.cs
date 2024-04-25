namespace FirstProject
{
    internal class CountIPAddresses
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
        public static long IpsBetween(string start, string end)
        {
            long result = 0;
            for (int i = 0; i < 4; i++)
                result += (int.Parse(end.Split('.')[i]) - int.Parse(start.Split('.')[i])) * BinaryPow(256, 3 - i);
            return result;
        }
    }
}
