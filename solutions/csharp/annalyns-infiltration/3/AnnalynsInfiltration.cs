static class QuestLogic
{
    public static bool CanFastAttack(bool knightIsAwake) => !knightIsAwake;

    public static bool CanSpy(bool knightIsAwake, bool archerIsAwake, bool prisonerIsAwake)
    {
        //throw new NotImplementedException("Please implement the (static) QuestLogic.CanSpy() method");
        return (knightIsAwake | archerIsAwake | prisonerIsAwake);

    }

    public static bool CanSignalPrisoner(bool archerIsAwake, bool prisonerIsAwake)
    {
        //throw new NotImplementedException("Please implement the (static) QuestLogic.CanSignalPrisoner() method");
        return (prisonerIsAwake && !archerIsAwake);

    }

    public static bool CanFreePrisoner(bool knightIsAwake, bool archerIsAwake, bool prisonerIsAwake, bool petDogIsPresent)
    {
        //throw new NotImplementedException("Please implement the (static) QuestLogic.CanFreePrisoner() method");
        //&& has a circuit breaker. Faster than & if the statment isn't true 
        return (petDogIsPresent && !archerIsAwake) | (prisonerIsAwake && !archerIsAwake && !knightIsAwake);

    }
}
