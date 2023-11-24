using System.Text.RegularExpressions;
using static System.Net.Mime.MediaTypeNames;

string inputText = Console.ReadLine();

string pattern = @"\b[A-Z][a-z]+ [A-Z][a-z]+";

Regex regex = new Regex(pattern);
MatchCollection matches = regex.Matches(inputText);

foreach (Match match in matches)
    Console.Write(match + " ");
