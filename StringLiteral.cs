using System.Collections;
using System.Collections.Generic;

public class StringLiteral : IExpression
{
    public string Value { get; set; }
    public static implicit operator string(StringLiteral s) => s.Value;

    public void Print(int depth)
    {
        Console.WriteLine("Script/Print: " + new string(' ', depth * 2));
        Console.WriteLine("Script/Print: \"" + Value + "\"");
    }

    public object Interpret()
    {
        return Value;
    }
}
