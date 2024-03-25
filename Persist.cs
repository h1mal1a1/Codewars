internal class PersistentBugger
{
    public static int Persistence(long n)
    {
        if (n.ToString().Length == 1)
            return 0;

        int counter = 0;
        while (n.ToString().Length != 1)
        {
            long tmpN = 1;
            foreach (var nn in n.ToString())
                tmpN *= long.Parse(nn.ToString());
            counter++;
            n = tmpN;
        }
        return counter;
    }

    public static int Main(){
       List<long> lstNumbs = [39,4,25,999];
       lstNumbs.ForEach(numb=> Console.WriteLine(Persistence(numb)));
       return 1; 
    }
}