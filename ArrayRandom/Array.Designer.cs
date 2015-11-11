namespace ArrayRandom
{
    partial class frmArray
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
            this.lstRanBox = new System.Windows.Forms.ListBox();
            this.lblQuestion = new System.Windows.Forms.Label();
            this.btnRoll = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lstRanBox
            // 
            this.lstRanBox.FormattingEnabled = true;
            this.lstRanBox.Location = new System.Drawing.Point(212, 13);
            this.lstRanBox.Name = "lstRanBox";
            this.lstRanBox.Size = new System.Drawing.Size(145, 186);
            this.lstRanBox.TabIndex = 0;
            // 
            // lblQuestion
            // 
            this.lblQuestion.AutoSize = true;
            this.lblQuestion.Location = new System.Drawing.Point(13, 13);
            this.lblQuestion.Name = "lblQuestion";
            this.lblQuestion.Size = new System.Drawing.Size(0, 13);
            this.lblQuestion.TabIndex = 1;
            // 
            // btnRoll
            // 
            this.btnRoll.Location = new System.Drawing.Point(16, 128);
            this.btnRoll.Name = "btnRoll";
            this.btnRoll.Size = new System.Drawing.Size(174, 71);
            this.btnRoll.TabIndex = 2;
            this.btnRoll.Text = "Roll";
            this.btnRoll.UseVisualStyleBackColor = true;
            this.btnRoll.Click += new System.EventHandler(this.btnRoll_Click);
            // 
            // frmArray
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(369, 211);
            this.Controls.Add(this.btnRoll);
            this.Controls.Add(this.lblQuestion);
            this.Controls.Add(this.lstRanBox);
            this.Name = "frmArray";
            this.Text = "Arrays";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstRanBox;
        private System.Windows.Forms.Label lblQuestion;
        private System.Windows.Forms.Button btnRoll;
    }
}

