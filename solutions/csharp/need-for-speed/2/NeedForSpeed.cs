using System.Net;
using System.Reflection;
using Microsoft.VisualBasic;


class RemoteControlCar
{
    // TODO: define the constructor for the 'RemoteControlCar' class
    private int speed;
    private int batteryDrain;
    private int meters;
    private int battery;
    public RemoteControlCar(int speed, int batteryDrain)
    {
        this.speed = speed;
        this.batteryDrain = batteryDrain;
        meters = 0;
        battery = 100;
    }

    public bool BatteryDrained()
    {
        return (battery < batteryDrain);
    }

    public int DistanceDriven()
    {
        return this.meters;
    }

    public void Drive()
    {
        if (battery >= batteryDrain)
        {
            meters += speed;
            battery -= batteryDrain;
        }
    }
    public static RemoteControlCar Nitro()
    {
        return new RemoteControlCar(50, 4);
    }
}

class RaceTrack
{
    // TODO: define the constructor for the 'RaceTrack' class
    private int distance;
    public RaceTrack(int distance)
    {
        this.distance = distance;
    }

    public bool TryFinishTrack(RemoteControlCar car)
    {
        int currentdistance = 0;
        while (currentdistance < distance)
        {

            
            if (!car.BatteryDrained())
            {
                car.Drive();
            }
            else
            {
                return false;
            }
            currentdistance = car.DistanceDriven();



        }
        return true;

    }
}
