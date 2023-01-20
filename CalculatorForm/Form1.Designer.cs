
namespace CalculatorForm
{
    partial class CalculatorForm
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
            this.ResultBox = new System.Windows.Forms.TextBox();
            this.ModButton = new System.Windows.Forms.Button();
            this.CeButton = new System.Windows.Forms.Button();
            this.CButton = new System.Windows.Forms.Button();
            this.BackSpaceButton = new System.Windows.Forms.Button();
            this.DivButton = new System.Windows.Forms.Button();
            this.SqrtButton = new System.Windows.Forms.Button();
            this.PowButton = new System.Windows.Forms.Button();
            this.Button1x = new System.Windows.Forms.Button();
            this.MultiplyButton = new System.Windows.Forms.Button();
            this.Button9 = new System.Windows.Forms.Button();
            this.Button8 = new System.Windows.Forms.Button();
            this.Button7 = new System.Windows.Forms.Button();
            this.SubstractButton = new System.Windows.Forms.Button();
            this.Button6 = new System.Windows.Forms.Button();
            this.Button5 = new System.Windows.Forms.Button();
            this.Button4 = new System.Windows.Forms.Button();
            this.AddButton = new System.Windows.Forms.Button();
            this.Button3 = new System.Windows.Forms.Button();
            this.Button2 = new System.Windows.Forms.Button();
            this.Button1 = new System.Windows.Forms.Button();
            this.RunButton = new System.Windows.Forms.Button();
            this.DotButton = new System.Windows.Forms.Button();
            this.Button0 = new System.Windows.Forms.Button();
            this.SignButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ResultBox
            // 
            this.ResultBox.Location = new System.Drawing.Point(1, 12);
            this.ResultBox.Multiline = true;
            this.ResultBox.Name = "ResultBox";
            this.ResultBox.ReadOnly = true;
            this.ResultBox.Size = new System.Drawing.Size(227, 46);
            this.ResultBox.TabIndex = 0;
            this.ResultBox.Text = "0";
            this.ResultBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // ModButton
            // 
            this.ModButton.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ModButton.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ModButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ModButton.Location = new System.Drawing.Point(1, 63);
            this.ModButton.Margin = new System.Windows.Forms.Padding(0);
            this.ModButton.Name = "ModButton";
            this.ModButton.Size = new System.Drawing.Size(60, 60);
            this.ModButton.TabIndex = 1;
            this.ModButton.Text = "%";
            this.ModButton.UseVisualStyleBackColor = false;
            this.ModButton.Click += new System.EventHandler(this.Buttons_Click);
            // 
            // CeButton
            // 
            this.CeButton.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.CeButton.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.CeButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.CeButton.Location = new System.Drawing.Point(57, 63);
            this.CeButton.Margin = new System.Windows.Forms.Padding(0);
            this.CeButton.Name = "CeButton";
            this.CeButton.Size = new System.Drawing.Size(60, 60);
            this.CeButton.TabIndex = 2;
            this.CeButton.Text = "CE";
            this.CeButton.UseVisualStyleBackColor = false;
            this.CeButton.Click += new System.EventHandler(this.CeButton_Click);
            // 
            // CButton
            // 
            this.CButton.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.CButton.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.CButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.CButton.Location = new System.Drawing.Point(113, 63);
            this.CButton.Margin = new System.Windows.Forms.Padding(0);
            this.CButton.Name = "CButton";
            this.CButton.Size = new System.Drawing.Size(60, 60);
            this.CButton.TabIndex = 3;
            this.CButton.Text = "C";
            this.CButton.UseVisualStyleBackColor = false;
            this.CButton.Click += new System.EventHandler(this.CButton_Click);
            // 
            // BackSpaceButton
            // 
            this.BackSpaceButton.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.BackSpaceButton.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BackSpaceButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BackSpaceButton.Location = new System.Drawing.Point(169, 63);
            this.BackSpaceButton.Margin = new System.Windows.Forms.Padding(0);
            this.BackSpaceButton.Name = "BackSpaceButton";
            this.BackSpaceButton.Size = new System.Drawing.Size(60, 60);
            this.BackSpaceButton.TabIndex = 4;
            this.BackSpaceButton.Text = "<<";
            this.BackSpaceButton.UseVisualStyleBackColor = false;
            // 
            // DivButton
            // 
            this.DivButton.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.DivButton.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.DivButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.DivButton.Location = new System.Drawing.Point(169, 119);
            this.DivButton.Margin = new System.Windows.Forms.Padding(0);
            this.DivButton.Name = "DivButton";
            this.DivButton.Size = new System.Drawing.Size(60, 60);
            this.DivButton.TabIndex = 8;
            this.DivButton.Text = "/";
            this.DivButton.UseVisualStyleBackColor = false;
            this.DivButton.Click += new System.EventHandler(this.Buttons_Click);
            // 
            // SqrtButton
            // 
            this.SqrtButton.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.SqrtButton.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.SqrtButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.SqrtButton.Location = new System.Drawing.Point(113, 119);
            this.SqrtButton.Margin = new System.Windows.Forms.Padding(0);
            this.SqrtButton.Name = "SqrtButton";
            this.SqrtButton.Size = new System.Drawing.Size(60, 60);
            this.SqrtButton.TabIndex = 7;
            this.SqrtButton.Text = "sqrt";
            this.SqrtButton.UseVisualStyleBackColor = false;
            this.SqrtButton.Click += new System.EventHandler(this.Buttons_Click);
            // 
            // PowButton
            // 
            this.PowButton.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.PowButton.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.PowButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.PowButton.Location = new System.Drawing.Point(57, 119);
            this.PowButton.Margin = new System.Windows.Forms.Padding(0);
            this.PowButton.Name = "PowButton";
            this.PowButton.Size = new System.Drawing.Size(60, 60);
            this.PowButton.TabIndex = 6;
            this.PowButton.Text = "x^2";
            this.PowButton.UseVisualStyleBackColor = false;
            this.PowButton.Click += new System.EventHandler(this.Buttons_Click);
            // 
            // Button1x
            // 
            this.Button1x.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Button1x.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Button1x.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Button1x.Location = new System.Drawing.Point(1, 119);
            this.Button1x.Margin = new System.Windows.Forms.Padding(0);
            this.Button1x.Name = "Button1x";
            this.Button1x.Size = new System.Drawing.Size(60, 60);
            this.Button1x.TabIndex = 5;
            this.Button1x.Text = "1/x";
            this.Button1x.UseVisualStyleBackColor = false;
            this.Button1x.Click += new System.EventHandler(this.Buttons_Click);
            // 
            // MultiplyButton
            // 
            this.MultiplyButton.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.MultiplyButton.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.MultiplyButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.MultiplyButton.Location = new System.Drawing.Point(169, 176);
            this.MultiplyButton.Margin = new System.Windows.Forms.Padding(0);
            this.MultiplyButton.Name = "MultiplyButton";
            this.MultiplyButton.Size = new System.Drawing.Size(60, 60);
            this.MultiplyButton.TabIndex = 12;
            this.MultiplyButton.Text = "*";
            this.MultiplyButton.UseVisualStyleBackColor = false;
            this.MultiplyButton.Click += new System.EventHandler(this.Buttons_Click);
            // 
            // Button9
            // 
            this.Button9.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Button9.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Button9.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Button9.Location = new System.Drawing.Point(113, 176);
            this.Button9.Margin = new System.Windows.Forms.Padding(0);
            this.Button9.Name = "Button9";
            this.Button9.Size = new System.Drawing.Size(60, 60);
            this.Button9.TabIndex = 11;
            this.Button9.Text = "9";
            this.Button9.UseVisualStyleBackColor = false;
            this.Button9.Click += new System.EventHandler(this.Buttons_Click);
            // 
            // Button8
            // 
            this.Button8.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Button8.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Button8.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Button8.Location = new System.Drawing.Point(57, 176);
            this.Button8.Margin = new System.Windows.Forms.Padding(0);
            this.Button8.Name = "Button8";
            this.Button8.Size = new System.Drawing.Size(60, 60);
            this.Button8.TabIndex = 10;
            this.Button8.Text = "8";
            this.Button8.UseVisualStyleBackColor = false;
            this.Button8.Click += new System.EventHandler(this.Buttons_Click);
            // 
            // Button7
            // 
            this.Button7.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Button7.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Button7.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Button7.Location = new System.Drawing.Point(1, 176);
            this.Button7.Margin = new System.Windows.Forms.Padding(0);
            this.Button7.Name = "Button7";
            this.Button7.Size = new System.Drawing.Size(60, 60);
            this.Button7.TabIndex = 9;
            this.Button7.Text = "7";
            this.Button7.UseVisualStyleBackColor = false;
            this.Button7.Click += new System.EventHandler(this.Buttons_Click);
            // 
            // SubstractButton
            // 
            this.SubstractButton.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.SubstractButton.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.SubstractButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.SubstractButton.Location = new System.Drawing.Point(169, 232);
            this.SubstractButton.Margin = new System.Windows.Forms.Padding(0);
            this.SubstractButton.Name = "SubstractButton";
            this.SubstractButton.Size = new System.Drawing.Size(60, 60);
            this.SubstractButton.TabIndex = 16;
            this.SubstractButton.Text = "-";
            this.SubstractButton.UseVisualStyleBackColor = false;
            this.SubstractButton.Click += new System.EventHandler(this.Buttons_Click);
            // 
            // Button6
            // 
            this.Button6.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Button6.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Button6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Button6.Location = new System.Drawing.Point(113, 232);
            this.Button6.Margin = new System.Windows.Forms.Padding(0);
            this.Button6.Name = "Button6";
            this.Button6.Size = new System.Drawing.Size(60, 60);
            this.Button6.TabIndex = 15;
            this.Button6.Text = "6";
            this.Button6.UseVisualStyleBackColor = false;
            this.Button6.Click += new System.EventHandler(this.Buttons_Click);
            // 
            // Button5
            // 
            this.Button5.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Button5.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Button5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Button5.Location = new System.Drawing.Point(57, 232);
            this.Button5.Margin = new System.Windows.Forms.Padding(0);
            this.Button5.Name = "Button5";
            this.Button5.Size = new System.Drawing.Size(60, 60);
            this.Button5.TabIndex = 14;
            this.Button5.Text = "5";
            this.Button5.UseVisualStyleBackColor = false;
            this.Button5.Click += new System.EventHandler(this.Buttons_Click);
            // 
            // Button4
            // 
            this.Button4.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Button4.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Button4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Button4.Location = new System.Drawing.Point(1, 232);
            this.Button4.Margin = new System.Windows.Forms.Padding(0);
            this.Button4.Name = "Button4";
            this.Button4.Size = new System.Drawing.Size(60, 60);
            this.Button4.TabIndex = 13;
            this.Button4.Text = "4";
            this.Button4.UseVisualStyleBackColor = false;
            this.Button4.Click += new System.EventHandler(this.Buttons_Click);
            // 
            // AddButton
            // 
            this.AddButton.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.AddButton.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.AddButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.AddButton.Location = new System.Drawing.Point(169, 288);
            this.AddButton.Margin = new System.Windows.Forms.Padding(0);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(60, 60);
            this.AddButton.TabIndex = 20;
            this.AddButton.Text = "+";
            this.AddButton.UseVisualStyleBackColor = false;
            this.AddButton.Click += new System.EventHandler(this.Buttons_Click);
            // 
            // Button3
            // 
            this.Button3.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Button3.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Button3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Button3.Location = new System.Drawing.Point(113, 288);
            this.Button3.Margin = new System.Windows.Forms.Padding(0);
            this.Button3.Name = "Button3";
            this.Button3.Size = new System.Drawing.Size(60, 60);
            this.Button3.TabIndex = 19;
            this.Button3.Text = "3";
            this.Button3.UseVisualStyleBackColor = false;
            this.Button3.Click += new System.EventHandler(this.Buttons_Click);
            // 
            // Button2
            // 
            this.Button2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Button2.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Button2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Button2.Location = new System.Drawing.Point(57, 288);
            this.Button2.Margin = new System.Windows.Forms.Padding(0);
            this.Button2.Name = "Button2";
            this.Button2.Size = new System.Drawing.Size(60, 60);
            this.Button2.TabIndex = 18;
            this.Button2.Text = "2";
            this.Button2.UseVisualStyleBackColor = false;
            this.Button2.Click += new System.EventHandler(this.Buttons_Click);
            // 
            // Button1
            // 
            this.Button1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Button1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Button1.Location = new System.Drawing.Point(1, 288);
            this.Button1.Margin = new System.Windows.Forms.Padding(0);
            this.Button1.Name = "Button1";
            this.Button1.Size = new System.Drawing.Size(60, 60);
            this.Button1.TabIndex = 17;
            this.Button1.Text = "1";
            this.Button1.UseVisualStyleBackColor = false;
            this.Button1.Click += new System.EventHandler(this.Buttons_Click);
            // 
            // RunButton
            // 
            this.RunButton.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.RunButton.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.RunButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.RunButton.Location = new System.Drawing.Point(169, 344);
            this.RunButton.Margin = new System.Windows.Forms.Padding(0);
            this.RunButton.Name = "RunButton";
            this.RunButton.Size = new System.Drawing.Size(60, 60);
            this.RunButton.TabIndex = 24;
            this.RunButton.Text = "=";
            this.RunButton.UseVisualStyleBackColor = false;
            this.RunButton.Click += new System.EventHandler(this.RunButton_Click);
            // 
            // DotButton
            // 
            this.DotButton.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.DotButton.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.DotButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.DotButton.Location = new System.Drawing.Point(113, 344);
            this.DotButton.Margin = new System.Windows.Forms.Padding(0);
            this.DotButton.Name = "DotButton";
            this.DotButton.Size = new System.Drawing.Size(60, 60);
            this.DotButton.TabIndex = 23;
            this.DotButton.Text = ",";
            this.DotButton.UseVisualStyleBackColor = false;
            this.DotButton.Click += new System.EventHandler(this.Buttons_Click);
            // 
            // Button0
            // 
            this.Button0.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Button0.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Button0.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Button0.Location = new System.Drawing.Point(57, 344);
            this.Button0.Margin = new System.Windows.Forms.Padding(0);
            this.Button0.Name = "Button0";
            this.Button0.Size = new System.Drawing.Size(60, 60);
            this.Button0.TabIndex = 22;
            this.Button0.Text = "0";
            this.Button0.UseVisualStyleBackColor = false;
            this.Button0.Click += new System.EventHandler(this.Buttons_Click);
            // 
            // SignButton
            // 
            this.SignButton.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.SignButton.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.SignButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.SignButton.Location = new System.Drawing.Point(1, 344);
            this.SignButton.Margin = new System.Windows.Forms.Padding(0);
            this.SignButton.Name = "SignButton";
            this.SignButton.Size = new System.Drawing.Size(60, 60);
            this.SignButton.TabIndex = 21;
            this.SignButton.Text = "+/-";
            this.SignButton.UseVisualStyleBackColor = false;
            this.SignButton.Click += new System.EventHandler(this.SignButton_Click);
            // 
            // CalculatorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(229, 404);
            this.Controls.Add(this.RunButton);
            this.Controls.Add(this.DotButton);
            this.Controls.Add(this.Button0);
            this.Controls.Add(this.SignButton);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.Button3);
            this.Controls.Add(this.Button2);
            this.Controls.Add(this.Button1);
            this.Controls.Add(this.SubstractButton);
            this.Controls.Add(this.Button6);
            this.Controls.Add(this.Button5);
            this.Controls.Add(this.Button4);
            this.Controls.Add(this.MultiplyButton);
            this.Controls.Add(this.Button9);
            this.Controls.Add(this.Button8);
            this.Controls.Add(this.Button7);
            this.Controls.Add(this.DivButton);
            this.Controls.Add(this.SqrtButton);
            this.Controls.Add(this.PowButton);
            this.Controls.Add(this.Button1x);
            this.Controls.Add(this.BackSpaceButton);
            this.Controls.Add(this.CButton);
            this.Controls.Add(this.CeButton);
            this.Controls.Add(this.ModButton);
            this.Controls.Add(this.ResultBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximumSize = new System.Drawing.Size(245, 443);
            this.MinimumSize = new System.Drawing.Size(245, 443);
            this.Name = "CalculatorForm";
            this.Text = "Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox ResultBox;
        private Button ModButton;
        private Button CeButton;
        private Button CButton;
        private Button BackSpaceButton;
        private Button DivButton;
        private Button SqrtButton;
        private Button PowButton;
        private Button Button1x;
        private Button MultiplyButton;
        private Button Button9;
        private Button Button8;
        private Button Button7;
        private Button SubstractButton;
        private Button Button6;
        private Button Button5;
        private Button Button4;
        private Button AddButton;
        private Button Button3;
        private Button Button2;
        private Button Button1;
        private Button RunButton;
        private Button DotButton;
        private Button Button0;
        private Button SignButton;
    }
}