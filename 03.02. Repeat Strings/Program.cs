﻿/*Problem: Repeat Strings
Read an array from strings
Repeat each word n times, where n is the length of the word

hi abc add  ->  hihiabcabcabcaddaddadd
work  ->  workworkworkwork
ball  ->  ballballballball*/


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