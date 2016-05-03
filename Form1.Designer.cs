namespace Search
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
            this.textLbl = new System.Windows.Forms.Label();
            this.matchedLbl = new System.Windows.Forms.Label();
            this.patternLbl = new System.Windows.Forms.Label();
            this.matchedListBox = new System.Windows.Forms.ListBox();
            this.patternTxtBox = new System.Windows.Forms.TextBox();
            this.searchBttn = new System.Windows.Forms.Button();
            this.textRichTxtBox = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // textLbl
            // 
            this.textLbl.AutoSize = true;
            this.textLbl.Location = new System.Drawing.Point(28, 30);
            this.textLbl.Name = "textLbl";
            this.textLbl.Size = new System.Drawing.Size(28, 13);
            this.textLbl.TabIndex = 0;
            this.textLbl.Text = "Text";
            // 
            // matchedLbl
            // 
            this.matchedLbl.AutoSize = true;
            this.matchedLbl.Location = new System.Drawing.Point(241, 30);
            this.matchedLbl.Name = "matchedLbl";
            this.matchedLbl.Size = new System.Drawing.Size(37, 13);
            this.matchedLbl.TabIndex = 1;
            this.matchedLbl.Text = "Match";
            // 
            // patternLbl
            // 
            this.patternLbl.AutoSize = true;
            this.patternLbl.Location = new System.Drawing.Point(51, 221);
            this.patternLbl.Name = "patternLbl";
            this.patternLbl.Size = new System.Drawing.Size(41, 13);
            this.patternLbl.TabIndex = 2;
            this.patternLbl.Text = "Pattern";
            // 
            // matchedListBox
            // 
            this.matchedListBox.FormattingEnabled = true;
            this.matchedListBox.Location = new System.Drawing.Point(244, 55);
            this.matchedListBox.Name = "matchedListBox";
            this.matchedListBox.Size = new System.Drawing.Size(195, 134);
            this.matchedListBox.TabIndex = 4;
            // 
            // patternTxtBox
            // 
            this.patternTxtBox.Location = new System.Drawing.Point(98, 218);
            this.patternTxtBox.Name = "patternTxtBox";
            this.patternTxtBox.Size = new System.Drawing.Size(128, 20);
            this.patternTxtBox.TabIndex = 5;
            // 
            // searchBttn
            // 
            this.searchBttn.Location = new System.Drawing.Point(244, 216);
            this.searchBttn.Name = "searchBttn";
            this.searchBttn.Size = new System.Drawing.Size(75, 23);
            this.searchBttn.TabIndex = 6;
            this.searchBttn.Text = "Search";
            this.searchBttn.UseVisualStyleBackColor = true;
            this.searchBttn.Click += new System.EventHandler(this.searchBttn_Click);
            // 
            // textRichTxtBox
            // 
            this.textRichTxtBox.Location = new System.Drawing.Point(31, 55);
            this.textRichTxtBox.Name = "textRichTxtBox";
            this.textRichTxtBox.Size = new System.Drawing.Size(195, 134);
            this.textRichTxtBox.TabIndex = 7;
            this.textRichTxtBox.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(480, 285);
            this.Controls.Add(this.textRichTxtBox);
            this.Controls.Add(this.searchBttn);
            this.Controls.Add(this.patternTxtBox);
            this.Controls.Add(this.matchedListBox);
            this.Controls.Add(this.patternLbl);
            this.Controls.Add(this.matchedLbl);
            this.Controls.Add(this.textLbl);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label textLbl;
        private System.Windows.Forms.Label matchedLbl;
        private System.Windows.Forms.Label patternLbl;
        private System.Windows.Forms.ListBox matchedListBox;
        private System.Windows.Forms.TextBox patternTxtBox;
        private System.Windows.Forms.Button searchBttn;
        private System.Windows.Forms.RichTextBox textRichTxtBox;
    }
}

