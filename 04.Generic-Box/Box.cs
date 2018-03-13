using System;
using System.Collections.Generic;
using System.Text;

public class Box<T>
    where T : IComparable<T>
{
    private IList<T> data;

    public Box()
    {
        this.data = new List<T>();
    }

    public void Add(T element)
    {
        this.data.Add(element);
    }

    public void Swap(int a, int b)
    {
        T elementA = this.data[a];
        T elementB = this.data[b];
        this.data[a] = elementB;
        this.data[b] = elementA;
    }

    public int Compare(T element)
    {
        int count = 0;
        foreach (var el in this.data)
        {
            if (el.CompareTo(element) > 0)
            {
                count++;
            }
        }

        return count;
    }

    public override string ToString()
    {
        StringBuilder sb = new StringBuilder();
        foreach (var element in this.data)
        {
            sb.AppendLine($"{element.GetType().FullName}: {element}");
        }
        return sb.ToString().Trim();
    }
}
