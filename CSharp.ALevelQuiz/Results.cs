using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ALevelQuiz
{
    public partial class Results : Form
    {
        public Results(List<int> ResultsHistory, int NoOfQuestions)
        {
            InitializeComponent();
            for (int Index = 0; Index < 10; Index++)
            {
                try
                {
                    ResultsChart.Series["Series"].Points.AddXY(9 - Index, ResultsHistory[(ResultsHistory.Count - 1) - Index]);
                }
                catch
                {

                }
            }
            LblResults.Text = "Well Done! You got "+(ResultsHistory[ResultsHistory.Count-1]).ToString()+"% correct";
        }
    }
}
