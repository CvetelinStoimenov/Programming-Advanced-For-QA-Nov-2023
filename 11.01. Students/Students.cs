using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11._01._Students
{
    public class Students
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public double Grade  { get; set; }

        public Students(string firstName, string lastName, double grade)
        {
            FirstName = firstName;
            LastName = lastName;
            Grade = grade;
        }
    }
}
