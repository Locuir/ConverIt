using ConverIt.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConverIt.Core
{
    public static class CommandSetup
    {

        public static CommandExecutor CreateExecutor()
        {
            CommandExecutor executor = new CommandExecutor();

            executor.RegisterCommand("help", new HelpCommand());
            executor.RegisterCommand("convert", new ConvertCommand());

            return executor;
        }


    }
}
