/*
 4.	SoftUni Parking
SoftUni just got a new parking lot. It's so fancy, it even has online parking validation. Except the online service doesn't work. It can only receive users' data, but it doesn't know what to do with it. Good thing you're on the dev team and know how to fix it, right?
Write a program, which validates a parking place for an online service. Users can register to park and unregister to leave.
The program receives 2 commands:	
•	"register {username} {licensePlateNumber}":
o	The system only supports one car per user at the moment, so if a user tries to register another license plate, using the same username, the system should print:
"ERROR: already registered with plate number {licensePlateNumber}"
o	If the aforementioned checks passes successfully, the plate can be registered, so the system should print:
 "{username} registered {licensePlateNumber} successfully"
•	"unregister {username}":
o	If the user is not present in the database, the system should print:
"ERROR: user {username} not found"
o	If the aforementioned check passes successfully, the system should print:
"{username} unregistered successfully"
After you execute all of the commands, print all of the currently registered users and their license plates in the format: 
•	"{username} => {licensePlateNumber}"
Input
•	First line: n - number of commands – integer.
•	Next n lines: commands in one of the two possible formats:
o	Register: "register {username} {licensePlateNumber}"
o	Unregister: "unregister {username}"
The input will always be valid and you do not need to check it explicitly.
Examples
Input	                    Output
5
register John CS1234JS      John registered CS1234JS successfully
register George JAVA123S    George registered JAVA123S successfully
register Andy AB4142CD      Andy registered AB4142CD successfully
register Jesica VR1223EE    Jesica registered VR1223EE successfully
unregister Andy             Andy unregistered successfully
                            John => CS1234JS
                            George => JAVA123S
                            Jesica => VR1223EE

Input	                    Output
4                           Jony registered AA4132BB successfully
register Jony AA4132BB      ERROR: already registered with plate number AA4132BB
register Jony AA4132BB      Linda registered AA9999BB successfully
register Linda AA9999BB     Jony unregistered successfully
unregister Jony             Linda => AA9999BB

Input	                    Output
6                           Jacob registered MM1111XX successfully
        Anthony registered AB1111XX successfully
        Jacob unregistered successfully
        Joshua registered DD1111XX successfully
        ERROR: user Lily not found
        Samantha registered AA9999BB successfully
        Joshua => DD1111XX
        Anthony => AB1111XX
        Samantha => AA9999BB*/

Dictionary<string, string> registrars = new Dictionary<string, string>();

int n = int.Parse(Console.ReadLine());

for (int i = 0; i < n; i++)
{
    string[] commandArray = Console.ReadLine().Split().ToArray();

    string command = commandArray[0];
    string employee = commandArray[1];

    if (command == "register")
    {
        string plateNumber = commandArray[2];

        if (!registrars.ContainsKey(employee))
        {
            registrars.Add(employee, plateNumber);
            Console.WriteLine($"{employee} registered {plateNumber} successfully");
        }
        else
        {
            Console.WriteLine($"ERROR: already registered with plate number {registrars[employee]}");
        }
    }
    else if (command == "unregister")
    {
        if (registrars.ContainsKey(employee))
        {
            registrars.Remove(employee);
            Console.WriteLine($"{employee} unregistered successfully");
        }
        else
        {
            Console.WriteLine($"ERROR: user {employee} not found");
        }
    }
}

foreach (KeyValuePair<string, string> pair in registrars)
{
    Console.WriteLine($"{pair.Key} => {pair.Value}");
}