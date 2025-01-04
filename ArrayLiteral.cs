using System.Collections;
using System.Collections.Generic;

public class ArrayLiteral : IExpression
{
    public List<IExpression> Values { get; set; } = new List<IExpression>();

    public void Print(int depth)
    {
        Console.WriteLine("Script/Print: " + new string(' ', depth * 2));
        Console.WriteLine("Script/Print: [");

        foreach (IExpression node in Values)
        {
            node.Print(depth + 1);
        }

        Console.WriteLine("Script/Print: " + new string(' ', depth * 2));
        Console.WriteLine("Script/Print: ]");
    }

    public object Interpret()
    {
        List<object> result = new List<object>();

        foreach (IExpression node in Values)
        {
            result.Add(node.Interpret());
        }
        return result;
    }
}
