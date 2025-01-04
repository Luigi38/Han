using System.Collections;
using System.Collections.Generic;

public class Function : IStatement
{
    public string Name { get; set; }
    public List<string> Parameters { get; set; } = new List<string>();
    public List<IStatement> Block { get; set; }
    private int _index = 0;

    public void Add(string parameter)
    {
        Parameters.Add(parameter);
    }

    public void Print(int depth)
    {
        Console.WriteLine("Script/Print: " + new string(' ', depth * 2));
        Console.WriteLine("Script/Print: FUNCTION " + Name + ": ");

        if (Parameters.Count > 0)
        {
            Console.WriteLine("Script/Print: " + new string(' ', (depth + 1) * 2));
            Console.WriteLine("Script/Print: PARAMETERS:");

            foreach (string name in Parameters) {
                Console.WriteLine("Script/Print: " + name + " ");
            }
            Console.WriteLine("Script/Print: ");
        }

        Console.WriteLine("Script/Print: " + new string(' ', (depth + 1) * 2));
        Console.WriteLine("Script/Print: BLOCK:");

        foreach (IStatement node in Block)
        {
            node.Print(depth + 2);
        }
    }

    public void Interpret()
    {
        foreach (IStatement node in Block)
        {
            node.Interpret();
        }
    }
}