using AutoCheck.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutoCheck
{
    public partial class frmMain : Form
    {
        List<Question> lstQuestion = new List<Question>();
        public frmMain()
        {
            InitializeComponent();
            InitQuestion();
        }

        private void InitQuestion()
        {
            Question question = new Question();
            question.Content = "What is XML?";
            Option option_1 = new Option();
            option_1.Text = "ABC DEF";

            Option option_2 = new Option();
            option_2.Text = "456 789";

            Option option_3 = new Option();
            option_3.Text = "Hello world";

            Option option_4 = new Option();
            option_4.Text = "True answer";
            option_4.isTrue = true;

            question.Options.Add(option_1);
            question.Options.Add(option_2);
            question.Options.Add(option_3);
            question.Options.Add(option_4);

            lstQuestion.Add(question);
        }
            
        private void button1_Click(object sender, EventArgs e)
        {
            lstQuestion[0].Random();
        }
    }
}
