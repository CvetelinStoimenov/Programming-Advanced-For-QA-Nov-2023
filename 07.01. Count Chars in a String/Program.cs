var characters = new Dictionary<char, int>();

var input = Console.ReadLine();

foreach (char ch in input)
{
    if (ch == ' ')
    {
        continue;
    }
    if (characters.ContainsKey(ch))
    {
        characters[ch]++;
    }
    else
    {
        characters.Add(ch, 1);
    }
}

foreach (var pair in characters)
{
    Console.WriteLine($"{pair.Key} -> {pair.Value}");
}