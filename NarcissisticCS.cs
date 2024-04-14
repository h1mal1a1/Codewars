namespace FirstProject
{
    internal class NarcissisticCS
    {
        public static bool Narcissistic(int value)
        {
            double newNum = 0;
            foreach (var numb in value.ToString())
            {
                int tmpNumb = 1;
                for (int i = 0; i < value.ToString().Length; i++)
                    tmpNumb *= int.Parse(numb.ToString());
                newNum += tmpNumb;
            }

            return newNum == value;
        }
    }
}
