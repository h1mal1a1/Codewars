public static class Kata
{
    // return masked string
    public static string Maskify(string cc)
    {
        if (cc.Length < 4)
            return cc;

        string tmpStr = cc[^4..];
        while (tmpStr.Length != cc.Length)
            tmpStr = tmpStr.Insert(0, "#");
        return tmpStr;
    }
}
