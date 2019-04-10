namespace _25.RoundingProgramRChuIII
{
    partial class frmRoundingProgram
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
            this.lblWhat = new System.Windows.Forms.Label();
            this.lblToDo = new System.Windows.Forms.Label();
            this.nudDecimalPlaceInput = new System.Windows.Forms.NumericUpDown();
            this.txtNumberInput = new System.Windows.Forms.TextBox();
            this.btnRound = new System.Windows.Forms.Button();
            this.lblOutput = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nudDecimalPlaceInput)).BeginInit();
            this.SuspendLayout();
            // 
            // lblWhat
            // 
            this.lblWhat.AutoSize = true;
            this.lblWhat.Location = new System.Drawing.Point(12, 9);
            this.lblWhat.Name = "lblWhat";
            this.lblWhat.Size = new System.Drawing.Size(198, 13);
            this.lblWhat.TabIndex = 0;
            this.lblWhat.Text = "Input a number that you want to Round: ";
            // 
            // lblToDo
            // 
            this.lblToDo.AutoSize = true;
            this.lblToDo.Location = new System.Drawing.Point(12, 42);
            this.lblToDo.Name = "lblToDo";
            this.lblToDo.Size = new System.Drawing.Size(281, 13);
            this.lblToDo.TabIndex = 1;
            this.lblToDo.Text = "Input the number of decimal places you want to round to : ";
            // 
            // nudDecimalPlaceInput
            // 
            this.nudDecimalPlaceInput.Location = new System.Drawing.Point(300, 42);
            this.nudDecimalPlaceInput.Name = "nudDecimalPlaceInput";
            this.nudDecimalPlaceInput.Size = new System.Drawing.Size(102, 20);
            this.nudDecimalPlaceInput.TabIndex = 2;
            // 
            // txtNumberInput
            // 
            this.txtNumberInput.Location = new System.Drawing.Point(216, 6);
            this.txtNumberInput.Name = "txtNumberInput";
            this.txtNumberInput.Size = new System.Drawing.Size(100, 20);
            this.txtNumberInput.TabIndex = 3;
            // 
            // btnRound
            // 
            this.btnRound.Location = new System.Drawing.Point(15, 76);
            this.btnRound.Name = "btnRound";
            this.btnRound.Size = new System.Drawing.Size(75, 23);
            this.btnRound.TabIndex = 4;
            this.btnRound.Text = "Round";
            this.btnRound.UseVisualStyleBackColor = true;
            this.btnRound.Click += new System.EventHandler(this.btnRound_Click);
            // 
            // lblOutput
            // 
            this.lblOutput.AutoSize = true;
            this.lblOutput.Location = new System.Drawing.Point(12, 112);
            this.lblOutput.Name = "lblOutput";
            this.lblOutput.Size = new System.Drawing.Size(130, 13);
            this.lblOutput.TabIndex = 5;
            this.lblOutput.Text = "The Rounded number is : ";
            // 
            // frmRoundingProgram
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(414, 138);
            this.Controls.Add(this.lblOutput);
            this.Controls.Add(this.btnRound);
            this.Controls.Add(this.txtNumberInput);
            this.Controls.Add(this.nudDecimalPlaceInput);
            this.Controls.Add(this.lblToDo);
            this.Controls.Add(this.lblWhat);
            this.Name = "frmRoundingProgram";
            this.Text = "Rounding Program By Romy I. Chu III";
            ((System.ComponentModel.ISupportInitialize)(this.nudDecimalPlaceInput)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblWhat;
        private System.Windows.Forms.Label lblToDo;
        private System.Windows.Forms.NumericUpDown nudDecimalPlaceInput;
        private System.Windows.Forms.TextBox txtNumberInput;
        private System.Windows.Forms.Button btnRound;
        private System.Windows.Forms.Label lblOutput;
    }
}

