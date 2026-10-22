public static class Wordy
{
    public static int Answer(string question)
    {
        var words = question.Split();

        if (words[0] != "What")
            throw new ArgumentException();

        List<int> numbers = new();
        List<string> operations = new();

        string[] oTypes = ["plus", "minus", "multiplied", "divided"];

        var prevWord = false;
        var prevDigit = false;


        foreach (var word in words)
        {
            var cleanWord = String.Concat(word.Where(c => char.IsLetterOrDigit(c) || c == '-'));

            if (!oTypes.Contains(cleanWord) && !cleanWord.All(c => char.IsDigit(c) || c == '-') 
                && cleanWord != "What" && cleanWord != "is" && cleanWord != "by")
                throw new ArgumentException();

            if (oTypes.Contains(cleanWord) && prevDigit == false)
            {
                throw new ArgumentException();
            }
            else if(oTypes.Contains(cleanWord) && prevWord == false)
            {
                operations.Add(cleanWord);
                prevWord = true;
                prevDigit = false;
            }

            if (cleanWord.All(c => char.IsDigit(c) || c == '-') && prevDigit == true)
            {
                throw new ArgumentException();
            }
            else if (cleanWord.All(c => char.IsDigit(c) || c == '-'))
            {
                numbers.Add(int.Parse(cleanWord));
                prevWord = false;
                prevDigit = true;
            }
        }

        if (numbers.Count != operations.Count + 1)
            throw new ArgumentException();
        else if (numbers.Count == 1)
            return numbers[0];


        return Enumerable.Range(0, numbers.Count - 1)
            .Aggregate(numbers[0], (acc, i) => acc = Math(acc, operations[i], numbers[i+1]));

    }
    public static int Math(int a, string word, int b)
    {
        switch (word)
        {
            
            case "plus":
                return a + b;
            
            case "minus":
                return a - b;

            case "multiplied":
                return a * b;

            case "divided":
                return a / b;

            default:
                throw new ArgumentException();

        }
    }

}