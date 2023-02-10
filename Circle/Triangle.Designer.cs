namespace Circle
{
    partial class Triangle
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
            this.TTitleLabel = new System.Windows.Forms.Label();
            this.TBaseLabel = new System.Windows.Forms.Label();
            this.THeightLabel = new System.Windows.Forms.Label();
            this.Calculate = new System.Windows.Forms.Button();
            this.TAnsLabel = new System.Windows.Forms.Label();
            this.TBaseText = new System.Windows.Forms.TextBox();
            this.THeightText = new System.Windows.Forms.TextBox();
            this.CircleButton = new System.Windows.Forms.Button();
            this.RectangleButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TTitleLabel
            // 
            this.TTitleLabel.AutoSize = true;
            this.TTitleLabel.Location = new System.Drawing.Point(358, 13);
            this.TTitleLabel.Name = "TTitleLabel";
            this.TTitleLabel.Size = new System.Drawing.Size(91, 13);
            this.TTitleLabel.TabIndex = 0;
            this.TTitleLabel.Text = "Area of a Triangle";
            // 
            // TBaseLabel
            // 
            this.TBaseLabel.AutoSize = true;
            this.TBaseLabel.Location = new System.Drawing.Point(198, 119);
            this.TBaseLabel.Name = "TBaseLabel";
            this.TBaseLabel.Size = new System.Drawing.Size(127, 13);
            this.TBaseLabel.TabIndex = 1;
            this.TBaseLabel.Text = "The Base of the Triangle:";
            // 
            // THeightLabel
            // 
            this.THeightLabel.AutoSize = true;
            this.THeightLabel.Location = new System.Drawing.Point(193, 155);
            this.THeightLabel.Name = "THeightLabel";
            this.THeightLabel.Size = new System.Drawing.Size(132, 13);
            this.THeightLabel.TabIndex = 2;
            this.THeightLabel.Text = "The height of the Triangle:";
            // 
            // Calculate
            // 
            this.Calculate.Location = new System.Drawing.Point(561, 145);
            this.Calculate.Name = "Calculate";
            this.Calculate.Size = new System.Drawing.Size(75, 23);
            this.Calculate.TabIndex = 3;
            this.Calculate.Text = "Calculate";
            this.Calculate.UseVisualStyleBackColor = true;
            this.Calculate.Click += new System.EventHandler(this.Calculate_Click);
            // 
            // TAnsLabel
            // 
            this.TAnsLabel.AutoSize = true;
            this.TAnsLabel.Location = new System.Drawing.Point(361, 268);
            this.TAnsLabel.Name = "TAnsLabel";
            this.TAnsLabel.Size = new System.Drawing.Size(91, 13);
            this.TAnsLabel.TabIndex = 4;
            this.TAnsLabel.Text = "______________";
            // 
            // TBaseText
            // 
            this.TBaseText.Location = new System.Drawing.Point(392, 111);
            this.TBaseText.Name = "TBaseText";
            this.TBaseText.Size = new System.Drawing.Size(100, 20);
            this.TBaseText.TabIndex = 5;
            // 
            // THeightText
            // 
            this.THeightText.Location = new System.Drawing.Point(392, 155);
            this.THeightText.Name = "THeightText";
            this.THeightText.Size = new System.Drawing.Size(100, 20);
            this.THeightText.TabIndex = 6;
            // 
            // CircleButton
            // 
            this.CircleButton.Location = new System.Drawing.Point(135, 375);
            this.CircleButton.Name = "CircleButton";
            this.CircleButton.Size = new System.Drawing.Size(140, 23);
            this.CircleButton.TabIndex = 7;
            this.CircleButton.Text = "Find area of a Circle";
            this.CircleButton.UseVisualStyleBackColor = true;
            this.CircleButton.Click += new System.EventHandler(this.CircleButton_Click);
            // 
            // RectangleButton
            // 
            this.RectangleButton.Location = new System.Drawing.Point(550, 375);
            this.RectangleButton.Name = "RectangleButton";
            this.RectangleButton.Size = new System.Drawing.Size(149, 23);
            this.RectangleButton.TabIndex = 8;
            this.RectangleButton.Text = "Find area of Rectangle";
            this.RectangleButton.UseVisualStyleBackColor = true;
            this.RectangleButton.Click += new System.EventHandler(this.TriangleButton_Click);
            // 
            // Triangle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.RectangleButton);
            this.Controls.Add(this.CircleButton);
            this.Controls.Add(this.THeightText);
            this.Controls.Add(this.TBaseText);
            this.Controls.Add(this.TAnsLabel);
            this.Controls.Add(this.Calculate);
            this.Controls.Add(this.THeightLabel);
            this.Controls.Add(this.TBaseLabel);
            this.Controls.Add(this.TTitleLabel);
            this.Name = "Triangle";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label TTitleLabel;
        private System.Windows.Forms.Label TBaseLabel;
        private System.Windows.Forms.Label THeightLabel;
        private System.Windows.Forms.Button Calculate;
        private System.Windows.Forms.Label TAnsLabel;
        private System.Windows.Forms.TextBox TBaseText;
        private System.Windows.Forms.TextBox THeightText;
        private System.Windows.Forms.Button CircleButton;
        private System.Windows.Forms.Button RectangleButton;
    }
}