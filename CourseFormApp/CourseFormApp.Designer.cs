namespace CourseFormApp
{
    partial class CourseFormApp
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.DoNotButton1 = new System.Windows.Forms.Button();
            this.RestartButton = new System.Windows.Forms.Button();
            this.ExitButton = new System.Windows.Forms.Button();
            this.HeightBox = new System.Windows.Forms.TextBox();
            this.RunButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.XNumberBox = new System.Windows.Forms.TextBox();
            this.YNumberBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.ResultBox = new System.Windows.Forms.TextBox();
            this.CalculateButton = new System.Windows.Forms.Button();
            this.AddButton = new System.Windows.Forms.RadioButton();
            this.SubstractButton = new System.Windows.Forms.RadioButton();
            this.MultipleButton = new System.Windows.Forms.RadioButton();
            this.DivideButton = new System.Windows.Forms.RadioButton();
            this.LogBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // DoNotButton1
            // 
            this.DoNotButton1.Cursor = System.Windows.Forms.Cursors.No;
            this.DoNotButton1.Location = new System.Drawing.Point(83, 29);
            this.DoNotButton1.Name = "DoNotButton1";
            this.DoNotButton1.Size = new System.Drawing.Size(203, 94);
            this.DoNotButton1.TabIndex = 0;
            this.DoNotButton1.Text = "Do not button1!";
            this.DoNotButton1.UseVisualStyleBackColor = true;
            this.DoNotButton1.Click += new System.EventHandler(this.DoNotButton1_Click);
            // 
            // RestartButton
            // 
            this.RestartButton.Location = new System.Drawing.Point(528, 358);
            this.RestartButton.Name = "RestartButton";
            this.RestartButton.Size = new System.Drawing.Size(127, 71);
            this.RestartButton.TabIndex = 1;
            this.RestartButton.Text = "Restart";
            this.RestartButton.UseVisualStyleBackColor = true;
            this.RestartButton.Click += new System.EventHandler(this.RestartButton_Click);
            // 
            // ExitButton
            // 
            this.ExitButton.Location = new System.Drawing.Point(661, 358);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(127, 71);
            this.ExitButton.TabIndex = 2;
            this.ExitButton.Text = "Exit";
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // HeightBox
            // 
            this.HeightBox.Location = new System.Drawing.Point(541, 99);
            this.HeightBox.Name = "HeightBox";
            this.HeightBox.Size = new System.Drawing.Size(162, 23);
            this.HeightBox.TabIndex = 5;
            // 
            // RunButton
            // 
            this.RunButton.Location = new System.Drawing.Point(561, 136);
            this.RunButton.Name = "RunButton";
            this.RunButton.Size = new System.Drawing.Size(75, 23);
            this.RunButton.TabIndex = 6;
            this.RunButton.Text = "Run";
            this.RunButton.UseVisualStyleBackColor = true;
            this.RunButton.Click += new System.EventHandler(this.RunButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(547, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 15);
            this.label1.TabIndex = 7;
            this.label1.Text = "Enter Your Height";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(60, 137);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 15);
            this.label2.TabIndex = 8;
            this.label2.Text = "X Number";
            // 
            // XNumberBox
            // 
            this.XNumberBox.Location = new System.Drawing.Point(60, 155);
            this.XNumberBox.Name = "XNumberBox";
            this.XNumberBox.Size = new System.Drawing.Size(100, 23);
            this.XNumberBox.TabIndex = 9;
            // 
            // YNumberBox
            // 
            this.YNumberBox.Location = new System.Drawing.Point(60, 215);
            this.YNumberBox.Name = "YNumberBox";
            this.YNumberBox.Size = new System.Drawing.Size(100, 23);
            this.YNumberBox.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(60, 197);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 15);
            this.label3.TabIndex = 10;
            this.label3.Text = "Y Number";
            // 
            // ResultBox
            // 
            this.ResultBox.Location = new System.Drawing.Point(54, 383);
            this.ResultBox.Name = "ResultBox";
            this.ResultBox.ReadOnly = true;
            this.ResultBox.Size = new System.Drawing.Size(100, 23);
            this.ResultBox.TabIndex = 12;
            // 
            // CalculateButton
            // 
            this.CalculateButton.Location = new System.Drawing.Point(54, 354);
            this.CalculateButton.Name = "CalculateButton";
            this.CalculateButton.Size = new System.Drawing.Size(75, 23);
            this.CalculateButton.TabIndex = 13;
            this.CalculateButton.Text = "Calculate";
            this.CalculateButton.UseVisualStyleBackColor = true;
            this.CalculateButton.Click += new System.EventHandler(this.CalculateButton_Click);
            // 
            // AddButton
            // 
            this.AddButton.AutoSize = true;
            this.AddButton.Checked = true;
            this.AddButton.Location = new System.Drawing.Point(60, 244);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(33, 19);
            this.AddButton.TabIndex = 14;
            this.AddButton.TabStop = true;
            this.AddButton.Text = "+";
            this.AddButton.UseVisualStyleBackColor = true;
            // 
            // SubstractButton
            // 
            this.SubstractButton.AutoSize = true;
            this.SubstractButton.Location = new System.Drawing.Point(60, 269);
            this.SubstractButton.Name = "SubstractButton";
            this.SubstractButton.Size = new System.Drawing.Size(30, 19);
            this.SubstractButton.TabIndex = 15;
            this.SubstractButton.Text = "-";
            this.SubstractButton.UseVisualStyleBackColor = true;
            // 
            // MultipleButton
            // 
            this.MultipleButton.AutoSize = true;
            this.MultipleButton.Location = new System.Drawing.Point(60, 294);
            this.MultipleButton.Name = "MultipleButton";
            this.MultipleButton.Size = new System.Drawing.Size(30, 19);
            this.MultipleButton.TabIndex = 16;
            this.MultipleButton.Text = "*";
            this.MultipleButton.UseVisualStyleBackColor = true;
            // 
            // DivideButton
            // 
            this.DivideButton.AutoSize = true;
            this.DivideButton.Location = new System.Drawing.Point(60, 319);
            this.DivideButton.Name = "DivideButton";
            this.DivideButton.Size = new System.Drawing.Size(30, 19);
            this.DivideButton.TabIndex = 17;
            this.DivideButton.Text = "/";
            this.DivideButton.UseVisualStyleBackColor = true;
            // 
            // LogBox
            // 
            this.LogBox.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.LogBox.Location = new System.Drawing.Point(220, 155);
            this.LogBox.Multiline = true;
            this.LogBox.Name = "LogBox";
            this.LogBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.LogBox.Size = new System.Drawing.Size(228, 133);
            this.LogBox.TabIndex = 18;
            // 
            // CourseFormApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.LogBox);
            this.Controls.Add(this.DivideButton);
            this.Controls.Add(this.MultipleButton);
            this.Controls.Add(this.SubstractButton);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.CalculateButton);
            this.Controls.Add(this.ResultBox);
            this.Controls.Add(this.YNumberBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.XNumberBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.RunButton);
            this.Controls.Add(this.HeightBox);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.RestartButton);
            this.Controls.Add(this.DoNotButton1);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Name = "CourseFormApp";
            this.Text = "Alx Course Form App";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button DoNotButton1;
        private Button RestartButton;
        private Button ExitButton;
        private TextBox HeightBox;
        private Button RunButton;
        private Label label1;
        private Label label2;
        private TextBox XNumberBox;
        private TextBox YNumberBox;
        private Label label3;
        private TextBox ResultBox;
        private Button CalculateButton;
        private RadioButton AddButton;
        private RadioButton SubstractButton;
        private RadioButton MultipleButton;
        private RadioButton DivideButton;
        private TextBox LogBox;
    }
}