static class Badge
{
    public static string Print(int? id, string name, string? department)
    {
        string? printID ="";
        
        if (id != null) printID = $"[{id}] - ";
        department ??= "OWNER";
        if (department != null) department = department.ToUpper();
        string badge = $"{printID}{name} - {department}";
        return badge;
        throw new NotImplementedException("Please implement the (static) Badge.Print() method");
    }
}
