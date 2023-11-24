string key = Console.ReadLine();
string textToCut = Console.ReadLine();

int index = textToCut.IndexOf(key);

while (index != -1)
{
    textToCut = textToCut.Remove(index, key.Length);
    index = textToCut.IndexOf(key);
}
Console.WriteLine(textToCut);