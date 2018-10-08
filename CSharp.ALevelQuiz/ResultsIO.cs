using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace ALevelQuiz
{
    class ResultsIO
    {
        public List<int> Read()
        {
            String line;
            List<int> RtrnLstResults = new List<int>();
            StreamReader File = new StreamReader("Results.txt");
            line = File.ReadLine();
            while (line != null)
            {
                RtrnLstResults.Add(Convert.ToInt32(line));
                line = File.ReadLine();
            }
            File.Close();
            return RtrnLstResults;
        }

        public void Write(int Result)
        {
            StreamWriter File = new StreamWriter("Results.txt", true, Encoding.ASCII);
            File.Write(Result + Environment.NewLine);
            File.Close(); 
        }  
    }
}
