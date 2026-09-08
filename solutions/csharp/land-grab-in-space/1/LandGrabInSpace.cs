public struct Coord
{
    public Coord(ushort x, ushort y)
    {
        X = x;
        Y = y;
    }

    public ushort X { get; }
    public ushort Y { get; }
}

public struct Plot
{
    public Plot(Coord coord1, Coord coord2, Coord coord3, Coord coord4)
    {
        Coords[0] = coord1;
        Coords[1] = coord2;
        Coords[2] = coord3;
        Coords[3] = coord4;

    }
    public Coord[] Coords = new Coord[4];
    public bool Equals(Plot plot)
    {
        for (int i = 0; i < 4; i++)
        {
            if (plot.Coords[i].X != Coords[i].X
                || plot.Coords[i].Y != Coords[i].Y)
            {
                return false;
            } 
        }
        return true;

    }

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
        return claims.Any(c => c.Equals(plot));
    }

    public bool IsLastClaim(Plot plot)
    {
        return claims.Last().Equals(plot);
    }

    public Plot GetClaimWithLongestSide()
    {
        var longestSide = 0;
        var longestSideCount = 0;
        var count = 0;
        foreach (var claim in claims)
        {
            for (int i = 0; i < 4; i++)
            {
                if (claim.Coords[i].X > longestSide)
                {
                    longestSide = claim.Coords[i].X;
                    longestSideCount = count;
                }
                else if (claim.Coords[i].Y > longestSide)
                {
                    longestSide = claim.Coords[i].Y;
                    longestSideCount = count;
                }
            }
            count++;
        }
        return claims[longestSideCount];
    }
}
