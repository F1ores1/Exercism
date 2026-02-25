
static class Appointment
{
    
    public static DateTime Schedule(string appointmentDateDescription)
    {
        DateTime dt = DateTime.Parse(appointmentDateDescription);
    
        return dt;
    }

    public static bool HasPassed(DateTime appointmentDate)
    {
        return (appointmentDate < DateTime.Now);
    }

    public static bool IsAfternoonAppointment(DateTime appointmentDate)
    {
        return (new TimeSpan(12,0,0) <= appointmentDate.TimeOfDay && 
        appointmentDate.TimeOfDay < new TimeSpan(18,0,0));
    }

    public static string Description(DateTime appointmentDate)
    {
        return $"You have an appointment on {appointmentDate}.";
    }

    public static DateTime AnniversaryDate()
    {
        return new DateTime(2026, 9, 15, 0, 0, 0);
    }
}
