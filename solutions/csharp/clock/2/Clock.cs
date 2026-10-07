public class Clock
{
    public TimeOnly clock;
    public Clock(int hours, int minutes)
    {

        clock = new TimeOnly();
        clock = clock.AddHours(hours);
        clock = clock.AddMinutes(minutes);
        
    }

    public Clock Add(int minutesToAdd)
    {
        
        clock = clock.AddMinutes(minutesToAdd);

        return this;

    }

    public Clock Subtract(int minutesToSubtract)
    {
        clock = clock.AddMinutes(-minutesToSubtract);

        return this;

    }
    public override string ToString()
    {
        return $"{clock.ToString("HH:mm")}";
    }

    public bool Equals(Clock other)
    {
        return other != null
            && clock.Hour == other.clock.Hour
            && clock.Minute == other.clock.Minute;
    }

    public override bool Equals(object? obj)
    {
        return obj is Clock other && Equals(other);
    }
}
