/*
3.	Match Dates
Write a program that:
    •	Reads a text from the console
    •	Create a regular expression to match a valid dates
    •	Every valid date has the following characteristics:
        o	Format: "dd{separator}MMM{separator}yyyy"
        o	Always starts with two digits, followed by a separator
        o	After that, it has one uppercase and two lowercase letters (e.g. Jan, Mar)
        o	After that, it has a separator and exactly 4 digits (for the year)
        o	The separator could be either of three things: a period ('.'), a hyphen ('-') or a forward-slash ('/')
        o	The separator needs to be the same for the whole date (e.g. 13.03.2016 is valid, 13.03/2016 is NOT). Use a group backreference to 
        check for this
    •	Use named capturing groups in your regular expression.
    •	Print all valid dates on the console, separated by a comma and a space ", "

Examples

Input	                                            Output
13/Jul/1928, 10-Nov-1934, ,                         Day: 13, Month: Jul, Year: 1928
01/Jan-1951,f 25.Dec.1937 23/09/1973,               Day: 10, Month: Nov, Year: 1934
1/Feb/2016                                          Day: 25, Month: Dec, Year: 1937


Input	                                            Output
03-Mar-1878, 25/Apr/1915,                           Day: 03, Month: Mar, Year: 1878
31-May-1916, 22/Jun-1941,                           Day: 25, Month: Apr, Year: 1915
25.Dec.1937, 23/09/1973                             Day: 31, Month: May, Year: 1916
                                                    Day: 25, Month: Dec, Year: 1937*/

using System.Text.RegularExpressions;
using static System.Net.Mime.MediaTypeNames;

string inputText = Console.ReadLine();

string pattern = @"\b[A-Z][a-z]+ [A-Z][a-z]+";

Regex regex = new Regex(pattern);
MatchCollection matches = regex.Matches(inputText);

foreach (Match match in matches)
    Console.Write(match + " ");
