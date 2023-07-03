using System;
using System.Collections.Generic;
using System.Text;

public abstract class Vehicle
{
    private string brand;
    private string model;
    private double maxMilеage;
    private string licensePlateNumber;
    private int batteryLevel = 100;
    private bool isDamaged = false;

    protected Vehicle(string brand, string model, double maxMilеage, string licensePlateNumber)
    {
        this.Brand = brand;
        this.Model = model;
        this.MaxMilеage = maxMilеage;
        this.LicensePlateNumber = licensePlateNumber;
    }

    public string Brand
    {
        get { return brand; }
        private set
        {
            if (string.IsNullOrWhiteSpace(value))
            {
                throw new ArgumentException("Brand cannot be null or whitespace!");
            }
            brand = value;
        }
    }
    public string Model
    {
        get { return model; }
        private set
        {
            if (string.IsNullOrWhiteSpace(value))
            {
                throw new ArgumentException("Model cannot be null or whitespace!");
            }
            model = value;
        }
    }
    public double MaxMilеage
    {
        get { return maxMilеage; }
        private set
        {
            maxMilеage = value;
        }
    }
    public string LicensePlateNumber
    {
        get { return licensePlateNumber; }
        private set
        {
            if (string.IsNullOrWhiteSpace(value))
            {
                throw new ArgumentException("License plate number is required!");
            }
            licensePlateNumber = value;
        }
    }
    public int BatteryLevel
    {
        get { return batteryLevel; }
        set
        {
            batteryLevel = value;
        }
    }
    public bool IsDamaged
    {
        get { return isDamaged; }
        set
        {
            isDamaged = value;
        }
    }
    public virtual void Drive(double mileage)
    {
        double reduction = (mileage / this.MaxMilеage) * 100;
        this.BatteryLevel -= (int)reduction;
    }
    public void Recharge()
    {
        this.BatteryLevel = 100;
    }
    public void ChangeStatus()
    {
        if (isDamaged)
        {
            isDamaged = false;
        }
        else
        {
            isDamaged = true;
        }
    }
    public override string ToString()
    {
        ; return $"{Brand} {Model} License plate: {LicensePlateNumber} Battery: {BatteryLevel}% Status: OK/damaged";
    }
}
