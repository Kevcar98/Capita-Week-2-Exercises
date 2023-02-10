namespace Circle
{
    partial class Circle
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
            this.Calculate = new System.Windows.Forms.Button();
            this.RadiusText = new System.Windows.Forms.TextBox();
            this.RadiusLabel = new System.Windows.Forms.Label();
            this.RadiusL = new System.Windows.Forms.Label();
            this.Title = new System.Windows.Forms.Label();
            this.TriangleB = new System.Windows.Forms.Button();
            this.RectangleB = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Calculate
            // 
            this.Calculate.Location = new System.Drawing.Point(502, 153);
            this.Calculate.Name = "Calculate";
            this.Calculate.Size = new System.Drawing.Size(75, 23);
            this.Calculate.TabIndex = 0;
            this.Calculate.Text = "Calculate";
            this.Calculate.UseVisualStyleBackColor = true;
            this.Calculate.Click += new System.EventHandler(this.Calculate_Click);
            // 
            // RadiusText
            // 
            this.RadiusText.Location = new System.Drawing.Point(345, 156);
            this.RadiusText.Name = "RadiusText";
            this.RadiusText.Size = new System.Drawing.Size(100, 20);
            this.RadiusText.TabIndex = 3;
            // 
            // RadiusLabel
            // 
            this.RadiusLabel.AutoSize = true;
            this.RadiusLabel.Location = new System.Drawing.Point(228, 159);
            this.RadiusLabel.Name = "RadiusLabel";
            this.RadiusLabel.Size = new System.Drawing.Size(43, 13);
            this.RadiusLabel.TabIndex = 4;
            this.RadiusLabel.Text = "Radius:";
            // 
            // RadiusL
            // 
            this.RadiusL.AutoSize = true;
            this.RadiusL.Location = new System.Drawing.Point(342, 237);
            this.RadiusL.Name = "RadiusL";
            this.RadiusL.Size = new System.Drawing.Size(73, 13);
            this.RadiusL.TabIndex = 5;
            this.RadiusL.Text = "___________";
            // 
            // Title
            // 
            this.Title.AutoSize = true;
            this.Title.Location = new System.Drawing.Point(345, 27);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(108, 13);
            this.Title.TabIndex = 6;
            this.Title.Text = "Circle Area Calculator";
            // 
            // TriangleB
            // 
            this.TriangleB.Location = new System.Drawing.Point(151, 392);
            this.TriangleB.Name = "TriangleB";
            this.TriangleB.Size = new System.Drawing.Size(120, 23);
            this.TriangleB.TabIndex = 7;
            this.TriangleB.Text = "Find Area of Triangle";
            this.TriangleB.UseVisualStyleBackColor = true;
            this.TriangleB.Click += new System.EventHandler(this.TriangleB_Click);
            // 
            // RectangleB
            // 
            this.RectangleB.Location = new System.Drawing.Point(515, 392);
            this.RectangleB.Name = "RectangleB";
            this.RectangleB.Size = new System.Drawing.Size(136, 23);
            this.RectangleB.TabIndex = 8;
            this.RectangleB.Text = "Find Area of Rectangle";
            this.RectangleB.UseVisualStyleBackColor = true;
            this.RectangleB.Click += new System.EventHandler(this.RectangleB_Click);
            // 
            // Circle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.RectangleB);
            this.Controls.Add(this.TriangleB);
            this.Controls.Add(this.Title);
            this.Controls.Add(this.RadiusL);
            this.Controls.Add(this.RadiusLabel);
            this.Controls.Add(this.RadiusText);
            this.Controls.Add(this.Calculate);
            this.Name = "Circle";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Calculate;
        private System.Windows.Forms.TextBox RadiusText;
        private System.Windows.Forms.Label RadiusLabel;
        private System.Windows.Forms.Label RadiusL;
        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.Button TriangleB;
        private System.Windows.Forms.Button RectangleB;
    }
}

