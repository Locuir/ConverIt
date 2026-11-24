using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConverIt.Core
{
    internal class HelpCommand : ICommand
    {
        public void Execute(ParsedCommand parsedCommand, Logger logger)
        {
            logger.Info("Available commands:");
            logger.Info("help - Displays this help message.");
            logger.Info("convert - Converts a value from one unit to another.");
            logger.Info("exit - Exits the application.");


            logger.Success("Help command executed successfully.");
        }
    }
}
