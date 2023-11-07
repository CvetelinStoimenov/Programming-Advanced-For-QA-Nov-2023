﻿/*
 1.	Reverse Strings
Write a program that:
    •	Reads a series of strings from the console, until you receive an "end" command
    •	Reverse given strings
    •	Print each pair (old text and reversed text) on a separate line in the format:
     "{word} = {reversed word}"

Examples

Input	    Output
helLo       helLo = oLleh
Softuni     Softuni = inutfoS
bottle      bottle = elttob
end

Input	    Output
Dog	        Dog = goD
caT	        caT = Tac
chAir	    chAir = riAhc
end*/

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