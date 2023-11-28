
    internal class Students
    {
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public double Grade { get; set; }

    public Students(string firstName, string lastName, double grade)
    {
        FirstName = firstName;
        LastName = lastName;
        Grade = grade;
    }
}
