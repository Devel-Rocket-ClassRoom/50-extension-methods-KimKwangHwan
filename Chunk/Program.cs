using System;
using System.Collections.Generic;
using System.Linq;

int[] numbers = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
var test1 = numbers.Chunk<int>(3);
foreach (var i in test1)
{
    Console.WriteLine($"[{string.Join(", ", i)}]");
}
Console.WriteLine();

string[] names = new string[] { "김철수", "이영희", "박민수", "최지연", "정우진" };
var test2 = names.Chunk<string>(2);
foreach (var s in test2)
{
    Console.WriteLine($"[{string.Join(", ", s)}]");
}
Console.WriteLine();

int[] pages = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25 };
var test3 = pages.Chunk<int>(5);
foreach (var i in test3)
{
    Console.WriteLine($"[{string.Join(", ", i)}]");
}
Console.WriteLine();