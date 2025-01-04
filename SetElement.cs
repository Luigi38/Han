using System.Collections;
using System.Collections.Generic;

public class SetElement : IExpression
{
    public IExpression Sub { get; set; }
    public IExpression Index { get; set; }
    public IExpression Value { get; set; }

    public void Print(int depth)
    {
        Console.WriteLine("Script/Print: " + new string(' ', depth * 2));
        Console.WriteLine("Script/Print: SET_ELEMENT:");

        Console.WriteLine("Script/Print: " + new string(' ', (depth + 1) * 2));
        Console.WriteLine("Script/Print: SUB:");
        Sub.Print(depth + 2);

        Console.WriteLine("Script/Print: " + new string(' ', (depth + 1) * 2));
        Console.WriteLine("Script/Print: INDEX:");
        Index.Print(depth + 2);

        Console.WriteLine("Script/Print: " + new string(' ', (depth + 1) * 2));
        Console.WriteLine("Script/Print: VALUE:");
        Value.Print(depth + 2);
    }

    public object Interpret()
    {
        object obj = Sub.Interpret();
        object index = Index.Interpret();
        object value = Value.Interpret();

        if (Datatype.IsArray(obj) && Datatype.IsNumber(index))
        {
            return Datatype.SetValueOfArray(obj, index, value);
        }
        if (Datatype.IsMap(obj) && Datatype.IsString(index))
        {
            return Datatype.SetValueOfMap(obj, index, value);
        }
        return null;
    }
}
