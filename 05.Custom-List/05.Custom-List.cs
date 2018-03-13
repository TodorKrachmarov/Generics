using System;

public class Program
{
    static void Main(string[] args)
    {
        MyList<string> myList = new MyList<string>();
        string input;

        while ((input = Console.ReadLine()) != "END")
        {
            string[] tolks = input.Split();

            switch (tolks[0])
            {
                //Add < element > -Adds the given element to the end of the list
                case "Add":
                    myList.Add(tolks[1]);
                    break;
                //Remove < index > -Removes the element at the given index
                case "Remove":
                    myList.Remove(int.Parse(tolks[1]));
                    //Console.WriteLine(myList.Remove(int.Parse(tolks[1])));
                    break;
                //Contains < element > -Prints if the list contains the given element(True or False)
                case "Contains":
                    Console.WriteLine(myList.Contains(tolks[1]));
                    break;
                //Swap < index > < index > -Swaps the elements at the given indexes
                case "Swap":
                    myList.Swap(int.Parse(tolks[1]), int.Parse(tolks[2]));
                    break;
                //Greater < element > -Counts the elements that are greater than the given element and prints their count
                case "Greater":
                    Console.WriteLine(myList.CountGreaterThan(tolks[1]));
                    break;
                //Max - Prints the maximum element in the list
                case "Max":
                    Console.WriteLine(myList.Max());
                    break;
                //Min - Prints the minimum element in the list
                case "Min":
                    Console.WriteLine(myList.Min());
                    break;
                //Sort - Sort the elements in the list in ascending order.
                case "Sort":
                    myList = Sorter.Sort(myList);
                    break;
                //Print - Prints all elements in the list, each on a separate line
                case "Print":
                    Console.WriteLine(myList);
                    break;
            }
    }
    }
}
