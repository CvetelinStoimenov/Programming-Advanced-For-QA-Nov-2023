using System.Collections;
using System.Collections.Generic;

SortedDictionary<string, double> fruits = new() //Keeps its keys always sorted
//var fruits = new Dictionary<string, double>();
{
    // Add elements
    { "strawberry", 2.21 },
    { "cherry", 1.20 },
    { "pear", 3.00 }
};

// Add elements
fruits["banana"] = 2.20; //Add in dictionary key: banana with value 2.20
fruits["apple"] = 1.40;
fruits["kiwi"] = 3.20;

// Add elements
fruits.Add("peach", 3.20);

//Remove elements
fruits.Remove("peach");


foreach (var fruit in fruits)
{
    Console.WriteLine($"{fruit.Key} - {fruit.Value:f2}");
}

Console.WriteLine();
Console.WriteLine("ContainsKey (key): ");

//ContainsKey(key)
if (fruits.ContainsKey("kiwi"))
    Console.WriteLine($"kiwi key exists");

Console.WriteLine();
Console.WriteLine("ContainsValue(value): ");

//ContainsValue(value)
Console.WriteLine(fruits.ContainsValue(3.00)); // True
Console.WriteLine(fruits.ContainsValue(100)); // False
