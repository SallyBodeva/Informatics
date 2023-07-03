using EDriveRent.Models.Contracts;
using System;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;
using System.Security.Principal;
using System.Text;

public class User:IUser
{
    private string firstName;
    private string lastName;
    private string drivingLicenseNumber;
    private double rating = 0;
    private bool isBlocked = false;

    public User(string firstName, string lastName, string drivingLicenseNumber)
    {
        this.FirstName = firstName;
        this.LastName = lastName;
        this.DrivingLicenseNumber = drivingLicenseNumber;
    }

    public string FirstName
    {
        get { return firstName; }
        private set
        {
            if (string.IsNullOrWhiteSpace(value))
            {
                throw new ArgumentException("FirstName cannot be null or whitespace!");
            }
            firstName = value;
        }
    }
    public string LastName
    {
        get { return lastName; }
        private set
        {
            if (string.IsNullOrWhiteSpace(value))
            {
                throw new ArgumentException("LastName cannot be null or whitespace!");
            }
            lastName = value;
        }
    }
    public string DrivingLicenseNumber
    {
        get { return drivingLicenseNumber; }
        private set
        {
            if (string.IsNullOrWhiteSpace(value))
            {
                throw new ArgumentException("Driving license number is required!");
            }
            drivingLicenseNumber = value;
        }
    }
    public double Rating
    {
        get { return rating; }
        private set
        {
            rating = value;
        }
    }
    public bool IsBlocked
    {
        get { return isBlocked; }
        private set
        {
            isBlocked = value;
        }
    }
    public void IncreaseRating()
    {
        this.Rating += 0.5;
        if (this.Rating>10.00)
        {
            this.Rating = 0;
        }
    }
    public void DecreaseRating()
    {
        this.Rating -= 2.0;
        if (this.Rating < 0.00)
        {
            this.Rating = 0;
           this.isBlocked = true;
        }
    }
    public override string ToString()
    {
        return $"{FirstName} {LastName} Driving license: {DrivingLicenseNumber} Rating: {Rating}";
    }
}

