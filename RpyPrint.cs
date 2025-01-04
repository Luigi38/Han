using System.Collections;
using System.Collections.Generic;

public class RpyPrint : IStatement
{
    public IExpression Content { get; set; }

    public void Print(int depth)
    {

    }

    public void Interpret()
    {
        Console.WriteLine(Content.Interpret());
    }
}
