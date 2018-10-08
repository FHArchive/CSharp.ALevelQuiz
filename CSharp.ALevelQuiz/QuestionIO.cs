using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.OleDb;

namespace ALevelQuiz
{
    class QuestionIO
    {
        public List<QuestionClasses> Reader(string SQLCommandTxt, int NoOfQuestions)
        {
            System.Collections.Generic.List<QuestionClasses> RtrnLstQuestions = new System.Collections.Generic.List<QuestionClasses>();
            OleDbDataReader ReadOleDb = null;
            string FilePathToDatabase = "Questions.accdb";
            OleDbConnection ConnectionToDatabase = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + FilePathToDatabase);
            OleDbCommand SQLCommand = new OleDbCommand(SQLCommandTxt + "ORDER BY Rank, rnd(TimeValue(Now())*-10000000*[ID])", ConnectionToDatabase);
            try
            {
                ConnectionToDatabase.Open();
                ReadOleDb = SQLCommand.ExecuteReader();
                while (ReadOleDb.Read())
                {
                    int ID = (int)ReadOleDb["ID"];
                    string Difficulty = (string)ReadOleDb["Difficulty"];
                    string Subject = (string)ReadOleDb["Subject"];
                    string QuestionType = (string)ReadOleDb["QuestionType"];
                    string Question = (string)ReadOleDb["Question"];
                    string Answer = (string)ReadOleDb["Answer"];
                    int TimesCorrect = (int)ReadOleDb["TimesCorrect"];
                    int TotalTimesAsked = (int)ReadOleDb["TotalTimesAsked"];
                    string A = (string)ReadOleDb["A"];
                    string B = (string)ReadOleDb["B"];
                    string C = (string)ReadOleDb["C"];
                    string D = (string)ReadOleDb["D"];
                    int Time = (int)ReadOleDb["Time"];
                    //DateTime Date = (DateTime)ReadOleDb["Date"];
                    int Rank = (int)ReadOleDb["Rank"];

                    if (RtrnLstQuestions.Count < NoOfQuestions)
                    {
                        if (QuestionType == "MC")
                        { RtrnLstQuestions.Add(new MultipleChoiceQuestion(ID, QuestionType, Difficulty, Subject, Question, Answer, TimesCorrect, TotalTimesAsked, A, B, C, D, Rank)); }
                        else if (QuestionType == "TMC")
                        { RtrnLstQuestions.Add(new TimedMultipleChoiceQuestion(Time, ID, QuestionType, Difficulty, Subject, Question, Answer, TimesCorrect, TotalTimesAsked, A, B, C, D, Rank)); }
                        else if (QuestionType == "W")
                        {
                            RtrnLstQuestions.Add(new WrittenQuestion(ID, QuestionType, Difficulty, Subject, Question, Answer, TimesCorrect, TotalTimesAsked, Rank));
                            // call question builder and use class writtenquestion
                        }
                    }
                }
            }
            catch
            {
                OleDbErr Error = new OleDbErr();
                Error.ShowDialog();
            }
            finally
            {
                if (ReadOleDb != null)
                { ReadOleDb.Close(); }
                if (ConnectionToDatabase != null)
                { ConnectionToDatabase.Close(); }
                
            }
            return RtrnLstQuestions;
        }

        public void Write(List<QuestionClasses> Questions)
        {
            // create instance of oldb
            string FilePathToDatabase = "Questions.accdb";
            OleDbConnection ConnectionToDatabase = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + FilePathToDatabase);
            // for each question search for the index and overwrite some data
            for (int Question = 0; Question < Questions.Count; Question++)
            {
                string varID = Convert.ToString(Questions[Question].OutIntQuestionID());
                string varTimesCorrect = Questions[Question].OutTimesCorrect();
                string varTotalTimesAsked = Questions[Question].OutTotalTimes();
                string varDate = (DateTime.Today).ToString();
                string varRank = Questions[Question].OutRank();
                OleDbCommand SQLCommand = new OleDbCommand("UPDATE Questions SET TimesCorrect =" + varTimesCorrect + ", TotalTimesAsked =" + varTotalTimesAsked + " ,Rank = "+ varRank+" WHERE ID =" + varID, ConnectionToDatabase);
                try
                {
                    ConnectionToDatabase.Open();
                    SQLCommand.ExecuteNonQuery();  
                }
                finally
                {
                    ConnectionToDatabase.Close();
                }
            }        
        }        
    }
}
