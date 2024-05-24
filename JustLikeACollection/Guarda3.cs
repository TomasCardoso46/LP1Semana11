using System;
using System.Collections;
using System.Collections.Generic;
namespace JustLikeACollection
{


public class Guarda3<T> : IEnumerable<T>
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

    public void Add(T item)
    {
        for (int i = 0; i < items.Length; i++)
        {
            if (Equals(items[i], default(T)))
            {
                items[i] = item;
                return;
            }
        }
        throw new InvalidOperationException("No space to add new item");
    }

    public IEnumerator<T> GetEnumerator()
    {
        for (int i = 0; i < items.Length; i++)
        {
            yield return items[i];
        }
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }
}

}