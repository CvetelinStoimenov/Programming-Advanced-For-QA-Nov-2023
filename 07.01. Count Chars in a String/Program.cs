/*
1.	Count Chars in a String
Create a program that counts all characters in a string, except for space (' '). 
Print all the occurrences in the following format:
"{char} -> {occurrences}"

Examples

Input	        Output
text            t -> 2
                e -> 1
                x -> 1



Input	        Output
text text text  t -> 6
                e -> 3
                x -> 3
 */

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