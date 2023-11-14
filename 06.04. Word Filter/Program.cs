/*
4.	Word Filter
Write a program that:
    •	Read an array of strings
    •	Take only words, whose length is an even number
    •	Print each word on a new line

Examples

Input	                    Output
kiwi orange banana apple    kiwi
                            orange
                            banana


Input	                    Output
pizza cake pasta chips      cake*/

List<string> input = Console.ReadLine()
    .Split(" ")
    .ToList();

List<string> output = input
    .Where(x => x.Length % 2 == 0)
    .ToList();

foreach (var item in output)
{
    Console.WriteLine(item);
}