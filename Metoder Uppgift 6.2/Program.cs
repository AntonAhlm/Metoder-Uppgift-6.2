using System;
class Program
{
    static void Main(string[] args)
    {
        Störst(6, 2);
    }

    static void Störst(int tal1, int tal2)
    {
        int StörstTal=0;
        if (tal1>tal2)
            StörstTal = tal1;
        else if (tal1<tal2)
            StörstTal=tal2;
        Console.WriteLine(StörstTal);
        
    }
}
