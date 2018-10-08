using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.Drawing;

namespace ALevelQuiz
{
    class QuestionBuilder
    {
        // POULATES A LIST CONTAINING THE QUESTIONS
        public QuestionBuilder(string SQLCMD, int NUMQs)
        {
            List<QuestionClasses> Questions = Fetch(SQLCMD, NUMQs);
            StartGUI(NUMQs, Questions);
        }

        public List<QuestionClasses> Fetch(string SQLCMD, int NUMQs)
        {
            QuestionIO ReadQuestions = new QuestionIO();
            List<QuestionClasses> Questions = ReadQuestions.Reader(SQLCMD, NUMQs);
            return Questions;
        }

        // CONSTRUCTS THE GUI FOR THE QUESTIONS
        public void StartGUI(int NUMQs, List<QuestionClasses> Questions)
        {
            // CREATES WINDOW OBJECT 
            QuestionGUI Main = new QuestionGUI();
            // INITIAL VARIABLES 
            bool Success = true;
            int IntQuestionIndex = 0;
            int Total = 0;
            // DOES THE FOLLOWING FOR EVERY QUESTION IN THE LIST
            while (Main.TabQuestions.TabCount < NUMQs)
            {
                // CREATES TABS 
                string title = "Q" + (Main.TabQuestions.TabCount + 1).ToString();
                TabPage QuestionTab = new TabPage(title);
                Main.TabQuestions.TabPages.Add(QuestionTab);
                // CREATES QUESTION LABEL 
                Label Question = new Label();
                // addressed font issue (RB13)
                Question.MaximumSize = new System.Drawing.Size(480,70);
                Question.Font = new Font("Microsoft Sans Serif", 13);
                try { Question.Text = Questions[IntQuestionIndex].OutStrQuestion(); }
                catch { Success = false; break; }
                Question.AutoSize = true;
                // CREATES NEXT BUTTON
                Button NextTab = new Button();
                NextTab.Text = "Next";
                NextTab.Location = new System.Drawing.Point(480, 170);
                NextTab.Click += (sender, args) =>
                    {
                        Main.TabQuestions.SelectedIndex = (Main.TabQuestions.SelectedIndex + 1 < Main.TabQuestions.TabCount) ?
                             Main.TabQuestions.SelectedIndex + 1 : Main.TabQuestions.SelectedIndex;
                    };
                // CREATES PREVIOUS BUTTON 
                Button PrevTab = new Button();
                PrevTab.Text = "Previous";
                PrevTab.Location = new System.Drawing.Point(0, 170);
                PrevTab.Click += (sender, args) =>
                {
                    Main.TabQuestions.SelectedIndex = (Main.TabQuestions.SelectedIndex - 1 > -1) ?
                         Main.TabQuestions.SelectedIndex -1 : Main.TabQuestions.SelectedIndex;
                };
                // CREATES FINISH BUTTON
                Button Finish = new Button();
                Finish.Text = "End Quiz";
                Finish.Location = new System.Drawing.Point(400, 170);
                // this will have to check that all questions are answered and will update the database 
                Finish.Click += (sender, args) => 
                {
                    Saving Saving = new Saving();
                    Saving.Show();
                    SaveData(Questions,Total,NUMQs);
                    Saving.Close();
                    ResultsIO ReadResults = new ResultsIO();
                    List<int> ResultsHistory = ReadResults.Read();
                    Results ResultsWindow = new Results(ResultsHistory, NUMQs);
                    Main.Close();
                    ResultsWindow.ShowDialog();
                };

                // ADDS WIDGETS TO THE WINDOW 
                QuestionTab.Controls.Add(Question);
                QuestionTab.Controls.Add(NextTab);
                QuestionTab.Controls.Add(PrevTab);
                QuestionTab.Controls.Add(Finish);

                // MULTIPLE CHOICE QUESTIONS AND TIMED MULTIPLE CHOICE QUESTIONS DO THIS:
                if (Questions[IntQuestionIndex].OutStrQuestionType() == "MC" || Questions[IntQuestionIndex].OutStrQuestionType() == "TMC")
                {
                    // DEFINES A TEMPORARY OBJECT 
                    var TempObject = (MultipleChoiceQuestion)Questions[IntQuestionIndex];
                    // Create all buttons 
                    Button AnsA = new Button();
                    Button AnsB = new Button();
                    Button AnsC = new Button();
                    Button AnsD = new Button();
                    // Add text to buttons 
                    AnsA.Text = TempObject.OutAnsA();
                    AnsB.Text = TempObject.OutAnsB();
                    AnsC.Text = TempObject.OutAnsC();
                    AnsD.Text = TempObject.OutAnsD();
                    // Give Buttons a location 
                    AnsA.Location = new System.Drawing.Point(0, 70);
                    AnsB.Location = new System.Drawing.Point(0, 120);
                    AnsC.Location = new System.Drawing.Point(310, 70);
                    AnsD.Location = new System.Drawing.Point(310, 120);
                    // Give Buttons a size 
                    AnsA.Size = new System.Drawing.Size(260, 25);
                    AnsB.Size = new System.Drawing.Size(260, 25);
                    AnsC.Size = new System.Drawing.Size(260, 25);
                    AnsD.Size = new System.Drawing.Size(260, 25);
                    // On Click 
                    AnsA.Click += (sender, args) =>
                    {
                        bool correct = TempObject.IsCorrect("A"); AnsA.Enabled = false; AnsB.Enabled = false; AnsC.Enabled = false; AnsD.Enabled = false;
                        if (correct == true) { Total++; AnsA.BackColor = Color.Green; }
                        else { AnsA.BackColor = Color.Red; string Ans = TempObject.OutStrAnswer(); switch (Ans) { case "A": AnsA.BackColor = Color.Green; break; case "B": AnsB.BackColor = Color.Green; break; case "C": AnsC.BackColor = Color.Green; break; case "D": AnsD.BackColor = Color.Green; break; } }
                    };
                    AnsB.Click += (sender, args) =>
                    {
                        bool correct = TempObject.IsCorrect("B"); AnsA.Enabled = false; AnsB.Enabled = false; AnsC.Enabled = false; AnsD.Enabled = false;
                        if (correct == true) { Total++; AnsB.BackColor = Color.Green; } 
                        else { AnsB.BackColor = Color.Red; string Ans = TempObject.OutStrAnswer(); switch (Ans) { case "A": AnsA.BackColor = Color.Green; break; case "B": AnsB.BackColor = Color.Green; break; case "C": AnsC.BackColor = Color.Green; break; case "D": AnsD.BackColor = Color.Green; break; } }
                    };
                    AnsC.Click += (sender, args) =>
                    {
                        bool correct = TempObject.IsCorrect("C"); AnsA.Enabled = false; AnsB.Enabled = false; AnsC.Enabled = false; AnsD.Enabled = false;
                        if (correct == true) { Total++; AnsC.BackColor = Color.Green; } 
                        else { AnsC.BackColor = Color.Red; string Ans = TempObject.OutStrAnswer(); switch (Ans) { case "A": AnsA.BackColor = Color.Green; break; case "B": AnsB.BackColor = Color.Green; break; case "C": AnsC.BackColor = Color.Green; break; case "D": AnsD.BackColor = Color.Green; break; } }
                    };
                    AnsD.Click += (sender, args) =>
                    {
                        bool correct = TempObject.IsCorrect("D"); AnsA.Enabled = false; AnsB.Enabled = false; AnsC.Enabled = false; AnsD.Enabled = false;
                        if (correct == true) { Total++; AnsD.BackColor = Color.Green; } 
                        else { AnsD.BackColor = Color.Red; string Ans = TempObject.OutStrAnswer(); switch (Ans) { case "A": AnsA.BackColor = Color.Green; break; case "B": AnsB.BackColor = Color.Green; break; case "C": AnsC.BackColor = Color.Green; break; case "D": AnsD.BackColor = Color.Green; break; } }
                    };

                    if (Questions[IntQuestionIndex].OutStrQuestionType() == "TMC")
                    {
                        var QuestionAsTMC = (TimedMultipleChoiceQuestion)Questions[IntQuestionIndex];
                        double TimeRemaining = (double)QuestionAsTMC.OutIntTime();
                        string Ans = QuestionAsTMC.OutStrAnswer();
                        // add a timer for timed multiple choice questions 

                        Label TimerUpdate = new Label();
                        TimerUpdate.Location = new System.Drawing.Point(480, 20);
                        Timer QuestionTimer = new Timer();
                        QuestionTimer.Interval = 100;

                        TimerUpdate.Text = IntQuestionIndex.ToString();

                        if (Main.TabQuestions.SelectedTab == QuestionTab)
                        {
                            QuestionTimer.Start();
                        }
                        else
                        {
                            QuestionTimer.Stop();
                        }                        

                        Main.TabQuestions.Selecting += (sender, args) =>

                        {
                            if (Main.TabQuestions.SelectedTab == QuestionTab)
                            {
                                QuestionTimer.Start();
                            }
                            else
                            {
                                QuestionTimer.Stop();
                            }
                        };

                        QuestionTimer.Tick += (sender, args) =>
                        { if (TimeRemaining > 0.01) { TimeRemaining-=0.1; TimerUpdate.Text = TimeRemaining.ToString("N1"); } else { TimerUpdate.Text = "Time's Up!"; AnsA.Enabled = false; AnsB.Enabled = false; AnsC.Enabled = false; AnsD.Enabled = false; switch (Ans) { case "A": AnsA.BackColor = Color.Green; break; case "B": AnsB.BackColor = Color.Green; break; case "C": AnsC.BackColor = Color.Green; break; case "D": AnsD.BackColor = Color.Green; break; } } };
                        QuestionTab.Controls.Add(TimerUpdate);


                    }
                    // add widgets to win 
                    QuestionTab.Controls.Add(AnsA);
                    QuestionTab.Controls.Add(AnsB);
                    QuestionTab.Controls.Add(AnsC);
                    QuestionTab.Controls.Add(AnsD);
    
                }

                if (Questions[IntQuestionIndex].OutStrQuestionType() == "W")
                {
                    var QuestionAsW = (WrittenQuestion)Questions[IntQuestionIndex];
                    string TrueAns = QuestionAsW.OutStrAnswer();
                    TextBox UsrAnsBox = new TextBox();
                    UsrAnsBox.Location = new System.Drawing.Point(100, 92);
                    UsrAnsBox.Size = new Size(200, 25);
                    // 
                    Label Instruct = new Label();
                    Instruct.Text = "Enter your answer into the white box and click 'Submit Answer'";
                    Instruct.Location = new Point(100, 70);
                    Instruct.AutoSize = true; 
                    Button Submit = new Button();
                    Submit.Text ="Submit Answer";
                    Submit.Size = new Size(150, 25);
                    Submit.Location = new System.Drawing.Point(310, 90);
                    Submit.Click += (sender, args) =>
                        {
                            string UsrAns = UsrAnsBox.Text;
                            if (QuestionAsW.IsCorrect(UsrAns)==true)
                            {
                                Submit.BackColor = Color.Green;
                                Total++;
                            }
                            else
                            {
                                Submit.BackColor = Color.Red;
                            }
                            Submit.Enabled = false;
                        };
                    QuestionTab.Controls.Add(Submit);
                    QuestionTab.Controls.Add(UsrAnsBox);
                    QuestionTab.Controls.Add(Instruct);
                }
                // Increments the question index 
                IntQuestionIndex++;
            }
            // RUNS WINDOW ONLY IF ALL QUESTIONS ARE POPULATED 
            if (Success == true)
            { Main.ShowDialog(); }
            else
            {
                string StrError = "Some questions were not found. It is likely they do not yet exist. Please make a different selection and report the bug";
                Error QuestionErrorWindow = new Error(StrError);
                QuestionErrorWindow.ShowDialog();
            }
            
        }
        public void SaveData(List<QuestionClasses> list,int Total, int NUMQs)
        {
            QuestionIO SaveQuestions = new QuestionIO();
            SaveQuestions.Write(list);
            int Percent = ((Total*100)/NUMQs);
            ResultsIO SaveResults = new ResultsIO();
            SaveResults.Write(Percent);
        }
    }

}