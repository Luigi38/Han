using System.Collections;
using System.Collections.Generic;

public class And : IExpression
{
    public IExpression Lhs { get; set; }
    public IExpression Rhs { get; set; }

    public void Print(int depth)
    {
        Console.WriteLine("Script/Print: " + new string(' ', depth * 2));
        Console.WriteLine("Script/Print: AND:");

        Console.WriteLine("Script/Print: " + new string(' ', (depth + 1) * 2));
        Console.WriteLine("Script/Print: LHS:");
        Lhs.Print(depth + 2);

        Console.WriteLine("Script/Print: " + new string(' ', (depth + 1) * 2));
        Console.WriteLine("Script/Print: RHS:");
        Rhs.Print(depth + 2);
    }

    public object Interpret()
    {
        return Datatype.IsFalse(Lhs.Interpret()) ? false : Rhs.Interpret();
    }
}
