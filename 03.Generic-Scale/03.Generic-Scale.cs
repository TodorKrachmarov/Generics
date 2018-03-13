using System;

public class Program
{
    static void Main(string[] args)
    {
        Scale<int> scale = new Scale<int>(33, 11);
        Console.WriteLine(scale.GetHavier());
    }
}
