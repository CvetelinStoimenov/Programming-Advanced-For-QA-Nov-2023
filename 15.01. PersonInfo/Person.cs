using System;

namespace PersonInfo;

public class Person
{
    private string _firstName;
    private string _lastName;
    private int _age;

    public Person(string firstName, string lastName, int age) 
    {
        this._firstName = firstName;
        this._lastName = lastName;
        this._age = age;
    }

    private const int NAME_MIN_LENGHT = 3;

    public string FirstName
    {
        get { return this._firstName; } 
        set 
        {
            if (value.Length < NAME_MIN_LENGHT)
            {
                throw new ArgumentException($"First name cannot contain fewer than {NAME_MIN_LENGHT} symbols!");
            }

            this._firstName = value;
        } 
    }

    public string LastName 
    {
        get { return this._lastName; } 
        set 
        {
            if (value.Length < NAME_MIN_LENGHT)
            {
                throw new ArgumentException($"First name cannot contain fewer than {NAME_MIN_LENGHT} symbols!");
            }

            this._lastName = value;
        }
    }

    public int Age 
    {
        get { return this._age; } 
        set 
        {
            if (value <= 0)
            {
                throw new ArgumentException("Age cannot be zero or a negative integer!");
            }

            this._age = value;
        }
    }

    public override string ToString()
    {
        return $"{this.FirstName} {this.LastName} is {this.Age} years old.";
    }
}
