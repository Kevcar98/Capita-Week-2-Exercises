using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Circle
{
    public partial class Rectangle : Form
    {
        public Rectangle()
        {
            InitializeComponent();
        }

        private void RCalculateButton_Click(object sender, EventArgs e)
        {
            double Base,Height,Answer;

            if (RBaseText.Text == "")
            {
                string message = "Please enter a validvalid value";
                string title = "Error";
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                DialogResult result = MessageBox.Show(message, title, buttons, MessageBoxIcon.Warning);
            }
            else if (RHeightText.Text == "")
            {
                string message = "Please enter a valid value";
                string title = "Error";
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                DialogResult result = MessageBox.Show(message, title, buttons, MessageBoxIcon.Warning);
            }
            else
            {
                if (double.TryParse(RBaseText.Text, out Base))
                {
                    if (double.TryParse(RHeightText.Text, out Height))
                    {
                        Answer = Height * Base;
                        this.RAnsLabel.Text = "The area of the Rectangle is: " + Answer.ToString();
                    }
                    else
                    {
                        string message = "Please enter a valid value";
                        string title = "Error";
                        MessageBoxButtons buttons = MessageBoxButtons.OK;
                        DialogResult result = MessageBox.Show(message, title, buttons, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    string message = "Please enter a valid value";
                    string title = "Error";
                    MessageBoxButtons buttons = MessageBoxButtons.OK;
                    DialogResult result = MessageBox.Show(message, title, buttons, MessageBoxIcon.Warning);
                }
            }
        }
    }
}
