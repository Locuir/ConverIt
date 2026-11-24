using ConverIt.Core;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConverIt
{



    public partial class Form1 : Form
    {

        private Logger _logger;
        private CommandExecutor _executor;
        public Form1()
        {
            InitializeComponent();

            _logger = new Logger(Output);
            _executor = CommandSetup.CreateExecutor();
            
        }

        private void uiipTextBox1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void cuiTextBox1_ContentChanged(object sender, EventArgs e)
        {

        }

        private void btnExecute_Click(object sender, EventArgs e)
        {
            string input = Txtinput.Text;

            if (string.IsNullOrWhiteSpace(input))
            {
                return;
            }

            _logger.Write("> " + input , Color.Cyan);


            try
            {
                CommandParser parser = new CommandParser();
                ParsedCommand parsedCommand = parser.Parse(input);

                _executor.ExecuteCommand(parsedCommand, _logger);


            }
            catch (Exception ex)
            {
                _logger.Error(ex.Message);
            }
            
            Txtinput.Focus();

        }
    }
}
