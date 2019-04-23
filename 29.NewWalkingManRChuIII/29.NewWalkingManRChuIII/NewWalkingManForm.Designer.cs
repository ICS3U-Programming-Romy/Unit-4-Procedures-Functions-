namespace _29.NewWalkingManRChuIII
{
    partial class frmNewWalkingMan
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
            this.lblClickTheButton = new System.Windows.Forms.Label();
            this.btnClickMe = new System.Windows.Forms.Button();
            this.lblWhatToDo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblClickTheButton
            // 
            this.lblClickTheButton.AutoSize = true;
            this.lblClickTheButton.Location = new System.Drawing.Point(155, 9);
            this.lblClickTheButton.Name = "lblClickTheButton";
            this.lblClickTheButton.Size = new System.Drawing.Size(81, 13);
            this.lblClickTheButton.TabIndex = 0;
            this.lblClickTheButton.Text = "Click the button";
            // 
            // btnClickMe
            // 
            this.btnClickMe.Location = new System.Drawing.Point(142, 55);
            this.btnClickMe.Name = "btnClickMe";
            this.btnClickMe.Size = new System.Drawing.Size(75, 23);
            this.btnClickMe.TabIndex = 1;
            this.btnClickMe.Text = "Click ME";
            this.btnClickMe.UseVisualStyleBackColor = true;
            this.btnClickMe.Click += new System.EventHandler(this.btnClickMe_Click);
            // 
            // lblWhatToDo
            // 
            this.lblWhatToDo.AutoSize = true;
            this.lblWhatToDo.Location = new System.Drawing.Point(12, 9);
            this.lblWhatToDo.Name = "lblWhatToDo";
            this.lblWhatToDo.Size = new System.Drawing.Size(249, 13);
            this.lblWhatToDo.TabIndex = 2;
            this.lblWhatToDo.Text = "Click any of the picture boxes to make the man run.";
            // 
            // frmNewWalkingMan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(681, 545);
            this.Controls.Add(this.lblWhatToDo);
            this.Controls.Add(this.btnClickMe);
            this.Controls.Add(this.lblClickTheButton);
            this.Name = "frmNewWalkingMan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "New Walking Man Program By Romy I. Chu III";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblClickTheButton;
        private System.Windows.Forms.Button btnClickMe;
        private System.Windows.Forms.Label lblWhatToDo;
    }
}

