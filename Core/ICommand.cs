using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConverIt
{
    public interface ICommand
    {

        void Execute(ParsedCommand parsedCommand);
    }
}
