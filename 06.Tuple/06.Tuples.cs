﻿using System;

public class Program
{
    static void Main()
    {
        string[] input1 = Console.ReadLine().Split();
        Tuple<string, string> tuple1 = new Tuple<string, string>(string.Concat(input1[0], " ", input1[1]), input1[2]);

        string[] input2 = Console.ReadLine().Split();
        Tuple<string, int> tuple2 = new Tuple<string, int>(input2[0], int.Parse(input2[1]));

        string[] input3 = Console.ReadLine().Split();
        Tuple<int, double> tuple3 = new Tuple<int, double>(int.Parse(input3[0]), double.Parse(input3[1]));

        Console.WriteLine(tuple1);
        Console.WriteLine(tuple2);
        Console.WriteLine(tuple3);
    }
}
