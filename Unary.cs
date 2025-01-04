using System;
using System.Collections;
using System.Collections.Generic;

public class Unary : IExpression
{
    public ArgumentKind Kind { get; set; }
    public IExpression Sub { get; set; }

    public void Print(int depth)
    {
        Console.WriteLine("Script/Print: " + new string(' ', depth * 2));
        Console.WriteLine("Script/Print: " + Kind.GetContent());
        Sub.Print(depth + 1);
    }

    public object Interpret()
    {
        object value = Sub.Interpret();

        if (Kind == ArgumentKind.Add && Datatype.IsNumber(value))
        {
            return Math.Abs(Datatype.ToNumber(value));
        }
        if (Kind == ArgumentKind.Subtract && Datatype.IsNumber(value))
        {
            return Datatype.ToNumber(value) * -1;
        }
        return 0.0;
    }
}
