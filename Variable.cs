using System;
using System.Collections;
using System.Collections.Generic;

public class Variable : IStatement
{
    public string Name { get; set; }
    public IExpression Expression { get; set; }
    public bool IsGlobal { get; set; } = false;

    public void Print(int depth)
    {
        Console.WriteLine("Script/Print: " + new string(' ', depth * 2));
        Console.WriteLine("Script/Print: VAR " + Name + ":");
        Expression.Print(depth + 1);
    }

    public void Interpret()
    {
        var vars = IsGlobal ? IngameManagerV2.Global : IngameManagerV2.Local;
        vars.Others.Add(Name, Expression.Interpret());
    }
}
