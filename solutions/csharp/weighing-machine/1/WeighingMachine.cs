class WeighingMachine
{

    // TODO: define the 'Precision' property
    public WeighingMachine(int precision)
    {
        Precision = precision;
    }
    public int Precision {get; set;}

    // TODO: define the 'Weight' property
    private double StoredWeight;
    public double Weight
    {
        get
        {
            return StoredWeight;
        }

        set
        {
            if (value < 0)
                throw new ArgumentOutOfRangeException(nameof(value), "Value cannot be negative");

            
            StoredWeight = Math.Round(value, Precision, MidpointRounding.AwayFromZero);
        }
    }

    // TODO: define the 'TareAdjustment' property
    public double TareAdjustment {get; set;} = 5.0;



    // TODO: define the 'DisplayWeight' property
    public string DisplayWeight
    {
        get
        {
            return $"{(Weight - TareAdjustment).ToString($"F{Precision}")} kg";
        }
    }
}
