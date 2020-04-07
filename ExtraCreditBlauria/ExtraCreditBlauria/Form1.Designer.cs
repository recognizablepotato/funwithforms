namespace ExtraCreditBlauria
{
    partial class Form1
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.txtEnterHoursWorked = new System.Windows.Forms.TextBox();
            this.txtEnterWeeksWorked = new System.Windows.Forms.TextBox();
            this.txtEnterHourlyWage = new System.Windows.Forms.TextBox();
            this.lblEnterWeeksWorked = new System.Windows.Forms.Label();
            this.lblEnterHoursWorked = new System.Windows.Forms.Label();
            this.lblEnterHourlyWage = new System.Windows.Forms.Label();
            this.btnMethod1CalculatePay = new System.Windows.Forms.Button();
            this.btnClearListbox = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.txtEnterAWord = new System.Windows.Forms.TextBox();
            this.txtEnterAWord1 = new System.Windows.Forms.TextBox();
            this.lblEnterAWord1 = new System.Windows.Forms.Label();
            this.lblEnterAWord = new System.Windows.Forms.Label();
            this.btnClearListbox2 = new System.Windows.Forms.Button();
            this.btnMethod2ReturnMatch = new System.Windows.Forms.Button();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.txtEnterNumber = new System.Windows.Forms.TextBox();
            this.txtEnterAWord3 = new System.Windows.Forms.TextBox();
            this.lblEnterNumber = new System.Windows.Forms.Label();
            this.lblEnterAWord3 = new System.Windows.Forms.Label();
            this.btnClearListbox3 = new System.Windows.Forms.Button();
            this.btnMethod3PassbyRef = new System.Windows.Forms.Button();
            this.lstOutput = new System.Windows.Forms.ListBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(516, 294);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage1.Controls.Add(this.txtEnterHoursWorked);
            this.tabPage1.Controls.Add(this.txtEnterWeeksWorked);
            this.tabPage1.Controls.Add(this.txtEnterHourlyWage);
            this.tabPage1.Controls.Add(this.lblEnterWeeksWorked);
            this.tabPage1.Controls.Add(this.lblEnterHoursWorked);
            this.tabPage1.Controls.Add(this.lblEnterHourlyWage);
            this.tabPage1.Controls.Add(this.btnMethod1CalculatePay);
            this.tabPage1.Controls.Add(this.btnClearListbox);
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(508, 261);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Method 1";
            // 
            // txtEnterHoursWorked
            // 
            this.txtEnterHoursWorked.Location = new System.Drawing.Point(213, 65);
            this.txtEnterHoursWorked.Name = "txtEnterHoursWorked";
            this.txtEnterHoursWorked.Size = new System.Drawing.Size(226, 26);
            this.txtEnterHoursWorked.TabIndex = 9;
            // 
            // txtEnterWeeksWorked
            // 
            this.txtEnterWeeksWorked.Location = new System.Drawing.Point(213, 108);
            this.txtEnterWeeksWorked.Name = "txtEnterWeeksWorked";
            this.txtEnterWeeksWorked.Size = new System.Drawing.Size(226, 26);
            this.txtEnterWeeksWorked.TabIndex = 8;
            // 
            // txtEnterHourlyWage
            // 
            this.txtEnterHourlyWage.Location = new System.Drawing.Point(214, 25);
            this.txtEnterHourlyWage.Name = "txtEnterHourlyWage";
            this.txtEnterHourlyWage.Size = new System.Drawing.Size(226, 26);
            this.txtEnterHourlyWage.TabIndex = 7;
            // 
            // lblEnterWeeksWorked
            // 
            this.lblEnterWeeksWorked.AutoSize = true;
            this.lblEnterWeeksWorked.Location = new System.Drawing.Point(53, 111);
            this.lblEnterWeeksWorked.Name = "lblEnterWeeksWorked";
            this.lblEnterWeeksWorked.Size = new System.Drawing.Size(160, 20);
            this.lblEnterWeeksWorked.TabIndex = 6;
            this.lblEnterWeeksWorked.Text = "Enter Weeks Worked";
            // 
            // lblEnterHoursWorked
            // 
            this.lblEnterHoursWorked.AutoSize = true;
            this.lblEnterHoursWorked.Location = new System.Drawing.Point(53, 71);
            this.lblEnterHoursWorked.Name = "lblEnterHoursWorked";
            this.lblEnterHoursWorked.Size = new System.Drawing.Size(154, 20);
            this.lblEnterHoursWorked.TabIndex = 5;
            this.lblEnterHoursWorked.Text = "Enter Hours Worked";
            // 
            // lblEnterHourlyWage
            // 
            this.lblEnterHourlyWage.AutoSize = true;
            this.lblEnterHourlyWage.Location = new System.Drawing.Point(53, 31);
            this.lblEnterHourlyWage.Name = "lblEnterHourlyWage";
            this.lblEnterHourlyWage.Size = new System.Drawing.Size(143, 20);
            this.lblEnterHourlyWage.TabIndex = 4;
            this.lblEnterHourlyWage.Text = "Enter Hourly Wage";
            // 
            // btnMethod1CalculatePay
            // 
            this.btnMethod1CalculatePay.Location = new System.Drawing.Point(117, 167);
            this.btnMethod1CalculatePay.Name = "btnMethod1CalculatePay";
            this.btnMethod1CalculatePay.Size = new System.Drawing.Size(277, 30);
            this.btnMethod1CalculatePay.TabIndex = 3;
            this.btnMethod1CalculatePay.Text = "Method 1 - Calculate Pay";
            this.btnMethod1CalculatePay.UseVisualStyleBackColor = true;
            this.btnMethod1CalculatePay.Click += new System.EventHandler(this.btnMethod1CalculatePay_Click);
            // 
            // btnClearListbox
            // 
            this.btnClearListbox.Location = new System.Drawing.Point(184, 213);
            this.btnClearListbox.Name = "btnClearListbox";
            this.btnClearListbox.Size = new System.Drawing.Size(138, 30);
            this.btnClearListbox.TabIndex = 2;
            this.btnClearListbox.Text = "Clear Listbox";
            this.btnClearListbox.UseVisualStyleBackColor = true;
            this.btnClearListbox.Click += new System.EventHandler(this.btnClearListbox_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.txtEnterAWord);
            this.tabPage2.Controls.Add(this.txtEnterAWord1);
            this.tabPage2.Controls.Add(this.lblEnterAWord1);
            this.tabPage2.Controls.Add(this.lblEnterAWord);
            this.tabPage2.Controls.Add(this.btnClearListbox2);
            this.tabPage2.Controls.Add(this.btnMethod2ReturnMatch);
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(508, 261);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Method 2";
            // 
            // txtEnterAWord
            // 
            this.txtEnterAWord.Location = new System.Drawing.Point(197, 29);
            this.txtEnterAWord.Name = "txtEnterAWord";
            this.txtEnterAWord.Size = new System.Drawing.Size(169, 26);
            this.txtEnterAWord.TabIndex = 9;
            // 
            // txtEnterAWord1
            // 
            this.txtEnterAWord1.Location = new System.Drawing.Point(197, 81);
            this.txtEnterAWord1.Name = "txtEnterAWord1";
            this.txtEnterAWord1.Size = new System.Drawing.Size(169, 26);
            this.txtEnterAWord1.TabIndex = 8;
            // 
            // lblEnterAWord1
            // 
            this.lblEnterAWord1.AutoSize = true;
            this.lblEnterAWord1.Location = new System.Drawing.Point(84, 87);
            this.lblEnterAWord1.Name = "lblEnterAWord1";
            this.lblEnterAWord1.Size = new System.Drawing.Size(103, 20);
            this.lblEnterAWord1.TabIndex = 6;
            this.lblEnterAWord1.Text = "Enter a Word";
            // 
            // lblEnterAWord
            // 
            this.lblEnterAWord.AutoSize = true;
            this.lblEnterAWord.Location = new System.Drawing.Point(84, 35);
            this.lblEnterAWord.Name = "lblEnterAWord";
            this.lblEnterAWord.Size = new System.Drawing.Size(103, 20);
            this.lblEnterAWord.TabIndex = 5;
            this.lblEnterAWord.Text = "Enter a Word";
            // 
            // btnClearListbox2
            // 
            this.btnClearListbox2.Location = new System.Drawing.Point(184, 208);
            this.btnClearListbox2.Name = "btnClearListbox2";
            this.btnClearListbox2.Size = new System.Drawing.Size(138, 30);
            this.btnClearListbox2.TabIndex = 2;
            this.btnClearListbox2.Text = "Clear Listbox";
            this.btnClearListbox2.UseVisualStyleBackColor = true;
            // 
            // btnMethod2ReturnMatch
            // 
            this.btnMethod2ReturnMatch.Location = new System.Drawing.Point(120, 161);
            this.btnMethod2ReturnMatch.Name = "btnMethod2ReturnMatch";
            this.btnMethod2ReturnMatch.Size = new System.Drawing.Size(277, 30);
            this.btnMethod2ReturnMatch.TabIndex = 1;
            this.btnMethod2ReturnMatch.Text = "Method 2- Return Match";
            this.btnMethod2ReturnMatch.UseVisualStyleBackColor = true;
            this.btnMethod2ReturnMatch.Click += new System.EventHandler(this.btnMethod2ReturnMatch_Click);
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage3.Controls.Add(this.txtEnterNumber);
            this.tabPage3.Controls.Add(this.txtEnterAWord3);
            this.tabPage3.Controls.Add(this.lblEnterNumber);
            this.tabPage3.Controls.Add(this.lblEnterAWord3);
            this.tabPage3.Controls.Add(this.btnClearListbox3);
            this.tabPage3.Controls.Add(this.btnMethod3PassbyRef);
            this.tabPage3.Location = new System.Drawing.Point(4, 29);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(508, 261);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Method 3";
            // 
            // txtEnterNumber
            // 
            this.txtEnterNumber.Location = new System.Drawing.Point(187, 95);
            this.txtEnterNumber.Name = "txtEnterNumber";
            this.txtEnterNumber.Size = new System.Drawing.Size(205, 26);
            this.txtEnterNumber.TabIndex = 9;
            // 
            // txtEnterAWord3
            // 
            this.txtEnterAWord3.Location = new System.Drawing.Point(187, 37);
            this.txtEnterAWord3.Name = "txtEnterAWord3";
            this.txtEnterAWord3.Size = new System.Drawing.Size(205, 26);
            this.txtEnterAWord3.TabIndex = 8;
            // 
            // lblEnterNumber
            // 
            this.lblEnterNumber.AutoSize = true;
            this.lblEnterNumber.Location = new System.Drawing.Point(76, 98);
            this.lblEnterNumber.Name = "lblEnterNumber";
            this.lblEnterNumber.Size = new System.Drawing.Size(108, 20);
            this.lblEnterNumber.TabIndex = 6;
            this.lblEnterNumber.Text = "Enter Number";
            // 
            // lblEnterAWord3
            // 
            this.lblEnterAWord3.AutoSize = true;
            this.lblEnterAWord3.Location = new System.Drawing.Point(76, 43);
            this.lblEnterAWord3.Name = "lblEnterAWord3";
            this.lblEnterAWord3.Size = new System.Drawing.Size(103, 20);
            this.lblEnterAWord3.TabIndex = 5;
            this.lblEnterAWord3.Text = "Enter a Word";
            // 
            // btnClearListbox3
            // 
            this.btnClearListbox3.Location = new System.Drawing.Point(178, 210);
            this.btnClearListbox3.Name = "btnClearListbox3";
            this.btnClearListbox3.Size = new System.Drawing.Size(138, 30);
            this.btnClearListbox3.TabIndex = 1;
            this.btnClearListbox3.Text = "Clear Listbox";
            this.btnClearListbox3.UseVisualStyleBackColor = true;
            // 
            // btnMethod3PassbyRef
            // 
            this.btnMethod3PassbyRef.Location = new System.Drawing.Point(115, 150);
            this.btnMethod3PassbyRef.Name = "btnMethod3PassbyRef";
            this.btnMethod3PassbyRef.Size = new System.Drawing.Size(277, 30);
            this.btnMethod3PassbyRef.TabIndex = 0;
            this.btnMethod3PassbyRef.Text = "Method 3 - Pass by Ref";
            this.btnMethod3PassbyRef.UseVisualStyleBackColor = true;
            this.btnMethod3PassbyRef.Click += new System.EventHandler(this.btnMethod3PassbyRef_Click);
            // 
            // lstOutput
            // 
            this.lstOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstOutput.FormattingEnabled = true;
            this.lstOutput.ItemHeight = 24;
            this.lstOutput.Location = new System.Drawing.Point(12, 312);
            this.lstOutput.Name = "lstOutput";
            this.lstOutput.Size = new System.Drawing.Size(512, 172);
            this.lstOutput.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(545, 510);
            this.Controls.Add(this.lstOutput);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TextBox txtEnterHoursWorked;
        private System.Windows.Forms.TextBox txtEnterWeeksWorked;
        private System.Windows.Forms.TextBox txtEnterHourlyWage;
        private System.Windows.Forms.Label lblEnterWeeksWorked;
        private System.Windows.Forms.Label lblEnterHoursWorked;
        private System.Windows.Forms.Label lblEnterHourlyWage;
        private System.Windows.Forms.Button btnMethod1CalculatePay;
        private System.Windows.Forms.Button btnClearListbox;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TextBox txtEnterAWord;
        private System.Windows.Forms.TextBox txtEnterAWord1;
        private System.Windows.Forms.Label lblEnterAWord1;
        private System.Windows.Forms.Label lblEnterAWord;
        private System.Windows.Forms.Button btnClearListbox2;
        private System.Windows.Forms.Button btnMethod2ReturnMatch;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TextBox txtEnterNumber;
        private System.Windows.Forms.TextBox txtEnterAWord3;
        private System.Windows.Forms.Label lblEnterNumber;
        private System.Windows.Forms.Label lblEnterAWord3;
        private System.Windows.Forms.Button btnClearListbox3;
        private System.Windows.Forms.Button btnMethod3PassbyRef;
        private System.Windows.Forms.ListBox lstOutput;
    }
}

