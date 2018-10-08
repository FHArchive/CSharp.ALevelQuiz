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
    public partial class Error : Form
    {
        public Error(string Error)
        {
            InitializeComponent();
            LblErrorMsg.Text = Error; 
            
        }

        private void Close_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
