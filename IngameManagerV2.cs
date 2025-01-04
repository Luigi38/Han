using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using Path = System.IO.Path;

public class IngameManagerV2
{
    //public static IngameManagerV2 Instance { get; set; } = null;
    public static VariableCollection Local { get; private set; } = new VariableCollection(); //TODO: every label (using stack)
    public static VariableCollection Global { get; private set; } = new VariableCollection();

    public static Interpreter Interpreter;

    public static T GetVariable<T>(string name, ref Dictionary<string, T> local, ref Dictionary<string, T> global)
    {
        if (local.ContainsKey(name)) return local[name];
        if (global.ContainsKey(name)) return global[name];
        return default;
    }

    public static List<T> CombineValues<T>(ref Dictionary<string, T> local, ref Dictionary<string, T> global, Func<T, List<T>, bool> compare = null)
    {
        var list = new List<T>(local.Values);
        
        foreach (var g in global.Values)
        {
            if (compare == null || !compare(g, list))
            {
                list.Add(g);
            }
        }

        return list;
    }
}
