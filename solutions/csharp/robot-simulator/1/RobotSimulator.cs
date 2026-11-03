using Exercism;

public enum Direction
{
    North,
    East,
    South,
    West
}

public class RobotSimulator
{
    public RobotSimulator(Direction direction, int x, int y)
    {
        Direction = direction;
        X = x;
        Y = y;
    }
    private int direction;

    public Direction Direction
    {

        get
        {
            return (Direction)direction;
        }
        set
        {
            
            direction = (int)value;
        }
    }

    public int X { get; set;}


    public int Y { get; set;}


    public void Move(string instructions)
    {
        foreach (var instruction in instructions)
        {
            switch (instruction)
            {
                case 'R':
                    Direction++;
                    if (direction == 4)
                    {
                        Direction = Direction.North;
                    }
                    break;
                case 'L':
                    Direction--;
                    if (direction == -1)
                    {
                        Direction = Direction.West;
                    }
                    break;
                case 'A':
                    switch (direction)
                    {
                        case 0:
                            Y++;
                            break;
                        case 1:
                            X++;
                            break;
                        case 2:
                            Y--;
                            break;
                        case 3:
                            X--;
                            break;
                    }

                    break;
            }
        }
    }
}