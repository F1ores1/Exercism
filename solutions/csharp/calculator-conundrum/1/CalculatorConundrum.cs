public static class SimpleCalculator
{
    public static string Calculate(int operand1, int operand2, string? operation)
    {
        switch (operation)
        {
            case "+": 
                return $"{operand1} {operation} {operand2} = {operand1 + operand2}";
                break;
            case "*":
                return $"{operand1} {operation} {operand2} = {operand1 * operand2}";
                break;           
            case "/":
                try
                {
                    return $"{operand1} {operation} {operand2} = {operand1 / operand2}";
                }
                catch (DivideByZeroException) {
                    return "Division by zero is not allowed.";
                }
                break;            
            default:
                if (operation == null)
                {
                    throw new ArgumentNullException();
                }
                else if (operation == "")
                {
                    throw new ArgumentException();
                }
                else
                {
                    throw new ArgumentOutOfRangeException();
                }
                break;
        }

        
        throw new NotImplementedException("Please implement the SimpleCalculator.Calculate() method");
    }
}
