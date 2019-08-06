using System;

class Test
{
    public static void Main()
    {
        AlphabetStringWebService s = new AlphabetStringWebService();

        Console.WriteLine(s.FirstByAlphabet("Merry Christmas"));
        Console.WriteLine(s.LastByAlphabet("Happy New Year"));
    }
}
