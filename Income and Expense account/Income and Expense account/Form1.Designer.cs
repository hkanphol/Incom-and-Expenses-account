namespace Income_and_Expense_account
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.nameBox = new System.Windows.Forms.TextBox();
            this.amountBox = new System.Windows.Forms.TextBox();
            this.save_button = new System.Windows.Forms.Button();
            this.Income_checkBox = new System.Windows.Forms.CheckBox();
            this.Expenses_checkBox = new System.Windows.Forms.CheckBox();
            this.allList_Box = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.allIncomeBox = new System.Windows.Forms.TextBox();
            this.allExpensesBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.load_button = new System.Windows.Forms.Button();
            this.add_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(87, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(87, 127);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Amount";
            // 
            // nameBox
            // 
            this.nameBox.Location = new System.Drawing.Point(204, 70);
            this.nameBox.Name = "nameBox";
            this.nameBox.Size = new System.Drawing.Size(260, 31);
            this.nameBox.TabIndex = 2;
            // 
            // amountBox
            // 
            this.amountBox.Location = new System.Drawing.Point(204, 127);
            this.amountBox.Name = "amountBox";
            this.amountBox.Size = new System.Drawing.Size(260, 31);
            this.amountBox.TabIndex = 3;
            // 
            // save_button
            // 
            this.save_button.Location = new System.Drawing.Point(529, 127);
            this.save_button.Name = "save_button";
            this.save_button.Size = new System.Drawing.Size(112, 43);
            this.save_button.TabIndex = 4;
            this.save_button.Text = "Save";
            this.save_button.UseVisualStyleBackColor = true;
            this.save_button.Click += new System.EventHandler(this.save_button_Click);
            // 
            // Income_checkBox
            // 
            this.Income_checkBox.AutoSize = true;
            this.Income_checkBox.Location = new System.Drawing.Point(184, 195);
            this.Income_checkBox.Name = "Income_checkBox";
            this.Income_checkBox.Size = new System.Drawing.Size(97, 29);
            this.Income_checkBox.TabIndex = 5;
            this.Income_checkBox.Text = "Income";
            this.Income_checkBox.UseVisualStyleBackColor = true;
            // 
            // Expenses_checkBox
            // 
            this.Expenses_checkBox.AutoSize = true;
            this.Expenses_checkBox.Location = new System.Drawing.Point(343, 195);
            this.Expenses_checkBox.Name = "Expenses_checkBox";
            this.Expenses_checkBox.Size = new System.Drawing.Size(110, 29);
            this.Expenses_checkBox.TabIndex = 6;
            this.Expenses_checkBox.Text = "Expenses";
            this.Expenses_checkBox.UseVisualStyleBackColor = true;
            // 
            // allList_Box
            // 
            this.allList_Box.Location = new System.Drawing.Point(72, 240);
            this.allList_Box.Multiline = true;
            this.allList_Box.Name = "allList_Box";
            this.allList_Box.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.allList_Box.Size = new System.Drawing.Size(461, 208);
            this.allList_Box.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(571, 272);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 25);
            this.label3.TabIndex = 11;
            this.label3.Text = "All Income";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(571, 320);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(109, 25);
            this.label4.TabIndex = 12;
            this.label4.Text = "All Expenses";
            // 
            // allIncomeBox
            // 
            this.allIncomeBox.Location = new System.Drawing.Point(704, 272);
            this.allIncomeBox.Name = "allIncomeBox";
            this.allIncomeBox.Size = new System.Drawing.Size(150, 31);
            this.allIncomeBox.TabIndex = 13;
            // 
            // allExpensesBox
            // 
            this.allExpensesBox.Location = new System.Drawing.Point(704, 320);
            this.allExpensesBox.Name = "allExpensesBox";
            this.allExpensesBox.Size = new System.Drawing.Size(150, 31);
            this.allExpensesBox.TabIndex = 14;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(904, 272);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 25);
            this.label5.TabIndex = 15;
            this.label5.Text = "Baht";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(904, 326);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 25);
            this.label6.TabIndex = 16;
            this.label6.Text = "Baht";
            // 
            // load_button
            // 
            this.load_button.Location = new System.Drawing.Point(529, 190);
            this.load_button.Name = "load_button";
            this.load_button.Size = new System.Drawing.Size(112, 34);
            this.load_button.TabIndex = 17;
            this.load_button.Text = "Load";
            this.load_button.UseVisualStyleBackColor = true;
            // 
            // add_button
            // 
            this.add_button.Location = new System.Drawing.Point(529, 70);
            this.add_button.Name = "add_button";
            this.add_button.Size = new System.Drawing.Size(112, 34);
            this.add_button.TabIndex = 18;
            this.add_button.Text = "ADD";
            this.add_button.UseVisualStyleBackColor = true;
            this.add_button.Click += new System.EventHandler(this.add_button_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(988, 450);
            this.Controls.Add(this.add_button);
            this.Controls.Add(this.load_button);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.allExpensesBox);
            this.Controls.Add(this.allIncomeBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.allList_Box);
            this.Controls.Add(this.Expenses_checkBox);
            this.Controls.Add(this.Income_checkBox);
            this.Controls.Add(this.save_button);
            this.Controls.Add(this.amountBox);
            this.Controls.Add(this.nameBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox nameBox;
        private TextBox amountBox;
        private Button save_button;
        private CheckBox Income_checkBox;
        private CheckBox Expenses_checkBox;
        private TextBox allList_Box;
        private Label label3;
        private Label label4;
        private TextBox allIncomeBox;
        private TextBox allExpensesBox;
        private Label label5;
        private Label label6;
        private Button load_button;
        private Button add_button;
    }
}