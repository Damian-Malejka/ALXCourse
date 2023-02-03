namespace LibraryDataBaseApp
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
            this.TitleAddBox = new System.Windows.Forms.TextBox();
            this.AuthorFirstNameAddBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.AuthorLastNameAddBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.AddBookButton = new System.Windows.Forms.Button();
            this.LogBox = new System.Windows.Forms.TextBox();
            this.labelbook = new System.Windows.Forms.Label();
            this.ShowAllBooksButton = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.ClientLastNameAddBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.AddClientButton = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.ClientFirstNameAddBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.ClientIdTransactionBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.AddTransactionButton = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.BookIdTransactionBox = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.ShowAllTransactionsButton = new System.Windows.Forms.Button();
            this.ShowAllClientsButton = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.RemoveTransactionButton = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.IdTransactionRemoveBox = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // TitleAddBox
            // 
            this.TitleAddBox.Location = new System.Drawing.Point(6, 39);
            this.TitleAddBox.Name = "TitleAddBox";
            this.TitleAddBox.Size = new System.Drawing.Size(143, 23);
            this.TitleAddBox.TabIndex = 1;
            // 
            // AuthorFirstNameAddBox
            // 
            this.AuthorFirstNameAddBox.Location = new System.Drawing.Point(6, 83);
            this.AuthorFirstNameAddBox.Name = "AuthorFirstNameAddBox";
            this.AuthorFirstNameAddBox.Size = new System.Drawing.Size(143, 23);
            this.AuthorFirstNameAddBox.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "Author First Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "Title";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.AuthorLastNameAddBox);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.AddBookButton);
            this.groupBox1.Controls.Add(this.TitleAddBox);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.AuthorFirstNameAddBox);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 250);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(155, 188);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Add Book";
            // 
            // AuthorLastNameAddBox
            // 
            this.AuthorLastNameAddBox.Location = new System.Drawing.Point(6, 131);
            this.AuthorLastNameAddBox.Name = "AuthorLastNameAddBox";
            this.AuthorLastNameAddBox.Size = new System.Drawing.Size(143, 23);
            this.AuthorLastNameAddBox.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 113);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 15);
            this.label3.TabIndex = 7;
            this.label3.Text = "Author Last Name";
            // 
            // AddBookButton
            // 
            this.AddBookButton.Location = new System.Drawing.Point(6, 160);
            this.AddBookButton.Name = "AddBookButton";
            this.AddBookButton.Size = new System.Drawing.Size(143, 23);
            this.AddBookButton.TabIndex = 5;
            this.AddBookButton.Text = "Click to Add Book";
            this.AddBookButton.UseVisualStyleBackColor = true;
            this.AddBookButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // LogBox
            // 
            this.LogBox.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.LogBox.Location = new System.Drawing.Point(12, 30);
            this.LogBox.Multiline = true;
            this.LogBox.Name = "LogBox";
            this.LogBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.LogBox.Size = new System.Drawing.Size(331, 178);
            this.LogBox.TabIndex = 19;
            // 
            // labelbook
            // 
            this.labelbook.AutoSize = true;
            this.labelbook.Location = new System.Drawing.Point(12, 15);
            this.labelbook.Name = "labelbook";
            this.labelbook.Size = new System.Drawing.Size(47, 15);
            this.labelbook.TabIndex = 20;
            this.labelbook.Text = "LogBox";
            // 
            // ShowAllBooksButton
            // 
            this.ShowAllBooksButton.Location = new System.Drawing.Point(12, 221);
            this.ShowAllBooksButton.Name = "ShowAllBooksButton";
            this.ShowAllBooksButton.Size = new System.Drawing.Size(155, 23);
            this.ShowAllBooksButton.TabIndex = 21;
            this.ShowAllBooksButton.Text = "Show All Books";
            this.ShowAllBooksButton.UseVisualStyleBackColor = true;
            this.ShowAllBooksButton.Click += new System.EventHandler(this.ShowAllBooksButton_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.ClientLastNameAddBox);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.AddClientButton);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.ClientFirstNameAddBox);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Location = new System.Drawing.Point(173, 297);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(155, 141);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Add Client";
            // 
            // ClientLastNameAddBox
            // 
            this.ClientLastNameAddBox.Location = new System.Drawing.Point(6, 85);
            this.ClientLastNameAddBox.Name = "ClientLastNameAddBox";
            this.ClientLastNameAddBox.Size = new System.Drawing.Size(143, 23);
            this.ClientLastNameAddBox.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 67);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 15);
            this.label4.TabIndex = 7;
            this.label4.Text = "Client Last Name";
            // 
            // AddClientButton
            // 
            this.AddClientButton.Location = new System.Drawing.Point(6, 114);
            this.AddClientButton.Name = "AddClientButton";
            this.AddClientButton.Size = new System.Drawing.Size(143, 23);
            this.AddClientButton.TabIndex = 5;
            this.AddClientButton.Text = "Click to Add Client";
            this.AddClientButton.UseVisualStyleBackColor = true;
            this.AddClientButton.Click += new System.EventHandler(this.AddClientButton_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 21);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 15);
            this.label5.TabIndex = 4;
            // 
            // ClientFirstNameAddBox
            // 
            this.ClientFirstNameAddBox.Location = new System.Drawing.Point(6, 37);
            this.ClientFirstNameAddBox.Name = "ClientFirstNameAddBox";
            this.ClientFirstNameAddBox.Size = new System.Drawing.Size(143, 23);
            this.ClientFirstNameAddBox.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 19);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(98, 15);
            this.label6.TabIndex = 3;
            this.label6.Text = "Client First Name";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.ClientIdTransactionBox);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.AddTransactionButton);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.BookIdTransactionBox);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Location = new System.Drawing.Point(334, 297);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(154, 141);
            this.groupBox3.TabIndex = 9;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Add Transaction";
            // 
            // ClientIdTransactionBox
            // 
            this.ClientIdTransactionBox.Location = new System.Drawing.Point(6, 85);
            this.ClientIdTransactionBox.Name = "ClientIdTransactionBox";
            this.ClientIdTransactionBox.Size = new System.Drawing.Size(143, 23);
            this.ClientIdTransactionBox.TabIndex = 6;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 67);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(51, 15);
            this.label7.TabIndex = 7;
            this.label7.Text = "Id Client";
            // 
            // AddTransactionButton
            // 
            this.AddTransactionButton.Location = new System.Drawing.Point(6, 114);
            this.AddTransactionButton.Name = "AddTransactionButton";
            this.AddTransactionButton.Size = new System.Drawing.Size(143, 23);
            this.AddTransactionButton.TabIndex = 5;
            this.AddTransactionButton.Text = "Click to Add Transaction";
            this.AddTransactionButton.UseVisualStyleBackColor = true;
            this.AddTransactionButton.Click += new System.EventHandler(this.AddTransactionButton_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 21);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(0, 15);
            this.label8.TabIndex = 4;
            // 
            // BookIdTransactionBox
            // 
            this.BookIdTransactionBox.Location = new System.Drawing.Point(6, 37);
            this.BookIdTransactionBox.Name = "BookIdTransactionBox";
            this.BookIdTransactionBox.Size = new System.Drawing.Size(143, 23);
            this.BookIdTransactionBox.TabIndex = 2;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 19);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(47, 15);
            this.label9.TabIndex = 3;
            this.label9.Text = "Id Book";
            // 
            // ShowAllTransactionsButton
            // 
            this.ShowAllTransactionsButton.Location = new System.Drawing.Point(334, 221);
            this.ShowAllTransactionsButton.Name = "ShowAllTransactionsButton";
            this.ShowAllTransactionsButton.Size = new System.Drawing.Size(154, 23);
            this.ShowAllTransactionsButton.TabIndex = 23;
            this.ShowAllTransactionsButton.Text = "Show All Transactions";
            this.ShowAllTransactionsButton.UseVisualStyleBackColor = true;
            this.ShowAllTransactionsButton.Click += new System.EventHandler(this.ShowAllTransactionsButton_Click);
            // 
            // ShowAllClientsButton
            // 
            this.ShowAllClientsButton.Location = new System.Drawing.Point(173, 221);
            this.ShowAllClientsButton.Name = "ShowAllClientsButton";
            this.ShowAllClientsButton.Size = new System.Drawing.Size(155, 23);
            this.ShowAllClientsButton.TabIndex = 22;
            this.ShowAllClientsButton.Text = "Show All Clients";
            this.ShowAllClientsButton.UseVisualStyleBackColor = true;
            this.ShowAllClientsButton.Click += new System.EventHandler(this.ShowAllClientsButton_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.RemoveTransactionButton);
            this.groupBox4.Controls.Add(this.label11);
            this.groupBox4.Controls.Add(this.IdTransactionRemoveBox);
            this.groupBox4.Controls.Add(this.label12);
            this.groupBox4.Location = new System.Drawing.Point(564, 30);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(154, 100);
            this.groupBox4.TabIndex = 24;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Remove Transaction";
            // 
            // RemoveTransactionButton
            // 
            this.RemoveTransactionButton.Location = new System.Drawing.Point(5, 66);
            this.RemoveTransactionButton.Name = "RemoveTransactionButton";
            this.RemoveTransactionButton.Size = new System.Drawing.Size(143, 23);
            this.RemoveTransactionButton.TabIndex = 5;
            this.RemoveTransactionButton.Text = "Click to Add Transaction";
            this.RemoveTransactionButton.UseVisualStyleBackColor = true;
            this.RemoveTransactionButton.Click += new System.EventHandler(this.RemoveTransactionButton_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(6, 21);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(0, 15);
            this.label11.TabIndex = 4;
            // 
            // IdTransactionRemoveBox
            // 
            this.IdTransactionRemoveBox.Location = new System.Drawing.Point(6, 37);
            this.IdTransactionRemoveBox.Name = "IdTransactionRemoveBox";
            this.IdTransactionRemoveBox.Size = new System.Drawing.Size(143, 23);
            this.IdTransactionRemoveBox.TabIndex = 2;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(6, 19);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(80, 15);
            this.label12.TabIndex = 3;
            this.label12.Text = "Id Transaction";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.ShowAllTransactionsButton);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.ShowAllClientsButton);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.ShowAllBooksButton);
            this.Controls.Add(this.labelbook);
            this.Controls.Add(this.LogBox);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox TitleAddBox;
        private TextBox AuthorFirstNameAddBox;
        private Label label1;
        private Label label2;
        private GroupBox groupBox1;
        private Button AddBookButton;
        private TextBox AuthorLastNameAddBox;
        private Label label3;
        private TextBox LogBox;
        private Label labelbook;
        private Button ShowAllBooksButton;
        private GroupBox groupBox2;
        private TextBox ClientLastNameAddBox;
        private Label label4;
        private Button AddClientButton;
        private Label label5;
        private TextBox ClientFirstNameAddBox;
        private Label label6;
        private GroupBox groupBox3;
        private TextBox ClientIdTransactionBox;
        private Label label7;
        private Button AddTransactionButton;
        private Label label8;
        private TextBox BookIdTransactionBox;
        private Label label9;
        private Button button1;
        private Button ShowAllTransactionsButton;
        private Button ShowAllClientsButton;
        private GroupBox groupBox4;
        private Button RemoveTransactionButton;
        private Label label11;
        private TextBox IdTransactionRemoveBox;
        private Label label12;
    }
}