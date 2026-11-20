using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConverIt
{
    public class CommandParser
    {


        public ParsedCommand Parse(string command)
        {

            if (string.IsNullOrWhiteSpace(command))
            {
                throw new ArgumentException("Command cannot be null or whitespace.", nameof(command));
            }


            List<string> tokens = Tokenize(command);

            if (tokens.Count == 0)
            {
                throw new ArgumentException("Command cannot be empty after tokenization.", nameof(command));
            }

            ParsedCommand parsedCommand = new ParsedCommand();

            parsedCommand.Name = tokens[0];

            ParseTokens(tokens, parsedCommand);

            return parsedCommand;
        }



        private List<string> Tokenize(string command)
        {
            List<string> tokens = new List<string>();
            StringBuilder currentToken = new StringBuilder();
            bool insideQuotes = false;


            foreach (char c in command)
            {
                if (c == '"')
                {
                    insideQuotes = !insideQuotes;
                    continue;
                }
                if (char.IsWhiteSpace(c) && !insideQuotes)
                {
                    if (currentToken.Length > 0)
                    {
                        tokens.Add(currentToken.ToString());
                        currentToken.Clear();
                    }
                }
                else
                {
                    currentToken.Append(c);
                }
            }

            if ((insideQuotes))
            {
                throw new ArgumentException("Unmatched quotes in command.");
            }

            if (currentToken.Length > 0)
            {
                tokens.Add(currentToken.ToString());
            }


            return tokens;
        }

        private void ParseTokens(List<string> tokens , ParsedCommand command)
        {
            for (int i = 0; i < tokens.Count; i++)
            {

                string token = tokens[i];
                if (token.StartsWith("--"))
                {
                    string OptionName = token.Substring(2);

                    if (string.IsNullOrWhiteSpace(OptionName))
                    {
                        throw new ArgumentException("Option name cannot be empty.");
                    }
                    
                    if ( i + 1 < tokens.Count && !tokens[i + 1].StartsWith("--"))
                    {
                        command.Options[OptionName] = tokens[++i];
                       
                    }
                    else
                    {
                        command.Options[OptionName] = "true";
                    }



                }
                else
                {
                    command.Arguments.Add(token);
                }
            }
        }
    }

}
