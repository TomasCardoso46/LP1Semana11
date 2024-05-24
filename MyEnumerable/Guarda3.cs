using System;
namespace MyEnumerable
{
    

public class Guarda3<T>
{
    private T[] items = new T[3];

    public Guarda3()
    {
        for (int i = 0; i < items.Length; i++)
        {
            items[i] = default(T);
        }
    }

    public T GetItem(int i)
    {
        if (i < 0 || i > 2)
        {
            throw new IndexOutOfRangeException();
        }
        return items[i];
    }

    public void SetItem(int i, T item)
    {
        if (i < 0 || i > 2)
        {
            throw new IndexOutOfRangeException();
        }
        items[i] = item;
    }
}

}