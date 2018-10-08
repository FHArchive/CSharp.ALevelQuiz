namespace ALevelQuiz
{
    partial class MainMenu
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
            this.MenuStrip = new System.Windows.Forms.MenuStrip();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.LblTitle = new System.Windows.Forms.Label();
            this.GrpSubject = new System.Windows.Forms.GroupBox();
            this.ChkSubjectOptions = new System.Windows.Forms.CheckedListBox();
            this.GrpNoOfQuestions = new System.Windows.Forms.GroupBox();
            this.LblNoOfQuestions = new System.Windows.Forms.Label();
            this.TBNoOfQuestions = new System.Windows.Forms.TrackBar();
            this.LblStatic1 = new System.Windows.Forms.Label();
            this.BtnSubmit = new System.Windows.Forms.Button();
            this.MenuStrip.SuspendLayout();
            this.GrpSubject.SuspendLayout();
            this.GrpNoOfQuestions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TBNoOfQuestions)).BeginInit();
            this.SuspendLayout();
            // 
            // MenuStrip
            // 
            this.MenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.MenuStrip.Location = new System.Drawing.Point(0, 0);
            this.MenuStrip.Name = "MenuStrip";
            this.MenuStrip.Size = new System.Drawing.Size(359, 24);
            this.MenuStrip.TabIndex = 0;
            this.MenuStrip.Text = "menuStrip1";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(55, 20);
            this.aboutToolStripMenuItem.Text = "About ";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            this.helpToolStripMenuItem.Click += new System.EventHandler(this.helpToolStripMenuItem_Click);
            // 
            // LblTitle
            // 
            this.LblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTitle.Location = new System.Drawing.Point(1, 26);
            this.LblTitle.Name = "LblTitle";
            this.LblTitle.Size = new System.Drawing.Size(162, 39);
            this.LblTitle.TabIndex = 24;
            this.LblTitle.Text = "Main Menu";
            // 
            // GrpSubject
            // 
            this.GrpSubject.Controls.Add(this.ChkSubjectOptions);
            this.GrpSubject.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GrpSubject.Location = new System.Drawing.Point(7, 68);
            this.GrpSubject.Name = "GrpSubject";
            this.GrpSubject.Size = new System.Drawing.Size(200, 113);
            this.GrpSubject.TabIndex = 25;
            this.GrpSubject.TabStop = false;
            this.GrpSubject.Text = "Please select a topic to be tested on:";
            // 
            // ChkSubjectOptions
            // 
            this.ChkSubjectOptions.CheckOnClick = true;
            this.ChkSubjectOptions.FormattingEnabled = true;
            this.ChkSubjectOptions.Items.AddRange(new object[] {
            "Chemistry",
            "Physics",
            "Maths ",
            "Computer Science"});
            this.ChkSubjectOptions.Location = new System.Drawing.Point(7, 35);
            this.ChkSubjectOptions.Name = "ChkSubjectOptions";
            this.ChkSubjectOptions.Size = new System.Drawing.Size(187, 72);
            this.ChkSubjectOptions.TabIndex = 0;
            // 
            // GrpNoOfQuestions
            // 
            this.GrpNoOfQuestions.Controls.Add(this.LblNoOfQuestions);
            this.GrpNoOfQuestions.Controls.Add(this.TBNoOfQuestions);
            this.GrpNoOfQuestions.Controls.Add(this.LblStatic1);
            this.GrpNoOfQuestions.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GrpNoOfQuestions.Location = new System.Drawing.Point(7, 187);
            this.GrpNoOfQuestions.Name = "GrpNoOfQuestions";
            this.GrpNoOfQuestions.Size = new System.Drawing.Size(200, 125);
            this.GrpNoOfQuestions.TabIndex = 26;
            this.GrpNoOfQuestions.TabStop = false;
            this.GrpNoOfQuestions.Text = "Please select the number of questions that you would like to be asked:";
            // 
            // LblNoOfQuestions
            // 
            this.LblNoOfQuestions.Location = new System.Drawing.Point(135, 100);
            this.LblNoOfQuestions.Name = "LblNoOfQuestions";
            this.LblNoOfQuestions.Size = new System.Drawing.Size(31, 15);
            this.LblNoOfQuestions.TabIndex = 2;
            this.LblNoOfQuestions.Text = "3";
            // 
            // TBNoOfQuestions
            // 
            this.TBNoOfQuestions.LargeChange = 1;
            this.TBNoOfQuestions.Location = new System.Drawing.Point(7, 53);
            this.TBNoOfQuestions.Maximum = 8;
            this.TBNoOfQuestions.Minimum = 1;
            this.TBNoOfQuestions.Name = "TBNoOfQuestions";
            this.TBNoOfQuestions.Size = new System.Drawing.Size(187, 45);
            this.TBNoOfQuestions.TabIndex = 1;
            this.TBNoOfQuestions.Tag = "";
            this.TBNoOfQuestions.Value = 1;
            this.TBNoOfQuestions.Scroll += new System.EventHandler(this.NumberOfQuestionsTB_Scroll);
            // 
            // LblStatic1
            // 
            this.LblStatic1.Location = new System.Drawing.Point(4, 99);
            this.LblStatic1.Name = "LblStatic1";
            this.LblStatic1.Size = new System.Drawing.Size(162, 15);
            this.LblStatic1.TabIndex = 28;
            this.LblStatic1.Text = "Number of questions:";
            // 
            // BtnSubmit
            // 
            this.BtnSubmit.Location = new System.Drawing.Point(7, 318);
            this.BtnSubmit.Name = "BtnSubmit";
            this.BtnSubmit.Size = new System.Drawing.Size(200, 23);
            this.BtnSubmit.TabIndex = 27;
            this.BtnSubmit.Text = "GO!";
            this.BtnSubmit.UseVisualStyleBackColor = true;
            this.BtnSubmit.Click += new System.EventHandler(this.Submit_Click);
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(359, 501);
            this.Controls.Add(this.BtnSubmit);
            this.Controls.Add(this.GrpNoOfQuestions);
            this.Controls.Add(this.GrpSubject);
            this.Controls.Add(this.LblTitle);
            this.Controls.Add(this.MenuStrip);
            this.MainMenuStrip = this.MenuStrip;
            this.MaximizeBox = false;
            this.Name = "MainMenu";
            this.Text = "Main Menu";
            this.MenuStrip.ResumeLayout(false);
            this.MenuStrip.PerformLayout();
            this.GrpSubject.ResumeLayout(false);
            this.GrpNoOfQuestions.ResumeLayout(false);
            this.GrpNoOfQuestions.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TBNoOfQuestions)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip MenuStrip;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.Label LblTitle;
        private System.Windows.Forms.GroupBox GrpSubject;
        private System.Windows.Forms.CheckedListBox ChkSubjectOptions;
        private System.Windows.Forms.GroupBox GrpNoOfQuestions;
        private System.Windows.Forms.TrackBar TBNoOfQuestions;
        private System.Windows.Forms.Label LblNoOfQuestions;
        private System.Windows.Forms.Button BtnSubmit;
        private System.Windows.Forms.Label LblStatic1;

    }
}

