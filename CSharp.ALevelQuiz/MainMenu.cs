using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Windows;

namespace ALevelQuiz
{
    public partial class MainMenu : Form
    {
        
        // START HERE
        public MainMenu()
        { InitializeComponent(); }
        // ABOUT BUTTON TOOLBAR
        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        { About AboutWindow = new About(); AboutWindow.ShowDialog(); }
        // HELP BUTTON TOOLBAR
        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        { Help HelpWindow = new Help(); HelpWindow.ShowDialog(); }
        // UPDATES LABEL WITH NUMBER OF QUESTIONS 
        private void NumberOfQuestionsTB_Scroll(object sender, EventArgs e)
        { int NumberOfQuestions = TBNoOfQuestions.Value * 3; LblNoOfQuestions.Text = NumberOfQuestions.ToString(); }
        // BUILDS SQL QUERY AND MOVES TO THE NEXT PART OF THE PROGRAM WHEN SUBMIT IS CLICKED 
        private void Submit_Click(object sender, EventArgs e)
        { 
            // INITIAL VARIABLES 
            string SQLCmd = "SELECT * FROM Questions WHERE";
            bool SQLSubjectError = true;
            bool SQLNeedOr = false;
            var Subjects = new List<string> { "C", "P","M","CS" };
            int NumberOfQuestions = TBNoOfQuestions.Value * 3;
            // FOR LOOP TO GENERATE SQL QUERY BASED ON THE SELECTED BOXES
            for (int CheckBoxIndex = 0; CheckBoxIndex < 4; CheckBoxIndex++)
            {
                if (ChkSubjectOptions.GetItemChecked(CheckBoxIndex) == true)
                {
                    if (SQLNeedOr == true)
                    { SQLCmd += " OR"; }
                    SQLCmd += " Subject = '"+ Subjects[CheckBoxIndex]+"'";
                    SQLSubjectError = false;
                    SQLNeedOr = true;
                }
            }
            // OPENS THE APPROPRIATE WINDOW 
            if (SQLSubjectError == false)
            { QuestionBuilder QuestionMng = new QuestionBuilder(SQLCmd, NumberOfQuestions); }
            else if (SQLSubjectError == true)
            {

                //OleDbErr Error = new OleDbErr();
                //Error.ShowDialog();

                
                string Error = "Please select one or more subjects";
                Error SQLSubjectErrorWindow = new Error(Error);
                SQLSubjectErrorWindow.ShowDialog();
                
            }
        }
    }
}
