namespace _24.ConvertTempRChuIII
{
    partial class frmTempConvert
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
            this.btnConvert = new System.Windows.Forms.Button();
            this.lblYes = new System.Windows.Forms.Label();
            this.txtInput = new System.Windows.Forms.TextBox();
            this.lblTemperature = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnConvert
            // 
            this.btnConvert.Location = new System.Drawing.Point(77, 38);
            this.btnConvert.Name = "btnConvert";
            this.btnConvert.Size = new System.Drawing.Size(75, 23);
            this.btnConvert.TabIndex = 0;
            this.btnConvert.Text = "Convert";
            this.btnConvert.UseVisualStyleBackColor = true;
            this.btnConvert.Click += new System.EventHandler(this.btnConvert_Click);
            // 
            // lblYes
            // 
            this.lblYes.AutoSize = true;
            this.lblYes.Location = new System.Drawing.Point(12, 9);
            this.lblYes.Name = "lblYes";
            this.lblYes.Size = new System.Drawing.Size(157, 13);
            this.lblYes.TabIndex = 1;
            this.lblYes.Text = "Enter a temperature in Celcius : ";
            // 
            // txtInput
            // 
            this.txtInput.Location = new System.Drawing.Point(175, 6);
            this.txtInput.Name = "txtInput";
            this.txtInput.Size = new System.Drawing.Size(100, 20);
            this.txtInput.TabIndex = 2;
            // 
            // lblTemperature
            // 
            this.lblTemperature.AutoSize = true;
            this.lblTemperature.Location = new System.Drawing.Point(12, 71);
            this.lblTemperature.Name = "lblTemperature";
            this.lblTemperature.Size = new System.Drawing.Size(104, 13);
            this.lblTemperature.TabIndex = 3;
            this.lblTemperature.Text = "The temperature is : ";
            // 
            // frmTempConvert
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(355, 156);
            this.Controls.Add(this.lblTemperature);
            this.Controls.Add(this.txtInput);
            this.Controls.Add(this.lblYes);
            this.Controls.Add(this.btnConvert);
            this.Name = "frmTempConvert";
            this.Text = "Temperature Convert By : Romy I. Chu III";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnConvert;
        private System.Windows.Forms.Label lblYes;
        private System.Windows.Forms.TextBox txtInput;
        private System.Windows.Forms.Label lblTemperature;
    }
}

