using System.Collections;
using System.Collections.Generic;

public class If : IStatement
{
    public List<IExpression> Conditions { get; set; } = new List<IExpression>();
    public List<List<IStatement>> Blocks { get; set; } = new List<List<IStatement>>();
    public List<IStatement> ElseBlock { get; set; } = new List<IStatement>();

    public void Print(int depth)
    {
        for (int i = 0; i < Conditions.Count; i++)
        {
            Console.WriteLine("Script/Print: " + new string(' ', depth * 2));
            Console.WriteLine("Script/Print: " + (i == 0 ? "IF:" : "ELIF:"));

            Console.WriteLine("Script/Print: " + new string(' ', (depth + 1) * 2));
            Console.WriteLine("Script/Print: CONDITION:");
            Conditions[i].Print(depth + 2);
            Console.WriteLine("Script/Print: " + new string(' ', (depth + 1) * 2));

            Console.WriteLine("Script/Print: BLOCK:");

            foreach (IStatement node in Blocks[i])
            {
                node.Print(depth + 2);
            }
        }

        if (ElseBlock == null || ElseBlock.Count == 0)
        {
            return;
        }

        Console.WriteLine("Script/Print: " + new string(' ', depth * 2));
        Console.WriteLine("Script/Print: ELSE:");
        foreach (IStatement node in ElseBlock)
        {
            node.Print(depth + 1);
        }
    }

    public void Interpret()
    {
        for (int i = 0; i < Conditions.Count; i++)
        {
            object result = Conditions[i].Interpret();

            if (!Datatype.IsTrue(result))
            {
                continue;
            }

            Interpreter.Local[Interpreter.Local.Count - 1].Insert(0, new Dictionary<string, object>());
            foreach (IStatement node in Blocks[i])
            {
                node.Interpret();
            }
            Interpreter.Local[Interpreter.Local.Count - 1].RemoveAt(0);
            return;
        }

        if (ElseBlock.Count == 0)
        {
            return;
        }

        //else
        Interpreter.Local[Interpreter.Local.Count - 1].Insert(0, new Dictionary<string, object>());
        foreach (IStatement node in ElseBlock)
        {
            node.Interpret();
        }
        Interpreter.Local[Interpreter.Local.Count - 1].RemoveAt(0);
    }
}
