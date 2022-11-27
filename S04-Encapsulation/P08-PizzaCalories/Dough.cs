using System;
using System.Collections.Generic;
using System.Text;


public class Dough
{
    private readonly double caloriesPerGram;
    private double WhiteCalories = 1.5;
    private double WholegrainCalories = 1.0;

    private double CrispyCalories = 0.9;
    private double ChewyCalories = 1.1;
    private double HomeMadeCalories = 1.0;

    private string flourType;
    private string bakingTechnique;
    private double weight;

    public Dough(string flourType, string bakingTechnique, double weight)
    {
        this.FlourType = flourType;
        this.BakingTechnique = bakingTechnique;
        this.Weight = weight;
    }

    public string FlourType
    {
        get { return flourType; }
        private set
        {
            if (value.ToLower() != "white" && value.ToLower() != "wholegrain")
            {
                throw new ArgumentException("Invalid type of dough.");
            }
            flourType = value;
        }
    }
    public string BakingTechnique
    {
        get { return bakingTechnique; }
        private set
        {
            if (value.ToLower() != "crispy" && value.ToLower() != "chewy" && value.ToLower() != "homemade")
            {
                throw new ArgumentException("Invalid type of dough.");
            }
            bakingTechnique = value;
        }
    }
    public double Weight
    {
        get { return weight; }
        private set
        {
            if (value<1 || value>200)
            {
                throw new ArgumentException("Dough weight should be in the range [1..200].");
            }
            weight = value;
        }
    }
    public double CaloriesPerGram
    {
        get
        {
            double type = 0;
            if (this.FlourType.ToLower() == "white")
            {
                type = WhiteCalories;
            }
            else if (this.FlourType.ToLower() == "wholegrain")
            {
                type = WholegrainCalories;
            }
            double technique = 0;
            switch (this.BakingTechnique.ToLower())
            {
                case "crispy":
                    technique = CrispyCalories;
                    break;
                case "chewy":
                    technique = ChewyCalories;
                    break;
                case "homemade":
                    technique = HomeMadeCalories;
                    break;
            }
            return 2 * this.Weight * type * technique;
        }
    }
}

