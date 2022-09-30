namespace Activity_5
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
            this.btnOpen = new System.Windows.Forms.Button();
            this.lblLowerCase = new System.Windows.Forms.Label();
            this.lblStatistics = new System.Windows.Forms.Label();
            this.lblDescription = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.txtLowerCase = new System.Windows.Forms.TextBox();
            this.lblAlphabetical = new System.Windows.Forms.Label();
            this.txtAlphabetical = new System.Windows.Forms.TextBox();
            this.lblLongestWord = new System.Windows.Forms.Label();
            this.txtLongestWord = new System.Windows.Forms.TextBox();
            this.lblMostVowels = new System.Windows.Forms.Label();
            this.txtMostVowels = new System.Windows.Forms.TextBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnOpen
            // 
            this.btnOpen.BackColor = System.Drawing.Color.White;
            this.btnOpen.Location = new System.Drawing.Point(40, 86);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(308, 41);
            this.btnOpen.TabIndex = 0;
            this.btnOpen.Text = "Open File";
            this.btnOpen.UseVisualStyleBackColor = false;
            this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // lblLowerCase
            // 
            this.lblLowerCase.AutoSize = true;
            this.lblLowerCase.Location = new System.Drawing.Point(36, 177);
            this.lblLowerCase.Name = "lblLowerCase";
            this.lblLowerCase.Size = new System.Drawing.Size(139, 16);
            this.lblLowerCase.TabIndex = 5;
            this.lblLowerCase.Text = "Convert to lower-case.";
            // 
            // lblStatistics
            // 
            this.lblStatistics.AutoSize = true;
            this.lblStatistics.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.lblStatistics.Location = new System.Drawing.Point(35, 143);
            this.lblStatistics.Name = "lblStatistics";
            this.lblStatistics.Size = new System.Drawing.Size(386, 24);
            this.lblStatistics.TabIndex = 12;
            this.lblStatistics.Text = "Conversion Results and Statistical Information";
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Location = new System.Drawing.Point(37, 57);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(341, 16);
            this.lblDescription.TabIndex = 13;
            this.lblDescription.Text = "Hello and welcome. Upload a file using the button below.";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.lblTitle.Location = new System.Drawing.Point(36, 23);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(189, 24);
            this.lblTitle.TabIndex = 14;
            this.lblTitle.Text = "Activity 5 - CST-150 ★";
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(702, 462);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(86, 28);
            this.btnClose.TabIndex = 16;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // txtLowerCase
            // 
            this.txtLowerCase.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.txtLowerCase.Location = new System.Drawing.Point(40, 196);
            this.txtLowerCase.Name = "txtLowerCase";
            this.txtLowerCase.Size = new System.Drawing.Size(632, 28);
            this.txtLowerCase.TabIndex = 1;
            // 
            // lblAlphabetical
            // 
            this.lblAlphabetical.AutoSize = true;
            this.lblAlphabetical.Location = new System.Drawing.Point(36, 248);
            this.lblAlphabetical.Name = "lblAlphabetical";
            this.lblAlphabetical.Size = new System.Drawing.Size(249, 16);
            this.lblAlphabetical.TabIndex = 19;
            this.lblAlphabetical.Text = "Find the first and last word alphabetically.";
            // 
            // txtAlphabetical
            // 
            this.txtAlphabetical.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.txtAlphabetical.Location = new System.Drawing.Point(40, 271);
            this.txtAlphabetical.Name = "txtAlphabetical";
            this.txtAlphabetical.Size = new System.Drawing.Size(632, 28);
            this.txtAlphabetical.TabIndex = 18;
            // 
            // lblLongestWord
            // 
            this.lblLongestWord.AutoSize = true;
            this.lblLongestWord.Location = new System.Drawing.Point(36, 318);
            this.lblLongestWord.Name = "lblLongestWord";
            this.lblLongestWord.Size = new System.Drawing.Size(136, 16);
            this.lblLongestWord.TabIndex = 22;
            this.lblLongestWord.Text = "Find the longest word.";
            // 
            // txtLongestWord
            // 
            this.txtLongestWord.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.txtLongestWord.Location = new System.Drawing.Point(40, 341);
            this.txtLongestWord.Name = "txtLongestWord";
            this.txtLongestWord.Size = new System.Drawing.Size(632, 28);
            this.txtLongestWord.TabIndex = 21;
            // 
            // lblMostVowels
            // 
            this.lblMostVowels.AutoSize = true;
            this.lblMostVowels.Location = new System.Drawing.Point(36, 388);
            this.lblMostVowels.Name = "lblMostVowels";
            this.lblMostVowels.Size = new System.Drawing.Size(212, 16);
            this.lblMostVowels.TabIndex = 25;
            this.lblMostVowels.Text = "Find the word with the most vowels.";
            // 
            // txtMostVowels
            // 
            this.txtMostVowels.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.txtMostVowels.Location = new System.Drawing.Point(40, 411);
            this.txtMostVowels.Name = "txtMostVowels";
            this.txtMostVowels.Size = new System.Drawing.Size(632, 28);
            this.txtMostVowels.TabIndex = 24;
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.White;
            this.btnClear.Location = new System.Drawing.Point(354, 86);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(318, 41);
            this.btnClear.TabIndex = 27;
            this.btnClear.Text = "Clear Results";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Azure;
            this.ClientSize = new System.Drawing.Size(800, 512);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.lblMostVowels);
            this.Controls.Add(this.txtMostVowels);
            this.Controls.Add(this.lblLongestWord);
            this.Controls.Add(this.txtLongestWord);
            this.Controls.Add(this.lblAlphabetical);
            this.Controls.Add(this.txtAlphabetical);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.lblStatistics);
            this.Controls.Add(this.lblLowerCase);
            this.Controls.Add(this.txtLowerCase);
            this.Controls.Add(this.btnOpen);
            this.Name = "Form1";
            this.Text = "Activity 5 - Grand Canyon University";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnOpen;
        private System.Windows.Forms.Label lblLowerCase;
        private System.Windows.Forms.Label lblStatistics;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.TextBox txtLowerCase;
        private System.Windows.Forms.Label lblAlphabetical;
        private System.Windows.Forms.TextBox txtAlphabetical;
        private System.Windows.Forms.Label lblLongestWord;
        private System.Windows.Forms.TextBox txtLongestWord;
        private System.Windows.Forms.Label lblMostVowels;
        private System.Windows.Forms.TextBox txtMostVowels;
        private System.Windows.Forms.Button btnClear;
    }
}

