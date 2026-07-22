// TODO: define the 'AccountType' enum

[Flags]
enum Permission : byte
{
    None = 0,
    Read = 1,
    Write = 2,
    Delete = 4,
    All = Read | Write | Delete
}
[Flags]
enum AccountType : byte
{
    Guest,
    User,
    Moderator 
}

// TODO: define the 'Permission' enum

static class Permissions
{
    public static Permission Default(AccountType accountType)
    {
        Permission Default = Permission.None;
        switch (accountType)
        {
            case AccountType.Guest:
                return Permission.Read;
            
            case AccountType.User:
                return  Default |= Permission.Read | Permission.Write;

            case AccountType.Moderator:
                return Default |= Permission.All;
                
            default: 
                return Permission.None;
        }
    }

    public static Permission Grant(Permission current, Permission grant)
    {
        return current |= grant;
    }

    public static Permission Revoke(Permission current, Permission revoke)
    {
        return current &= ~revoke;
    }

    public static bool Check(Permission current, Permission check)
    {
        return (current & check) == check;



    }
}
