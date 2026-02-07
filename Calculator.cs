using System;

public static class Calculator
{
    public static double? Calculate(int first, int second, string operation)
    {
        static string Calculate(int a, int b, string op)
    {
        switch (op)
        {
            case "+": return (a + b).ToString();
            case "-": return (a - b).ToString();
            case "*": return (a * b).ToString();
            case "/":
                if (b == 0) return "Cannot divide by zero";
                return ((double)a / b).ToString("0.##");
            case "%":
                if (b == 0) return "Cannot modulo by zero";
                return (a % b).ToString();
            case "=": return "";
            default: return "Invalid operation";
        }
    }
}
