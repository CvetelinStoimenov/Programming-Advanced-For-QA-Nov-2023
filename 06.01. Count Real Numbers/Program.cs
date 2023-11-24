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