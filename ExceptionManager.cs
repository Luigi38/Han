using System.Collections;
using System.Collections.Generic;

public class ExceptionManager
{
    /// <summary>
    /// Throws the error and show log ([scriptName] : [message])
    /// </summary>
    public static void Throw(string message, string scriptName = "", int lineCount = -1)
    {
        string message2 = $"{scriptName} : {message}";
        //string message3 = $"Error occured!\n\nThe message:\n{message}";

        if (lineCount > 0)
        {
            message2 += $" : (Line {lineCount})";
            //message3 += $"\n(Line {lineCount})";
        }

        Console.WriteLine(message2);
    }
}
