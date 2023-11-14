/*
1.Count Real Numbers
Write a program that:
    •	Read a list of integers
    •	Print them in ascending order, along with their number of occurrences in the format:
{ number} ->  { occurances}

Examples

Input	    Output		Input	    Output		Input	    Output
8 2 2 8 2   2 -> 3      1 5 1 3     1 -> 2      -2 0 0 2    -2 -> 1
            8 -> 2                  3 -> 1                  0 -> 2
                                    5 -> 1                  2 -> 1*/

List<int> input = Console.ReadLine()
    .Split(" ")
    .Select(int.Parse)
    .ToList();

var counts = new SortedDictionary<int, int>();

foreach (var num in input)
{ 
    if (counts.ContainsKey(num))
    { 
        counts[num]++; 
    }
    else 
    { 
        counts[num] = 1;
    }
}

foreach (var num in counts)
{
    Console.WriteLine($"{num.Key} -> {num.Value}");
}