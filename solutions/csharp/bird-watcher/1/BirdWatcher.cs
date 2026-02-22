class BirdCount
{
    private int[] birdsPerDay;

    public BirdCount(int[] birdsPerDay)
    {
        this.birdsPerDay = birdsPerDay;
    }

    public static int[] LastWeek()
    {
        int[] birdsPerDay = { 0, 2, 5, 3, 7, 8, 4 };
        return birdsPerDay;
 
    }

    public int Today()
    {
        return this.birdsPerDay[6];
    }

    public void IncrementTodaysCount()
    {
        this.birdsPerDay[6] = this.birdsPerDay[6] + 1;
    }

    public bool HasDayWithoutBirds()
    {
        foreach (var day in this.birdsPerDay)
        {
            if (day == 0) return true;
        }
        return false;
    }

    public int CountForFirstDays(int numberOfDays)
    {
        int count = 0;
        for (int i = 0; i < numberOfDays; i++)
        {
            count += this.birdsPerDay[i];
        }
        return count;
    }

    public int BusyDays()
    {
        int busycount = 0;
        int daycount = 0;
        for (int i = 0; i < 7; i++)
        {
        daycount = this.birdsPerDay[i];
            if (daycount >= 5)
            {
                busycount += 1;
            }            
        }
        return busycount;

    }
}
