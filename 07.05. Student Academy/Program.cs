/*
 5.	Student Academy
Create a program that keeps the information about students and their grades. 
You will receive n pair of rows. First, you will receive the student's name, after that, you will receive their grade. Check if the student already exists and if not, add him. Keep track of all grades for each student.
When you finish reading the data, keep the students with an average grade higher than or equal to 4.50.
Print the students and their average grade in the following format:
"{name} –> {averageGrade}"
Format the average grade to the 2nd decimal place.

Examples

Input	    Output
5           John -> 5.00
John        Alice -> 4.50
5.5         George -> 5.00
John
4.5
Alice
6
Alice
3
George
5


Input	    Output
5           Rob -> 5.50
Amanda      Christian -> 5.00
3.5         Robert -> 6.00
Amanda
4
Rob
5.5
Christian
5
Robert
6*/

Dictionary<string, List<double>> students = new Dictionary<string, List<double>>();

int n = int.Parse(Console.ReadLine());

for (int i = 0; i < n; i++)
{
    string student = Console.ReadLine();
    double grade = double.Parse(Console.ReadLine());

    if (!students.ContainsKey(student))
    {
        students.Add(student, new List<double>());
    }

    students[student].Add(grade);

}

var excellent = students.Where(st => st.Value.Average() >= 4.50);


foreach (var currentStudent in excellent)
{
    Console.WriteLine($"{currentStudent.Key} -> {currentStudent.Value.Average():f2}");
}