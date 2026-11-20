using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConverIt
{
    public class ParsedCommand
    {
        public string Name { get; set; }

        public List<string> Arguments { get; set; } = new List<string>();

        public Dictionary<String , String> Options { get; set; } = new Dictionary<String, String>();


    }
}
