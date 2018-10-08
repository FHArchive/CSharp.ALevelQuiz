namespace ALevelQuiz
{
    partial class Error
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
            this.LblTitle = new System.Windows.Forms.Label();
            this.LblErrorMsg = new System.Windows.Forms.Label();
            this.BtnClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LblTitle
            // 
            this.LblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTitle.Location = new System.Drawing.Point(0, 0);
            this.LblTitle.Name = "LblTitle";
            this.LblTitle.Size = new System.Drawing.Size(200, 39);
            this.LblTitle.TabIndex = 30;
            this.LblTitle.Text = "Error";
            // 
            // LblErrorMsg
            // 
            this.LblErrorMsg.AutoSize = true;
            this.LblErrorMsg.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblErrorMsg.Location = new System.Drawing.Point(0, 39);
            this.LblErrorMsg.MaximumSize = new System.Drawing.Size(200, 1000);
            this.LblErrorMsg.MinimumSize = new System.Drawing.Size(200, 0);
            this.LblErrorMsg.Name = "LblErrorMsg";
            this.LblErrorMsg.Size = new System.Drawing.Size(200, 16);
            this.LblErrorMsg.TabIndex = 31;
            this.LblErrorMsg.Text = "\r\n";
            // 
            // BtnClose
            // 
            this.BtnClose.Location = new System.Drawing.Point(0, 110);
            this.BtnClose.Name = "BtnClose";
            this.BtnClose.Size = new System.Drawing.Size(200, 23);
            this.BtnClose.TabIndex = 32;
            this.BtnClose.Text = "Close ";
            this.BtnClose.UseVisualStyleBackColor = true;
            this.BtnClose.Click += new System.EventHandler(this.Close_Click);
            // 
            // Error
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.BtnClose);
            this.Controls.Add(this.LblErrorMsg);
            this.Controls.Add(this.LblTitle);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Error";
            this.Text = "SQLError";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblTitle;
        private System.Windows.Forms.Label LblErrorMsg;
        private System.Windows.Forms.Button BtnClose;
    }
}