public struct Coord
{
    public Coord(ushort x, ushort y)
    {
        X = x;
        Y = y;
    }

    public ushort X { get; }
    public ushort Y { get; }

    public double DistanceSquared(Coord other) =>
        Math.Pow(X - other.X, 2) +
        Math.Pow(Y - other.Y, 2);
}

public struct Plot
{
    public Plot(Coord coord1, Coord coord2, Coord coord3, Coord coord4)
    {
        Coord1 = coord1;
        Coord2 = coord2;
        Coord3 = coord3;
        Coord4 = coord4;
    }

    public Coord Coord1 { get; }
    public Coord Coord2 { get; }
    public Coord Coord3 { get; }
    public Coord Coord4 { get; }

    public double LongestSideSquared =>
        Math.Max(
            Math.Max(
                Coord1.DistanceSquared(Coord2),
                Coord2.DistanceSquared(Coord3)),
            Math.Max(
                Coord3.DistanceSquared(Coord4),
                Coord4.DistanceSquared(Coord1)));

}

public class ClaimsHandler
{
    public List<Plot> claims = new List<Plot>();

    public void StakeClaim(Plot plot)
    {
        claims.Add(plot);
    }

    public bool IsClaimStaked(Plot plot)
    {
        return claims.Contains(plot);
    }

    public bool IsLastClaim(Plot plot)
    {
        return claims.Last().Equals(plot);
    }

    public Plot GetClaimWithLongestSide()
    {
        return claims.OrderByDescending(plot => plot.LongestSideSquared).First();
    }
}