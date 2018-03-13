using System;

public class Program
{
    static void Main(string[] args)
    {
        string[] input1 = Console.ReadLine().Split();
        IThreeuple<string, string, string> tuple1 = new Threeuple<string, string, string>(string.Concat(input1[0], " ", input1[1]), input1[2], input1[3]);

        string[] input2 = Console.ReadLine().Split();
        bool isDrunk = false;
        if (input2[2] == "drunk")
        {
            isDrunk = true;
        }
        IThreeuple<string, int, bool> tuple2 =
            new Threeuple<string, int, bool>(input2[0], int.Parse(input2[1]), isDrunk);

        string[] input3 = Console.ReadLine().Split();
        IThreeuple<string, double, string> tuple3 = new Threeuple<string, double, string>(input3[0], double.Parse(input3[1]), input3[2]);

        Console.WriteLine(tuple1);
        Console.WriteLine(tuple2);
        Console.WriteLine(tuple3);
    }
}
