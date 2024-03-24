internal class SumOfDigits
{
    public static int DigitalRoot(long n)
    {
        string strNumb = n.ToString();
        long tmpNumb = 0;
        foreach(var symb in strNumb)
            tmpNumb += long.Parse(symb.ToString());
        return (tmpNumb.ToString().Length > 1) ? DigitalRoot(tmpNumb): (int)tmpNumb;
    }
}