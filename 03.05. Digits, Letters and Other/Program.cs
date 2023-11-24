using System.Text;

string text = Console.ReadLine();
StringBuilder digit = new StringBuilder();
StringBuilder leter = new StringBuilder();
StringBuilder other = new StringBuilder();

foreach (char ch in text)
{
    if (char.IsDigit(ch))
    {
        digit.Append(ch);
    }
    else if (char.IsLetter(ch))
    {
        leter.Append(ch);
    }
    else
    { 
    other.Append(ch);
    }

}

Console.WriteLine(digit);
Console.WriteLine(leter);
Console.WriteLine(other);