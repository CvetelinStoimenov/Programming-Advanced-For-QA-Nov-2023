string words = Console.ReadLine();


while (words != "end")
{
    List<char> output = new List<char>();
    foreach (char word in words)
    {
        output.Add(word);
    }
    output.Reverse();
    Console.WriteLine(words + " = " + string.Join("", output));
    words = Console.ReadLine();
}
