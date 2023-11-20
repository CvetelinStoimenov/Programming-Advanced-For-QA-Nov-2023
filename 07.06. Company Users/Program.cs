/*
 6.	*Company Users
Create a program that keeps information about companies and their employees. 
You will be receiving a company name and an employee's id, until you receive the "End" command. Add each employee to the given company. Keep in mind that a company cannot have two employees with the same id.
When you finish reading the data, print the company's name and each employee's id in the following format:
{companyName}
-- {id1}
-- {id2}
-- {idN}
Input / Constraints
    •	Until you receive the "End" command, you will be receiving input in the format: "{companyName} -> {employeeId}".
    •	The input always will be valid.

Examples

Input	                    Output
SoftUni -> AA12345          SoftUni
SoftUni -> BB12345          -- AA12345
Microsoft -> CC12345        -- BB12345
HP -> BB12345               Microsoft
End                         -- CC12345
                            HP
                            -- BB12345


Input	                    Output
SoftUni -> AA12345          SoftUni
SoftUni -> CC12344          -- AA12345
Lenovo -> XX23456           -- CC12344
SoftUni -> AA12345          Lenovo
Movement -> DD11111         -- XX23456
End                         Movement
                            -- DD11111*/

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