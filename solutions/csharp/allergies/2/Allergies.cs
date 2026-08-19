[Flags]
public enum Allergen
{
    Eggs = 1 << 0,
    Peanuts = 1 << 1,
    Shellfish = 1 << 2,
    Strawberries = 1 << 3,
    Tomatoes = 1 << 4,
    Chocolate = 1 << 5,
    Pollen = 1 << 6,
    Cats = 1 << 7
}

public class Allergies
{
    public Allergen AllergenVal;
    
    public Allergies(int mask)
    {
        AllergenVal |= (Allergen)mask;
    }

    public bool IsAllergicTo(Allergen allergen)
    {
        return (AllergenVal & allergen) == allergen;
        
    }

    public Allergen[] List()
    {
        return Enum.GetValues(typeof(Allergen))
                .Cast<Allergen>()
                .Where(al => IsAllergicTo(al))
                .ToArray();
    }
}