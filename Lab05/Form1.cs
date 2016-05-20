using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab05
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Matthew Vaughan\nCS1400\nLab #4");
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
            // The inputTextBox_Leave Method
            // Purpose: Get a value from the user and display it back again
            // Parameters: The sending object, and the event arguments
            // Returns: none

        private void inputTextBox_Leave(object sender, EventArgs e)
        {
            const int DOUBLE = 2;
            int num = int.Parse(inputTextBox.Text);
            int doubledNum = num * DOUBLE;
            string outStr = $"{doubledNum:D}";
            outputTextBox.Text = outStr;
        }
    }
}
