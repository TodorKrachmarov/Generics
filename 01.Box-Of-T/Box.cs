﻿using System.Collections;
using System.Collections.Generic;
using System.Linq;

public class Box<T>
{
    private IList<T> data;

    public Box()
    {
        this.data = new List<T>();
    }

    public int Count { get { return this.data.Count; } }

    public T Remove()
    {
        var rem = this.data.LastOrDefault();
        this.data.RemoveAt(this.data.Count - 1);
        return rem;
    }

    public void Add(T element)
    {
        this.data.Add(element);
    }
}
