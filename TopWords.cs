namespace FirstProject
{
    internal class TopWords
    {
        public static List<string> Top3(string s)
        {
            var delimeters = s.ToCharArray().Where(c=> !char.IsLetter(c) && !Equals(c,'\'')).Distinct().ToArray();
            var words = s.Split(delimeters).Select(w => w.Trim().ToLowerInvariant()).Where(w => w != string.Empty).ToList();
            Dictionary<string, int> pairs = new();
            var uniwWords = words.Distinct().Where(w => !Enumerable.SequenceEqual(w.ToCharArray().Distinct(), "'"));
            foreach(var word in uniwWords)
            {
                var countWord = words.Count(x => Equals(x, word));
                if(pairs.Count< 3)
                {
                    pairs.Add(word, countWord);
                    continue;
                }

                if (pairs.Values.Min() < countWord) pairs.Add(word, countWord);
                if (pairs.Keys.Count > 3) pairs.Remove(pairs.FirstOrDefault(x => Equals(x.Value, pairs.Values.Min())).Key);
            }
            return pairs.OrderByDescending(v => v.Value).ToDictionary().Keys.ToList();
        }
    }
}
