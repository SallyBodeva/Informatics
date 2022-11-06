using System;
using System.IO;

public class Program
{
    static void Main(string[] args)
    {
        string password = Console.ReadLine();
        if (isValidRule1(password) == null)
        {
            if (isValidRule2(password) == null)
            {
                if (isValidRule3(password) == null)
                {
                    Console.WriteLine("Password is valid");
                }
            }
        }
        if (isValidRule1(password) == null) {} else{Console.WriteLine(isValidRule1(password));}
        if (isValidRule2(password) == null) {} else { Console.WriteLine(isValidRule2(password)); }
        if (isValidRule3(password) == null) {} else { Console.WriteLine(isValidRule3(password)); }
    }
    public static string isValidRule1(string password)
    {
        if (password.Length < 6 || password.Length > 10)
        {
            return "Password must be between 6 and 10 characters";
        }
        else
        {
            return null;
        }
    }
    public static string isValidRule2(string password)
    {
        foreach (var symbol in password )
        {
            if (!char.IsDigit(symbol))
            {
                if (!char.IsLetter(symbol))
                {
                    return "Password must consist only of letters and digits";
                }
            }
        }
        return null;
    }
    public static string isValidRule3(string password)
    {
        int digitCounter = 0;
        foreach (var symbol in password)
        {
            if (char.IsDigit(symbol))
            {
                digitCounter += 1;
            }
        }
        if (digitCounter<2)
        {
            return "Password must have at least 2 digits";
        }
        return null;
    }
}

