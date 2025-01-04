using System.Collections;
using System.Collections.Generic;

public class RpyComment : IStatement
{
    public string Content { get; set; } = string.Empty;

    public void Print(int depth)
    {

    }

    public void Interpret()
    {
        //Console.WriteLine("Script/Interpret: # " + Content);
    }
}
