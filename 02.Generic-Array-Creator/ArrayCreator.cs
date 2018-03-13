public static class ArrayCreator
{
    public static T[] Create<T>(int lenght, T item)
    {
        T[] data = new T[lenght];
        for (int i = 0; i < lenght; i++)
        {
            data[1] = item;
        }
        return data;
    }
}
