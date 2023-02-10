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
    public partial class Triangle : Form
    {
        public Triangle()
        {
            InitializeComponent();
        }

        private void Calculate_Click(object sender, EventArgs e)
        {
            double Base, Height, Answer;

            if (TBaseText.Text == "")
            {

                string message = "Please enter a valid value";
                string title = "Error";
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                DialogResult result = MessageBox.Show(message, title, buttons, MessageBoxIcon.Warning);

            }
            else if (THeightText.Text == "")
            {
                string message = "Please enter a valid value";
                string title = "Error";
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                DialogResult result = MessageBox.Show(message, title, buttons, MessageBoxIcon.Warning);
            }
            else
            {
                if (double.TryParse(TBaseText.Text, out Base))
                {
                    if (double.TryParse(THeightText.Text, out Height))
                    {
                        Answer = (Height * Base)/2;
                        this.TAnsLabel.Text = "The area of the Triangle is: " + Answer.ToString();
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

        private void CircleButton_Click(object sender, EventArgs e)
        {
            Circle circle = new Circle();
            this.Hide();
            circle.Show();
        }

        private void TriangleButton_Click(object sender, EventArgs e)
        {
            Rectangle rectangle = new Rectangle();
            this.Hide();
            rectangle.Show();
        }
    }
}
