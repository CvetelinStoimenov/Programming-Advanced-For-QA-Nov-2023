using System.Text.RegularExpressions;
using static System.Net.Mime.MediaTypeNames;

string pattern = @"(\d{2})([.\/|-])([A-Z][a-z]+)\2(\d{4})";
Regex regex = new Regex(pattern);

string inputText = Console.ReadLine();

MatchCollection matches = regex.Matches(inputText);

foreach (Match match in matches)
{
    //Console.WriteLine("Day: {0}, Month: {2}, Year: {3}", match.Groups[1], match.Groups[2], match.Groups[3], match.Groups[4]);
    Console.WriteLine($"Day: {match.Groups[1]}, Month: {match.Groups[3]}, Year: {match.Groups[4]}");
}

