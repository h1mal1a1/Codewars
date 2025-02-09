namespace FirstProject
{
    internal class Snail
    {
        internal static int[] SnailSortArray(int[][] array)
        {
            if (Equals(array.Length, 1) && Equals(array[0].Length, 0)) return [];
            var n = array.Length;
            var rang = (Equals(n % 2, 1) ? (n + 1) / 2 : n / 2) - 1;


            int[] res = new int[n * n];
            int countElements = 0;

            for (var circle = 0; circle <= rang; circle++)
            {
                int ca1 = 0, ca2 = 0, ca3 = 0, ca4 = 0;
                int sizeA1 = (n - circle * 2 > 0) ? n - circle * 2 : 0,
                sizeA2A3 = (n - 1 - circle * 2 > 0) ? n - 1 - circle * 2 : 0,
                sizeA4 = (n - 2 - circle * 2 > 0) ? n - 2 - circle * 2 : 0;

                int[] a1 = new int[sizeA1], a2 = new int[sizeA2A3], a3 = new int[sizeA2A3], a4 = new int[sizeA4];

                for (var i = circle; i < n - circle; i++)
                {
                    a1[ca1] = array[circle][i];
                    ca1++;

                    if (Equals(i, circle)) continue;

                    a2[ca2] = array[i][n - 1 - circle];
                    ca2++;
                }

                for (var i = n - 2 - circle; i >= circle; i--)
                {
                    a3[ca3] = array[n - 1 - circle][i];
                    ca3++;

                    if (Equals(i, circle)) continue;

                    a4[ca4]= array[i][circle];
                    ca4++;
                }

                foreach (var v in a1)
                {
                    res[countElements] = v;
                    countElements++;
                }

                foreach (var v in a2)
                {
                    res[countElements] = v;
                    countElements++;
                }

                foreach (var v in a3)
                {
                    res[countElements] = v;
                    countElements++;
                }

                foreach (var v in a4)
                {
                    res[countElements] = v;
                    countElements++;
                }

            }
            return res;
        }
        internal static int[] SnailSort(int[][] array)
        {
            if (Equals(array.Length, 1) && Equals(array[0].Length, 0)) return [];
            var n = array.Length;
            var rang = (Equals(n % 2, 1) ? (n + 1) / 2 : n / 2) - 1;
            
            List<int> l1 = new();
            List<int> l2 = new();
            List<int> l3 = new();
            List<int> l4 = new();
            List<int> res = new();

            for(var circle = 0; circle <= rang; circle++)
            {
                for(var i = circle; i < n - circle; i++)
                {
                    l1.Add(array[circle][i]);
                    if (Equals(i, circle)) continue;
                    l2.Add(array[i][n - 1 - circle]);
                }

                for (var i = n-2-circle; i >= circle; i--)
                {
                    l3.Add(array[n - 1 - circle][i]);
                    if (Equals(i, circle)) continue;
                    l4.Add(array[i][circle]);
                }

                res.AddRange(l1);
                res.AddRange(l2);
                res.AddRange(l3);
                res.AddRange(l4);
                l1.Clear();
                l2.Clear();
                l3.Clear();
                l4.Clear();
            }
            return res.ToArray();

        }
    }
}
