// See https://aka.ms/new-console-template for more information
using LeetCodeApp;
using System.Diagnostics;
//var result = HotTopic.GroupAnagrams(new string[] { "eat", "tea", "tan", "ate", "nat", "bat" });
Stopwatch stopwatch = Stopwatch.StartNew();
stopwatch.Start();
var result = HotTopic.LongestConsecutive(new int[] { 100, 4, 200, 1, 3, 2 });
stopwatch.Stop();
Console.WriteLine($"输出结果为：{result}");
Console.WriteLine($"耗费时间:{stopwatch.ElapsedMilliseconds}");
Console.WriteLine("Hello, World!");
Console.ReadLine();