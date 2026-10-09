using System.Collections.Generic;

public static class BottleSong
{
    public static IEnumerable<string> Recite(int startBottles, int takeDown)
    {
        List<string> bottles = 
        [
            "No",
            "One",
            "Two",
            "Three",
            "Four",
            "Five",
            "Six",
            "Seven",
            "Eight",
            "Nine",
            "Ten"
        ];
        // yield return $"{bottles[startBottles]} green bottles hanging on the wall,";
        // yield return $"{bottles[startBottles]} green bottles hanging on the wall,";
        // yield return "And if one green bottle should accidentally fall,";
        // yield return $"There'll be {bottles[startBottles - 1].ToLower()} green bottles hanging on the wall.";


        for (int i = startBottles; i > startBottles - takeDown; i--)
        {
            var bottleCount = i == 1 ? "bottle" : "bottles";
            var nextBottleCount = i - 1 == 1 ? "bottle" : "bottles";

            yield return $"{bottles[i]} green {bottleCount} hanging on the wall,";
            yield return $"{bottles[i]} green {bottleCount} hanging on the wall,";
            yield return "And if one green bottle should accidentally fall,";
            yield return $"There'll be {bottles[i - 1].ToLower()} green {nextBottleCount} hanging on the wall.";

            if (i > startBottles - takeDown + 1)
                yield return "";

        }

    }
}
