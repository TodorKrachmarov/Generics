using System;
using System.Collections.Generic;
using System.Linq;

public class Sorter
{
    public static MyList<T> Sort<T>(MyList<T> data)
        where T : IComparable<T>
    {
        var temp = data.Data.OrderBy(x => x).ToList();
        return new MyList<T>(temp);
    }
}
