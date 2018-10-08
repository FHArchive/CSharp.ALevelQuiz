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
    public partial class QuestionGUI : Form
    {
        public QuestionGUI()
        {
            InitializeComponent();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            About AboutWindow = new About();
            AboutWindow.ShowDialog();
        }

        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Help HelpWindow = new Help();
            HelpWindow.ShowDialog();
        }
    }
}
