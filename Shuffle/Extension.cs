using System;
using System.Collections.Generic;
using System.Text;

public static class  ListExtension
{
    public static void Shuffle<T>(this IList<T> list)
    {
        if (list == null) 
            throw new ArgumentNullException();
        Random random = new Random();
        for (int i = list.Count - 1; i > 0; i--)
        {
            int j = random.Next(0, i + 1);
            T temp = list[i];
            list[i] = list[j];
            list[j] = temp;
        }
    }
}