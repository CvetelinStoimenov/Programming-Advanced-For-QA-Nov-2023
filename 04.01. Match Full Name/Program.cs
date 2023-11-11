/*
 1.	Match Full Name
Write a program that:
    •	Reads a text from the console
    •	Match full names from the given text
    •	A valid full name has the following characteristics:
        o	It consists of two words
        o	Each word starts with a capital letter
        o	After the first letter, it only contains lowercase letters afterward
        o	Each of the two words should be at least two letters long
        o	The two words are separated by a single space
    •	Print full names on the console, separated by single space

Examples

Input	                                                Output
Bethany Taylor, Oliver miller, sophia Johnson,          Bethany Taylor John Smith
SARah Wilson, John Smith, Sam	        Smith 



Input	                                                Output
Elvis Presley a a C C-Muhammad Ali EE                   Elvis Presley Muhammad Ali Michael Jackson
PeterpeterJR-a a xi ban D D bb b b-B B-c c 
EE-Michael Jackson DD peter smith B B PETER 
BROWN IVAN DAVIES-*/


using System.Text.RegularExpressions;
using static System.Net.Mime.MediaTypeNames;

string inputText = Console.ReadLine();

string pattern = @"\b[A-Z][a-z]+ [A-Z][a-z]+";

Regex regex = new Regex(pattern);
MatchCollection matches = regex.Matches(inputText);

foreach (Match match in matches)
    Console.Write(match + " ");

