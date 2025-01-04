using System;
using System.Collections;
using System.Collections.Generic;

public class SetVariable : IExpression
{
    public string Name { get; set; }
    public IExpression Value { get; set; }

    public void Print(int depth)
    {
        Console.WriteLine("Script/Print: " + new string(' ', depth * 2));
        Console.WriteLine("Script/Print: SET_VARIABLE: " + Name);
        Value.Print(depth + 1);
    }

    public object Interpret()
    {
        if (IngameManagerV2.Local.Others.ContainsKey(Name)) IngameManagerV2.Local.Others[Name] = Value.Interpret();
        else if (IngameManagerV2.Global.Others.ContainsKey(Name)) IngameManagerV2.Global.Others[Name] = Value.Interpret();

        return IngameManagerV2.GetVariable(Name, ref IngameManagerV2.Local.Others, ref IngameManagerV2.Global.Others);
    }
}
