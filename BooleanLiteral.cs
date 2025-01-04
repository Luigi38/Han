using System;
using System.Collections;
using System.Collections.Generic;

public class BooleanLiteral : IExpression
{
    public bool Value { get; set; } = false;

    public void Print(int depth)
    {
        Console.WriteLine("Script/Print: " + new string(' ', depth * 2));
        Console.WriteLine("Script/Print: " + (Value ? "true" : "false"));
    }

    public object Interpret()
    {
        return Value;
    }
}
