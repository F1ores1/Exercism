using System.Data;
using System.Reflection;

public static class Gigasecond
{
    public static DateTime Add(DateTime moment)
    {


        // // long[] secondTranslation = new long[] {31536000, 2628000, 86400, 3600, 60};

        // // int[] gigaValues = new int[6];

        // // long lastValue = giga;

        // // long remainder = 0;

        // // for (int i = 0; i < 5; i++)
        // // {
        // //     remainder = lastValue/secondTranslation[i];

        // //     gigaValues[i] = (int)((lastValue - remainder)/secondTranslation[i]);

        // //     lastValue = lastValue - remainder;
        // // }
        // // gigaValues[5] = (int)remainder;

        // // // throw new Exception(string.Join(", ", gigaValues));

        

        // // // DateTime gigaDate = new DateTime(gigaValues[0], gigaValues[1], gigaValues[2], gigaValues[3],gigaValues[4], gigaValues[5]);
        // // DateTime test = new DateTime(31, 364, 0, 0, 0, 0);
        // // throw new Exception(test.ToString());
        // // // return gigaDate;
        // long giga = 1000000000;

        // long remainder = giga % 31536000;

        // int years = (int)((giga - remainder)/31536000);

        // // throw new Exception(years.ToString());

        // moment = moment.AddYears(years);

        // long remainder2 = remainder % 2628000;

        // int months = (int)((remainder - remainder2));


        // moment = moment.AddSeconds(months);

        // long remainder3 = remainder2 % 86400;
        // // throw new Exception(((remainder2 - remainder3)/86400).ToString());

        // int days = (int)((remainder2 - remainder3)/86400);
        // moment = moment.AddDays(days);

        // // throw new Exception(moment.ToString());

        // long remainder4 = remainder3 % 3600;

        // int hours = (int)((remainder3 - remainder4)/3600);

        // moment = moment.AddHours(hours);

        // long remainder5 = remainder4 % 60;

        // int minutes = (int)((remainder4 - remainder5)/60);

        // moment = moment.AddMinutes(minutes);

        // moment = moment.AddSeconds((int)remainder5);
        // // throw new Exception($"{(years).ToString()} {months.ToString()} {days.ToString()} {hours.ToString()} ");
        moment = moment.AddSeconds(1000000000);

        return moment;


    }
}