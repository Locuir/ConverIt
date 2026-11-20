using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConverIt
{
    public class CommandExecutor
    {

        private Dictionary<string, ICommand> Commands = new Dictionary<string, ICommand>();


        public void RegisterCommand(string commandName, ICommand command)
        {
            if (string.IsNullOrWhiteSpace(commandName))
            {
                throw new ArgumentException("Command name cannot be null or whitespace.", nameof(commandName));
            }
            if (command == null)
            {
                throw new ArgumentNullException(nameof(command), "Command cannot be null.");
            }

            Commands.Add(commandName, command);
        }

        public void ExecuteCommand(ParsedCommand Command)
        {
            if (Command == null)
            {
                throw new ArgumentNullException(nameof(Command), "Parsed command cannot be null.");
            }
            if (!Commands.TryGetValue(Command.Name, out ICommand command))
            {
                throw new InvalidOperationException($"No command registered with the name '{Command.Name}'.");
            }
            Commands[Command.Name].Execute(Command);
        }



    }
}
