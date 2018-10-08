using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ALevelQuiz
{

    public class QuestionClasses
    {
        int QuestionID;
        string QuestionType;
        string Difficulty;
        string Subject;
        string Question;
        string Answer;
        int TimesCorrect;
        int TotalTimes;
        DateTime Date;
        int Rank;

        public QuestionClasses(int newQuestionID, string newQuestionType, string newDifficulty, string newSubject, string newQuestion, string newAnswer, int newTimesCorrect, int newTotalTimes,  int newRank)
        {
            QuestionID = newQuestionID;
            Difficulty = newDifficulty;
            Subject = newSubject;
            Question = newQuestion;
            Answer = newAnswer;
            TimesCorrect = newTimesCorrect;
            TotalTimes = newTotalTimes;
            QuestionType = newQuestionType;
            //Date = newDate;
            Rank = newRank;
        }

        //public virtual bool IsCorrect()
        //{
        //    return true;
        //}

        // update variables
        public void UpdateTimesCorrect()
        { TimesCorrect++; }
        public void UpdateTimes()
        { TotalTimes++; }
        public void UpdateRank()
        {
            DateTime CurrentDate = DateTime.Today;
            int IntMonth = (CurrentDate.Month*100);
            int IntDay = (CurrentDate.Day);
                
            int DateAsInt = IntMonth + IntDay;
            try
            {
                Rank = Convert.ToInt32((((TimesCorrect * 100) / TotalTimes) + DateAsInt));
            }
            catch
            {
                Rank = 0 + DateAsInt;
            }
        }
        

        // outputs 
        public int OutIntQuestionID()
        { return QuestionID; }
        public string OutStrQuestionType()
        { return QuestionType; }
        public string OutStrDifficulty()
        { return Difficulty; }
        public string OutStrSubject()
        { return Subject; }
        public string OutStrQuestion()
        { return Question; }
        public string OutStrAnswer()
        { return Answer; }
        public string OutTimesCorrect()
        { return TimesCorrect.ToString(); }
        public string OutTotalTimes()
        { return TotalTimes.ToString(); }
        public string OutRank()
        { return Rank.ToString(); }


    }
    public class MultipleChoiceQuestion : QuestionClasses
    {
        string A;
        string B;
        string C;
        string D;
        public MultipleChoiceQuestion(int newQuestionID, string newQuestionType, string newDifficulty, string newSubject, string newQuestion, string newAnswer, int newTimesCorrect, int newTotalTimes, string newA, string newB, string newC, string newD, int newRank)
            : base(newQuestionID,  newQuestionType, newDifficulty, newSubject, newQuestion, newAnswer, newTimesCorrect, newTotalTimes, newRank)
        {
            A = newA;
            B = newB;
            C = newC;
            D = newD;
        }

        public string OutAnsA()
        { return A; }
        public string OutAnsB()
        { return B; }
        public string OutAnsC()
        { return C; }
        public string OutAnsD()
        { return D; }

        public bool IsCorrect(string btn)
        {
            bool Correct = false;
            if (btn == OutStrAnswer())
            {     
                UpdateTimesCorrect();
                Correct = true;
   
            }
            else
            {
            }
            UpdateRank();
            UpdateTimes();
            return Correct;
            
        }

        public void UpdateA(string Update)
        {
            A = Update;
        }
    }



    public class TimedMultipleChoiceQuestion : MultipleChoiceQuestion
    {
        int Time;
        public TimedMultipleChoiceQuestion(int newTime, int newQuestionID, string newQuestionType, string newDifficulty, string newSubject, string newQuestion, string newAnswer, int newTimesCorrect, int newTotalTimes, string newA, string newB, string newC, string newD, int newRank)
            : base(newQuestionID, newQuestionType, newDifficulty, newSubject, newQuestion, newAnswer, newTimesCorrect, newTotalTimes, newA, newB, newC, newD, newRank)
        {

            Time = newTime;
        }

        public int OutIntTime()
        { return Time; }
    }

    public class WrittenQuestion : QuestionClasses
    {
        public WrittenQuestion(int newQuestionID, string newQuestionType, string newDifficulty, string newSubject, string newQuestion, string newAnswer, int newTimesCorrect, int newTotalTimes, int newRank)
            : base(newQuestionID, newQuestionType, newDifficulty, newSubject, newQuestion, newAnswer, newTimesCorrect, newTotalTimes,  newRank)
        {

        }

        public bool IsCorrect(string UsrAns)
        {
            bool Correct = false;
            
            if (UsrAns.ToLower() == OutStrAnswer().ToLower())
            {
                UpdateTimesCorrect();
                Correct = true;
            }
            else
            {
            }
            UpdateRank();
            UpdateTimes();
            return Correct;

        }
    }
}

