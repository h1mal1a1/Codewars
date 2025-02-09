namespace FirstProject
{
    internal class MeanSquareError
    {
        public static double Solution(int[] firstArray, int[] secondArray)
        {
            return (double)firstArray.Select((t, i) => (t - secondArray[i]) * (t - secondArray[i])).Sum() / firstArray.Length;
        }
    }
}
