using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AsynchronousExample
{
    public partial class AsynchronousQuiz : Form
    {
        public AsynchronousQuiz()
        {
            InitializeComponent();
        }

      

        private void Start_Click(object sender, EventArgs e)
        {
            panel1.Hide();
            Quizonepanel.Show();
        }
    }
}
