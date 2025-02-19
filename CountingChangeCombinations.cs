namespace FirstProject
{
    internal class CountingChangeCombinations
    {
        public static int CountCombinations(int money, int[] coins)
        {
            switch(coins.Length)
            {
                case > 0 when money == 0:
                    return 1;
                case 0 when money > 0:
                    return 0;
                case 1:
                    return money % coins[0] != 0 ? 0 : 1;
            }
            var countCombination = 0;
            for(var i = 0; i <= money / coins[0]; i++)
            {
                var res = CountCombinations(money - i * coins[0], coins.Skip(1).ToArray());
                countCombination += res;
            }
            return countCombination;
        }
    }
}
