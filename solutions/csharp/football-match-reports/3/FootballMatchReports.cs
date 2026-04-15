using System.Buffers;
using System.Runtime.CompilerServices;

public static class PlayAnalyzer
{
    public static string AnalyzeOnField(int shirtNum)
    {
        switch (shirtNum)
        {
            case 1:
                return "goalie";
            case 2:
                return "left back";
            case >= 3 and <= 4:
                return "center back";
            case 5:
                return "right back";
            case >= 6 and <= 8:
                return "midfielder";
            case 9:
                return "left wing";
            case 10:
                return "striker";
            case 11:
                return "right wing";
            default:
                return "UNKNOWN";
        }
        throw new NotImplementedException($"Please implement the (static) PlayAnalyzer.AnalyzeOnField() method");
    }

    public static string AnalyzeOffField(object report)
    {
        switch (report)
        {
            case int supporters:
                return $"There are {supporters} supporters at the match.";
                break;
            case string message:
                return message;
                break;
            case Foul foul:
                return foul.GetDescription();
                break;
            case Injury injury: 
                return $"Oh no! Player 3 is injured. Medics are on the field.";
                break;
            case Incident incident:
                return incident.GetDescription();
                break;
            case Manager manager when manager.Club != null:
                return $"{manager.Name} ({manager.Club})";
            case Manager manager:
                return manager.Name;
            default:
                return "";
        }
        throw new NotImplementedException($"Please implement the (static) PlayAnalyzer.AnalyzeOffField() method");
    }

//hello
}
