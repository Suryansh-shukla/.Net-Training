using System;

namespace day6demo3;
    public static class ExpressionEval
    {
        public static string Evaluate(string expr)
        {
            string[] parts = expr.Split(' ');
            if (parts.Length != 3) return "Error:InvalidExpression";

            if (!int.TryParse(parts[0], out int a) ||
                !int.TryParse(parts[2], out int b))
                return "Error:InvalidNumber";

            return parts[1] switch
            {
                "+" => (a + b).ToString(),
                "-" => (a - b).ToString(),
                "*" => (a * b).ToString(),
                "/" => b == 0 ? "Error:DivideByZero" : (a / b).ToString(),
                _ => "Error:UnknownOperator"
            };
        }
    }
