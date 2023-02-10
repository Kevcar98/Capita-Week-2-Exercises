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
    public partial class Circle : Form
    {
        public Circle()
        {
            InitializeComponent();
        }

        private void Calculate_Click(object sender, EventArgs e)
        {
            double Radius;
            if (RadiusText.Text == "")
            {
                string message = "Please enter a valid value";
                string title = "Error";
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                DialogResult result = MessageBox.Show(message, title, buttons, MessageBoxIcon.Warning);
            }
            else
            {
                String SRadius = RadiusText.Text;
                if (double.TryParse(SRadius, out Radius))//if successfull in converting output it to the variable radius
                {
                    double answer = Math.Pow(Radius, 2) * Math.PI;
                    Console.WriteLine(answer);
                    this.RadiusL.Text = "The area of the Circle is: " + answer.ToString();
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

        private void RectangleB_Click(object sender, EventArgs e)
        {
            Rectangle rectangle = new Rectangle();
            this.Hide();
            rectangle.Show();
        }

        private void TriangleB_Click(object sender, EventArgs e)
        {
            Triangle triangle = new Triangle();
            this.Hide();
            triangle.Show();
        }
    }
}
