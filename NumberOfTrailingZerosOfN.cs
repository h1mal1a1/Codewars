namespace FirstProject
{
    internal class NumberOfTrailingZerosOfN
    {
        public static double TrailingZeros(int n)
        {
            int res = 0;
            for(int i = 1; i <= (int)Math.Log(n, 5); i++)
                res += n / (int)Math.Pow(5, i);

            return res;
        }
    }
}
