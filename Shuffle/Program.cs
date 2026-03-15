using System;
using System.Collections.Generic;

Console.WriteLine("=== 컬렉션 셔플 테스트 ===");

Console.WriteLine("\n[숫자 리스트 셔플]");
int[] numbers = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
Console.WriteLine($"원본: {string.Join(", ", numbers)}");
numbers.Shuffle();
Console.WriteLine($"셔플: {string.Join(", ", numbers)}");

Console.WriteLine("\n[카드 덱 셔플]");
string[] cards = new string[] { "♠A", "♥K", "♦Q", "♣J" };
Console.WriteLine($"원본: {string.Join(", ", cards)}");
cards.Shuffle();
Console.WriteLine($"셔플: {string.Join(", ", cards)}");

Console.WriteLine("\n[학생 순서 무작위 배치]");
string[] students = new string[] { "김철수", "이영희", "박민수", "최지연", "정우진" };
Console.WriteLine($"원본: {string.Join(", ", students)}");
students.Shuffle();
Console.WriteLine($"셔플: {string.Join(", ", students)}");