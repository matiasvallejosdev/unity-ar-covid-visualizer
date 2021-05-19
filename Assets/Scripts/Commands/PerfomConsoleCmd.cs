using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class PerfomConsoleCmd : ICommand
{
    private readonly string input;
    private readonly string prefix;
    private readonly IEnumerable<IConsoleCommand> commands;

    public PerfomConsoleCmd(string input, string prefix, IEnumerable<IConsoleCommand> commands)
    {
        this.input = input;
        this.prefix = prefix;
        this.commands = commands;
    }
   
    public void ProcessCommand(string inputValue)
    {
        if(!inputValue.StartsWith(prefix)){return;}
        
        inputValue = inputValue.Remove(0, prefix.Length);

        string[] inputSplit = inputValue.Split(' ');

        string commandInput = inputSplit[0];
        string[] args = inputSplit.Skip(1).ToArray();

        ProcessCommand(commandInput, args);
    }

    public void ProcessCommand(string commandInput, string[] args)
    {
        foreach(var command in commands)
        {
            if(!commandInput.Equals(command.CommandWord, System.StringComparison.OrdinalIgnoreCase))
            {
                continue;
            }

            if(command.Process(args))
            {
                return;
            }
        }
    }

    public void Execute()
    {
        ProcessCommand(input);
    }
}
