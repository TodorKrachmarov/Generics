using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class MyList<T> 
    where T : IComparable<T>
{
    private IList<T> data;

    public MyList() : this(new List<T>()) { }

    public MyList(List<T> data)
    {
        this.data = data;
    }

    public IReadOnlyList<T> Data { get { return this.data.ToList().AsReadOnly(); } }

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

    public int CountGreaterThan(T element)
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

    public T Remove(int index)
    {
        var rem = this.data[index];
        this.data.RemoveAt(index);
        return rem;
    }

    public bool Contains(T element)
    {
        if (this.data.Contains(element))
        {
            return true;
        }

        return false;
    }

    public T Max()
    {
        return this.data.Max();
    }

    public T Min()
    {
        return this.data.Min();
    }

    public override string ToString()
    {
        StringBuilder sb = new StringBuilder();
        foreach (var element in this.data)
        {
            sb.AppendLine($"{element}");
        }
        return sb.ToString().Trim();
    }
}
