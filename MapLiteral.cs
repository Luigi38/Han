using System;
using System.Collections;
using System.Collections.Generic;

public class MapLiteral : IExpression
{
    public Dictionary<string, IExpression> Values { get; set; } = new Dictionary<string, IExpression>();

    public void Print(int depth)
    {
        Console.WriteLine("Script/Print: " + new string(' ', depth * 2));
        Console.WriteLine("Script/Print: {");

        foreach (string key in Values.Keys)
        {
            Console.WriteLine("Script/Print: " + key + ": ");
            Values[key].Print(depth + 1);
        }
        Console.WriteLine("Script/Print: " + new string(' ', depth * 2));
        Console.WriteLine("Script/Print: }");
    }

    public object Interpret()
    {
        Dictionary<string, object> result = new Dictionary<string, object>();
        foreach (string key in Values.Keys)
        {
            result[key] = Values[key].Interpret();
        }
        return result;
    }
}
