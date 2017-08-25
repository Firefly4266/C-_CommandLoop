using System;

public class CommandLoop
{
    public static void Main(string[] args)
    {
        InputWrapper iw = new InputWrapper();
        Console.WriteLine("Enter command, 'quit' to exit.");
        string cmd = iw.getString("> ");
        while (!cmd.Equals("quit"))
        {
            if (cmd.Equals("Length"))
            {
                Console.WriteLine(cmd);
                break;
            }
            else if (cmd.Equals("new"))
            {
                Console.WriteLine(cmd);
                break;
            }
            else if (cmd.Equals("show"))
            {
                Console.WriteLine(cmd);
                break;
            }
            else
            {
                cmd = iw.getString(">> ");
            }
        }
    }
}