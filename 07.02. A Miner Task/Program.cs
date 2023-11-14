/*
 2.	A Miner Task
You will be given a sequence of strings, each on a new line. Every odd line on the console is representing a resource 
(e.g. Gold, Silver, Copper and so on) and every even - quantity. Your task is to collect the resources and print them each on a new line.
Print the resources and their quantities in the following format:
"{resource} –> {quantity}"
The quantities will be in the range [1… 2 000000000].

Examples

Input	    Output		
Gold        Gold -> 155
155         Silver -> 10
Silver      Copper -> 17
10
Copper
17
stop

Input	    Output
gold        gold -> 170
155         silver -> 10
silver      copper -> 17
10
copper
17
gold
15
stop*/

var resources = new Dictionary<string, int>();
string resource = Console.ReadLine();

while (resource != "stop")
{
    int quantity = int.Parse(Console.ReadLine());

    if (resources.ContainsKey(resource))
    {
        resources[resource] += quantity;
    }
    else
    {
        resources.Add(resource, quantity);
    }

    resource = Console.ReadLine();
}

foreach (KeyValuePair<string, int> pair in resources)
{
    Console.WriteLine($"{pair.Key} -> {pair.Value}");
}