using System.Collections;
using System.Collections.Generic;

public class ExpressionStatement : IStatement
{
    public IExpression Expression { get; set; }

    public void Print(int depth)
    {
        Console.WriteLine("Script/Print: " + new string(' ', depth * 2));
        Console.WriteLine("Script/Print: EXPRESSION:");
        Expression.Print(depth + 1);
    }

    public void Interpret()
    {
        Expression.Interpret();
    }
}