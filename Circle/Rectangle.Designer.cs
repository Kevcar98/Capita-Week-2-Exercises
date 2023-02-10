namespace Circle
{
    partial class Rectangle
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.RTitle = new System.Windows.Forms.Label();
            this.RCalculateButton = new System.Windows.Forms.Button();
            this.RBaseText = new System.Windows.Forms.TextBox();
            this.RHeightText = new System.Windows.Forms.TextBox();
            this.RBaseLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.RAnsLabel = new System.Windows.Forms.Label();
            this.TriangleButton = new System.Windows.Forms.Button();
            this.CircleButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // RTitle
            // 
            this.RTitle.AutoSize = true;
            this.RTitle.Location = new System.Drawing.Point(349, 30);
            this.RTitle.Name = "RTitle";
            this.RTitle.Size = new System.Drawing.Size(102, 13);
            this.RTitle.TabIndex = 0;
            this.RTitle.Text = "Area of a Rectangle";
            // 
            // RCalculateButton
            // 
            this.RCalculateButton.Location = new System.Drawing.Point(575, 159);
            this.RCalculateButton.Name = "RCalculateButton";
            this.RCalculateButton.Size = new System.Drawing.Size(75, 23);
            this.RCalculateButton.TabIndex = 1;
            this.RCalculateButton.Text = "Calculate";
            this.RCalculateButton.UseVisualStyleBackColor = true;
            this.RCalculateButton.Click += new System.EventHandler(this.RCalculateButton_Click);
            // 
            // RBaseText
            // 
            this.RBaseText.Location = new System.Drawing.Point(416, 145);
            this.RBaseText.Name = "RBaseText";
            this.RBaseText.Size = new System.Drawing.Size(100, 20);
            this.RBaseText.TabIndex = 2;
            // 
            // RHeightText
            // 
            this.RHeightText.Location = new System.Drawing.Point(416, 180);
            this.RHeightText.Name = "RHeightText";
            this.RHeightText.Size = new System.Drawing.Size(100, 20);
            this.RHeightText.TabIndex = 3;
            // 
            // RBaseLabel
            // 
            this.RBaseLabel.AutoSize = true;
            this.RBaseLabel.Location = new System.Drawing.Point(228, 145);
            this.RBaseLabel.Name = "RBaseLabel";
            this.RBaseLabel.Size = new System.Drawing.Size(156, 13);
            this.RBaseLabel.TabIndex = 4;
            this.RBaseLabel.Text = "Enter the base of the rectangle:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(222, 188);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(162, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Enter the height of the rectangle:";
            // 
            // RAnsLabel
            // 
            this.RAnsLabel.AutoSize = true;
            this.RAnsLabel.Location = new System.Drawing.Point(348, 242);
            this.RAnsLabel.Name = "RAnsLabel";
            this.RAnsLabel.Size = new System.Drawing.Size(109, 13);
            this.RAnsLabel.TabIndex = 6;
            this.RAnsLabel.Text = "_________________";
            // 
            // TriangleButton
            // 
            this.TriangleButton.Location = new System.Drawing.Point(159, 356);
            this.TriangleButton.Name = "TriangleButton";
            this.TriangleButton.Size = new System.Drawing.Size(146, 23);
            this.TriangleButton.TabIndex = 7;
            this.TriangleButton.Text = "Find area of Triangle";
            this.TriangleButton.UseVisualStyleBackColor = true;
            // 
            // CircleButton
            // 
            this.CircleButton.Location = new System.Drawing.Point(575, 356);
            this.CircleButton.Name = "CircleButton";
            this.CircleButton.Size = new System.Drawing.Size(135, 23);
            this.CircleButton.TabIndex = 8;
            this.CircleButton.Text = "Find Area of Circle";
            this.CircleButton.UseVisualStyleBackColor = true;
            // 
            // Rectangle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.CircleButton);
            this.Controls.Add(this.TriangleButton);
            this.Controls.Add(this.RAnsLabel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.RBaseLabel);
            this.Controls.Add(this.RHeightText);
            this.Controls.Add(this.RBaseText);
            this.Controls.Add(this.RCalculateButton);
            this.Controls.Add(this.RTitle);
            this.Name = "Rectangle";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label RTitle;
        private System.Windows.Forms.Button RCalculateButton;
        private System.Windows.Forms.TextBox RBaseText;
        private System.Windows.Forms.TextBox RHeightText;
        private System.Windows.Forms.Label RBaseLabel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label RAnsLabel;
        private System.Windows.Forms.Button TriangleButton;
        private System.Windows.Forms.Button CircleButton;
    }
}