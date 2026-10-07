public class Clock
{
    public DateTime clock;
    public Clock(int hours, int minutes)
    {
        clock = new DateTime(0, 0, 0, hours, minutes, 0);
    }

    public DateTime Add(int minutesToAdd)
    {
        clock.AddMinutes(minutesToAdd);
        return clock;
    
    }

    public DateTime Subtract(int minutesToSubtract)
    {
        clock.Subtract(new DateTime(0, 0, 0, 0, minutesToSubtract, 0));
        return clock;
    }

}
