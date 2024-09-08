using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public abstract class ClubMember
{
    private string firstName;
    private string lastName;
    private int age;
    private double salary;

    protected ClubMember(string firstName, string lastName, int age, double salary)
    {
        this.FirstName = firstName;
        this.LastName = lastName;
        this.Age = age;
        this.Salary = salary;
    }

    public string FirstName
    {
        get { return firstName; }
        private set
        {
            if (string.IsNullOrEmpty(value))
            {
                throw new ArgumentNullException("The name can’t be an empty string!");
            }
            firstName = value;
        }
    }
    public string LastName
    {
        get { return lastName; }
        private set
        {
            if (string.IsNullOrEmpty(value))
            {
                throw new ArgumentNullException("The name can’t be an empty string!");
            }
            lastName = value;
        }
    }
    public int Age
    {
        get { return age; }
        private set
        {
            if (value <=17)
            {
                throw new ArgumentException("Age must be greater than 17 years!");
            }
            age = value;
        }
    }
    public double Salary
    {
        get { return salary; }
        private set
        {
            if (value <= 0)
            {
                throw new ArgumentException("Salary must be a positive number!");
            }
            salary = value;
        }
    }

    public abstract string Info();
}
