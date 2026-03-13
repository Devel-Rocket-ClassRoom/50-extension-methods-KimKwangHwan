using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public static class EnumerableExtension
{
    public static IEnumerable<IEnumerable<T>> Chunk<T>(this IEnumerable<T> items, int size)
    {
        if (items.Count<T>() < 1)
        {
            throw new ArgumentException();
        }
        List<T> list = new List<T>(size);
        int count = 0;
        foreach (var item in items)
        {
            list.Add(item);
            count++;
            if (count == size)
            {
                yield return list.ToList<T>();
                list.Clear();
                count = 0;
            }
        }
        if (list.Count > 0)
        {
            yield return list.ToList<T>();
        }
    }
}