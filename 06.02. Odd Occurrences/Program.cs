/*
 2.	Odd Occurrences
Write a program that extracts all elements from a given sequence of words that are present in it an odd number of times (case-insensitive):
    •	Words are given on a single line, space-separated.
    •	Print the result elements in lowercase, in their order of appearance.

Examples

Input           	                Output
Java C# PHP PHP JAVA C java         java c# c

Input           	                Output
3 5 5 hi pi HO Hi 5 ho 3 hi pi      5 hi

Input           	                Output
a a A SQL xx a xx a A a XX c        a sql xx c*/

List<string> input = Console.ReadLine()
    .Split(" ")
    .Select(x => x.ToLower())
    .ToList();

var count = new Dictionary<string, int>();

foreach (var word in input)
{

    if (count.ContainsKey(word))
    {
        count[word]++;
    }
    else
    {
        count[word] = 1;
    }
}

List<string> output = count
    .Where(x => x.Value % 2 != 0)
    .Select(x => x.Key)
    .ToList();

Console.WriteLine(String.Join(" ", output));
