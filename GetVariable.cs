using System.Collections;
using System.Collections.Generic;

public class GetVariable : IExpression
{
    public string Name { get; set; }
    public static implicit operator string(GetVariable s) => s.Name;

    public void Print(int depth)
    {
        Console.WriteLine("Script/Print: " + new string(' ', depth * 2));
        Console.WriteLine("Script/Print: GET_VARIABLE: " + Name);
    }

    public object Interpret()
    {
        var glocal1 = IngameManagerV2.GetVariable(Name, ref IngameManagerV2.Local.Others, ref IngameManagerV2.Global.Others);

        if (glocal1 != null) return glocal1;

        if (Interpreter.FunctionTable.ContainsKey(Name))
        {
            return Interpreter.FunctionTable[Name];
        }
        return null;
    }
}
