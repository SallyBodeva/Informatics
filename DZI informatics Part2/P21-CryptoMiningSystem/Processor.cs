using System;
public class Processor : Component
{
    private readonly string processorType;

    public int MineMultiplier { get; set; }
    public override int LifeWorkingHours
    {
        get
        {
            return this.Generation * 100;
        }
    }
    public override int Generation
    {
        get { return base.Generation; }
        set
        {
            if (value > 9)
            {
                if (this.ProcessorType == "LowPerformanceProcessor")
                {
                    throw new ArgumentException($"LowPerformanceProcessor  generation cannot be more than 9!");
                }
                else if (this.ProcessorType == "LowPerformanceProcessor")
                {
                    throw new ArgumentException($"HighPerformanceProcessor   generation cannot be more than 9!");
                }

            }
            base.Generation = value;
        }
    }
    public string ProcessorType
    {
        get
        {
            if (this.MineMultiplier==2)
            {
                return "LowPerformanceProcessor";
            }
            else
            {
                return "HighPerformanceProcessor";
            }

        }
    }
}