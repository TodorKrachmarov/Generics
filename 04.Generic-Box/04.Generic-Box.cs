using System;
using System.Linq;

public class Program
{
    static void Main(string[] args)
    {
        Box<double> box = new Box<double>();
        int num = int.Parse(Console.ReadLine());

        for (int i = 0; i < num; i++)
        {
            box.Add(double.Parse(Console.ReadLine()));

        }

        double number = double.Parse(Console.ReadLine());
        Console.WriteLine(box.Compare(number));
    }
}