public class Player
{
    public int RollDie()
    {
        Random rand = new Random();
        return rand.Next(1,19);
    }

    public double GenerateSpellStrength()
    {
        Random rand = new Random();
        return rand.NextDouble()*100;
    }
}
