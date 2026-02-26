abstract class Character
{
    protected Character(string characterType)
    {
    }

    public abstract int DamagePoints(Character target);

    public virtual bool Vulnerable()
    {
        return false;
    }

    public override string ToString()
    {
        return "Character";
    }
}

class Warrior : Character
{
    public Warrior() : base("TODO")
    {
    }

    public override int DamagePoints(Character target)
    {
        if (target.Vulnerable() == true) return 10;
        else return 6;
    }

    public override string ToString()
    {
        return "Character is a Warrior";
    }

}

class Wizard : Character
{
    bool spellprep = false;
    public Wizard() : base("TODO")
    {
    }

    public override int DamagePoints(Character target)
    {
        if (spellprep == true) return 12;
        else return 3;
    }

    public void PrepareSpell()
    {
        spellprep = true;
    }

    public override string ToString()
    {
        return "Character is a Wizard";
    }

    public override bool Vulnerable()
    {
        return !(spellprep == true);

    }


}
