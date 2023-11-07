/*5.	Digits, Letters and Others
Write a program that:
    •	Read a single string from the console
    •	Print all the digits on the first line
    •	Print all the letters on the second line
    •	Print all the other characters on the third line

Note: There will always be at least one digit, one letter and one other character.

Examples


Input	                Output
Agd#53Dfg^&4F53         53453
                        AgdDfgF
                        #^&


Input	                Output
So%f94t34U*n&i></37     943437
                        SoftUni
                        %*&></
*/

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