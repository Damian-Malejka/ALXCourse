namespace StartingDayApp
{
    partial class Form1
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
            this.ShowAllInvoicesButton = new System.Windows.Forms.Button();
            this.LogBox = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.AmountAddBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.UserFirstNameAddBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.UserLastNameAddBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.ClientNIPAddBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.AddBookButton = new System.Windows.Forms.Button();
            this.SeriesNumberAddBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.ClientCompanyNameAddBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.labelbook = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ShowAllInvoicesButton
            // 
            this.ShowAllInvoicesButton.Location = new System.Drawing.Point(28, 203);
            this.ShowAllInvoicesButton.Name = "ShowAllInvoicesButton";
            this.ShowAllInvoicesButton.Size = new System.Drawing.Size(155, 23);
            this.ShowAllInvoicesButton.TabIndex = 24;
            this.ShowAllInvoicesButton.Text = "Show All Invoices";
            this.ShowAllInvoicesButton.UseVisualStyleBackColor = true;
            this.ShowAllInvoicesButton.Click += new System.EventHandler(this.ShowAllInvoicesButton_Click);
            // 
            // LogBox
            // 
            this.LogBox.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.LogBox.Location = new System.Drawing.Point(28, 19);
            this.LogBox.Multiline = true;
            this.LogBox.Name = "LogBox";
            this.LogBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.LogBox.Size = new System.Drawing.Size(523, 178);
            this.LogBox.TabIndex = 23;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.AmountAddBox);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.UserFirstNameAddBox);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.UserLastNameAddBox);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.ClientNIPAddBox);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.AddBookButton);
            this.groupBox1.Controls.Add(this.SeriesNumberAddBox);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.ClientCompanyNameAddBox);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(589, 48);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(155, 358);
            this.groupBox1.TabIndex = 22;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Add Invoice";
            // 
            // AmountAddBox
            // 
            this.AmountAddBox.Location = new System.Drawing.Point(6, 270);
            this.AmountAddBox.Name = "AmountAddBox";
            this.AmountAddBox.Size = new System.Drawing.Size(143, 23);
            this.AmountAddBox.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 252);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 15);
            this.label4.TabIndex = 13;
            this.label4.Text = "Amount";
            // 
            // UserFirstNameAddBox
            // 
            this.UserFirstNameAddBox.Location = new System.Drawing.Point(6, 178);
            this.UserFirstNameAddBox.Name = "UserFirstNameAddBox";
            this.UserFirstNameAddBox.Size = new System.Drawing.Size(143, 23);
            this.UserFirstNameAddBox.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 160);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 15);
            this.label5.TabIndex = 11;
            this.label5.Text = "User First Name";
            // 
            // UserLastNameAddBox
            // 
            this.UserLastNameAddBox.Location = new System.Drawing.Point(6, 222);
            this.UserLastNameAddBox.Name = "UserLastNameAddBox";
            this.UserLastNameAddBox.Size = new System.Drawing.Size(143, 23);
            this.UserLastNameAddBox.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 204);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(89, 15);
            this.label6.TabIndex = 10;
            this.label6.Text = "User Last Name";
            // 
            // ClientNIPAddBox
            // 
            this.ClientNIPAddBox.Location = new System.Drawing.Point(6, 131);
            this.ClientNIPAddBox.Name = "ClientNIPAddBox";
            this.ClientNIPAddBox.Size = new System.Drawing.Size(143, 23);
            this.ClientNIPAddBox.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 113);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 15);
            this.label3.TabIndex = 7;
            this.label3.Text = "Client NIP";
            // 
            // AddBookButton
            // 
            this.AddBookButton.Location = new System.Drawing.Point(6, 311);
            this.AddBookButton.Name = "AddBookButton";
            this.AddBookButton.Size = new System.Drawing.Size(143, 23);
            this.AddBookButton.TabIndex = 5;
            this.AddBookButton.Text = "Click to Add Invoice";
            this.AddBookButton.UseVisualStyleBackColor = true;
            this.AddBookButton.Click += new System.EventHandler(this.AddBookButton_Click);
            // 
            // SeriesNumberAddBox
            // 
            this.SeriesNumberAddBox.Location = new System.Drawing.Point(6, 39);
            this.SeriesNumberAddBox.Name = "SeriesNumberAddBox";
            this.SeriesNumberAddBox.Size = new System.Drawing.Size(143, 23);
            this.SeriesNumberAddBox.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "Series Number";
            // 
            // ClientCompanyNameAddBox
            // 
            this.ClientCompanyNameAddBox.Location = new System.Drawing.Point(6, 83);
            this.ClientCompanyNameAddBox.Name = "ClientCompanyNameAddBox";
            this.ClientCompanyNameAddBox.Size = new System.Drawing.Size(143, 23);
            this.ClientCompanyNameAddBox.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "Client Company Name";
            // 
            // labelbook
            // 
            this.labelbook.AutoSize = true;
            this.labelbook.Location = new System.Drawing.Point(28, 1);
            this.labelbook.Name = "labelbook";
            this.labelbook.Size = new System.Drawing.Size(47, 15);
            this.labelbook.TabIndex = 25;
            this.labelbook.Text = "LogBox";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 465);
            this.Controls.Add(this.labelbook);
            this.Controls.Add(this.ShowAllInvoicesButton);
            this.Controls.Add(this.LogBox);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button ShowAllInvoicesButton;
        private TextBox LogBox;
        private GroupBox groupBox1;
        private TextBox ClientNIPAddBox;
        private Label label3;
        private Button AddBookButton;
        private TextBox SeriesNumberAddBox;
        private Label label2;
        private TextBox ClientCompanyNameAddBox;
        private Label label1;
        private Label labelbook;
        private TextBox AmountAddBox;
        private Label label4;
        private TextBox UserFirstNameAddBox;
        private Label label5;
        private TextBox UserLastNameAddBox;
        private Label label6;
    }
}