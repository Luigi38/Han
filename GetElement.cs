using System.Collections;
using System.Collections.Generic;

public class GetElement : IExpression
{
    public IExpression Sub { get; set; }
    public IExpression Index { get; set; }

    public void Print(int depth)
    {
        Console.WriteLine("Script/Print: " + new string(' ', depth * 2));
        Console.WriteLine("Script/Print: GET_ELEMENT:");

        Console.WriteLine("Script/Print: " + new string(' ', (depth + 1) * 2));
        Console.WriteLine("Script/Print: SUB:");
        Sub.Print(depth + 2);

        Console.WriteLine("Script/Print: " + new string(' ', (depth + 1) * 2));
        Console.WriteLine("Script/Print: INDEX:");
        Index.Print(depth + 2);
    }

    public object Interpret()
    {
        object obj = Sub.Interpret();
        object index = Index.Interpret();

        if (Datatype.IsArray(obj) && Datatype.IsNumber(index))
        {
            return Datatype.GetValueOfArray(obj, index);
        }
        if (Datatype.IsMap(obj) && Datatype.IsString(index))
        {
            return Datatype.GetValueOfMap(obj, index);
        }
        return null;
    }
}
