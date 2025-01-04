using System.Collections;
using System.Collections.Generic;

public class NumberLiteral : IExpression
{
    public double Value { get; set; } = 0.0;

    public void Print(int depth)
    {
        Console.WriteLine("Script/Print: " + new string(' ', depth * 2));
        Console.WriteLine("Script/Print: " + Value.ToString());
    }

    public object Interpret()
    {
        return Value;
    }
}