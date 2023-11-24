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
