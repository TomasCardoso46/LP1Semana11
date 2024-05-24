// BeforeUtils.cs
using System;
using System.Collections.Generic;
using System.Linq;

public static class BeforeUtils
{
    public static IEnumerable<T> GetTheOnesBefore<T>(IEnumerable<T> items, T item) where T : struct, IComparable<T>
    {
        foreach (var currentItem in items)
        {
            if (currentItem.CompareTo(item) < 0)
            {
                yield return currentItem;
            }
        }
    }
}

