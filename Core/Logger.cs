using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConverIt.Core
{
    public class Logger
    {
        private readonly RichTextBox _Output;


        public Logger(RichTextBox output)
        {
            _Output = output ?? throw new ArgumentNullException(nameof(output));
        }

        public void Write(string message , Color color)
        {
      
            _Output.SelectionStart = _Output.TextLength;
            _Output.SelectionLength = 0;
            _Output.SelectionColor = color;
            _Output.AppendText(message + Environment.NewLine);
            _Output.SelectionColor = _Output.ForeColor;
            _Output.ScrollToCaret();

        }


        public void Info(string message)
        {
            Write("[INFO] " + message, Color.White);
        }

        public void Success(string message)
        {
            Write("[SUCCESS] " + message, Color.Green);
        }
        public void Error(string message)
        {
            Write("[ERROR] " + message, Color.Red);
        }


    }
}
