string[] words = Console.ReadLine().Split();
string repeatResult = "";

foreach (string word in words)
{
    int repeatTimes = word.Length;
    for (int i = 0; i < repeatTimes; i++)
    {
        repeatResult += word;
    }
}

Console.WriteLine(repeatResult);