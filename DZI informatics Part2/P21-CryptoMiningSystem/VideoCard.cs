using System;
public class VideoCard:Component
{
    private int ram;
    private double minedMoneyPerHour;

    public int Ram
    {
        get { return ram; }
        set
        {
            if (value < 0 || value > 32)
            {
                throw new ArgumentException($"{this.VideoCardType} ram cannot less or equal to 0 and more than 32!");
            }
            ram = value;
        }
    }
    public double MinedMoneyPerHour
    {
        get
        {
            //{RAM} * {Generation} / 10
            return this.Ram * (this.Generation/10); 
        }
       
    }
    public string VideoCardType { get; set; }

    public override int LifeWorkingHours
    {
        get
        {
            return this.Ram * (this.Generation * 10);
        }
    }
  
}