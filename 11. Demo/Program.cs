int countfStudents = int.Parse(Console.ReadLine());
List<Students> students = new List<Students>();

for (int count = 0; count < countfStudents; count++)
{
    string[] studentData = Console.ReadLine().Split(" ");

    string firstName = studentData[0];
    string lastName = studentData[1];
    double grade = double.Parse(studentData[2]);
    Students currentStudent = new Students(
            firstName,
            lastName,
            grade
            );

    students.Add(currentStudent);
}

students = students.OrderByDescending(s => s.Grade).ToList();

foreach (Students student in students)
{
    Console.WriteLine($"{student.FirstName} {student.LastName}: {student.Grade:f2}");
}