public class FacialFeatures
{
    public string EyeColor { get; }
    public decimal PhiltrumWidth { get; }

    public FacialFeatures(string eyeColor, decimal philtrumWidth)
    {
        EyeColor = eyeColor;
        PhiltrumWidth = philtrumWidth;
    }
    // TODO: implement equality and GetHashCode() methods
    public override bool Equals(object? obj)
    {
        return obj is FacialFeatures other
            && EyeColor == other.EyeColor
            && PhiltrumWidth == other.PhiltrumWidth;
        
    }

    public override int GetHashCode()
    {
        return base.GetHashCode();
    }


}

public class Identity
{
    public string Email { get; }
    public FacialFeatures FacialFeatures { get; }

    public Identity(string email, FacialFeatures facialFeatures)
    {
        Email = email;
        FacialFeatures = facialFeatures;
    }

    public override bool Equals(object? obj)
    {
        return obj is Identity other
            && Email == other.Email
            && FacialFeatures.Equals(other.FacialFeatures);
    }
    public override int GetHashCode()
    {
        return base.GetHashCode();
    }


}

public class Authenticator
{

    public List<Identity> StoredIdentities= new List<Identity>();
    public static bool AreSameFace(FacialFeatures faceA, FacialFeatures faceB)
    {
        return faceA.Equals(faceB);
    }

    public bool IsAdmin(Identity identity)
    {
       return identity.Equals(new Identity("admin@exerc.ism", new FacialFeatures("green", 0.9m)));
    }

    public bool Register(Identity identity)
    {
        if (StoredIdentities.Contains(identity))
        {
            return false;
        }
        else
        {
            StoredIdentities.Add(identity);
            return true;  
        }

        
    }

    public bool IsRegistered(Identity identity)
    {
        return StoredIdentities.Contains(identity);

    }

    public static bool AreSameObject(Identity identityA, Identity identityB)
    {
        return identityA.GetHashCode() == identityB.GetHashCode();
    }
}
