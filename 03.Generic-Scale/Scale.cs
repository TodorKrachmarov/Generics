using System;

public class Scale<T>
    where T : IComparable<T>
{
    public Scale(T left, T right)
    {
        this.LeftElement = left;
        this.RightElement = right;
    }

    public T LeftElement { get; private set; }

    public T RightElement { get; private set; }

    public T GetHavier()
    {
        if (this.LeftElement.CompareTo(this.RightElement) > 0)
        {
            return this.LeftElement;
        }
        if (this.RightElement.CompareTo(this.LeftElement) > 0)
        {
            return this.RightElement;
        }

        return default(T);
    }
}
