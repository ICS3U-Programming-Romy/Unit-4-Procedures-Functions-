namespace _27.PercentageProgramRChuIII
{
    partial class frmPercentageProgram
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
            this.lblEnter = new System.Windows.Forms.Label();
            this.txtGrade = new System.Windows.Forms.TextBox();
            this.lblPercentage = new System.Windows.Forms.Label();
            this.btnOutput = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblEnter
            // 
            this.lblEnter.AutoSize = true;
            this.lblEnter.Location = new System.Drawing.Point(11, 9);
            this.lblEnter.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblEnter.Name = "lblEnter";
            this.lblEnter.Size = new System.Drawing.Size(216, 13);
            this.lblEnter.TabIndex = 0;
            this.lblEnter.Text = "Enter the grade that you want (0---- to 4++) : ";
            // 
            // txtGrade
            // 
            this.txtGrade.Location = new System.Drawing.Point(14, 24);
            this.txtGrade.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtGrade.Name = "txtGrade";
            this.txtGrade.Size = new System.Drawing.Size(160, 20);
            this.txtGrade.TabIndex = 1;
            // 
            // lblPercentage
            // 
            this.lblPercentage.AutoSize = true;
            this.lblPercentage.Location = new System.Drawing.Point(11, 89);
            this.lblPercentage.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPercentage.Name = "lblPercentage";
            this.lblPercentage.Size = new System.Drawing.Size(149, 13);
            this.lblPercentage.TabIndex = 2;
            this.lblPercentage.Text = "The Percentage you want is : ";
            // 
            // btnOutput
            // 
            this.btnOutput.Location = new System.Drawing.Point(14, 48);
            this.btnOutput.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnOutput.Name = "btnOutput";
            this.btnOutput.Size = new System.Drawing.Size(70, 26);
            this.btnOutput.TabIndex = 3;
            this.btnOutput.Text = "Go";
            this.btnOutput.UseVisualStyleBackColor = true;
            this.btnOutput.Click += new System.EventHandler(this.btnOutput_Click);
            // 
            // frmPercentageProgram
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(348, 125);
            this.Controls.Add(this.btnOutput);
            this.Controls.Add(this.lblPercentage);
            this.Controls.Add(this.txtGrade);
            this.Controls.Add(this.lblEnter);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "frmPercentageProgram";
            this.Text = "Percentage Program by Romy I. Chu III";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblEnter;
        private System.Windows.Forms.TextBox txtGrade;
        private System.Windows.Forms.Label lblPercentage;
        private System.Windows.Forms.Button btnOutput;
    }
}

