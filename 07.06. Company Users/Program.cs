Dictionary<string, List<string>> companiees = new Dictionary<string, List<string>>();

string input = Console.ReadLine();

while (input != "End")
{
    string[] inputArray = input.Split(" -> ");
    string company = inputArray[0];
    string employeeID = inputArray[1];

    if (!companiees.ContainsKey(company))
    { 
        companiees.Add(company, new List<string>());
    }

    if (!companiees[company].Contains(employeeID))
    {
        companiees[company].Add(employeeID);
    }

    input = Console.ReadLine();

}

foreach (KeyValuePair<string, List<string>> currentCompany in companiees)
{
    Console.WriteLine(currentCompany.Key);

    foreach (string currentEmployeeID in currentCompany.Value)
    {
        Console.WriteLine($"-- {currentEmployeeID}");
    }
}