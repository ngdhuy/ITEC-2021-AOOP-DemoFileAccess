using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DemoChangeQuestion
{
    public partial class frmMain : Form
    {
        private BindingList<String> lstQuestion = new BindingList<String>();
        private int currentQuestionIndex;

        public int CurrrentQuestionIndex
        {
            get { return currentQuestionIndex; }
            set { 
                currentQuestionIndex = value; 
                txtQuestion.Text = lstQuestion[currentQuestionIndex].ToString();
            }
        }

        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            for(int i = 0; i < 10; i++)
            {
                String sQuestion = "Quest at " + i.ToString();
                lstQuestion.Add(sQuestion);
            }
            this.CurrrentQuestionIndex = 0;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            if (CurrrentQuestionIndex <= 0)
                MessageBox.Show("Cannot navigate to below 0", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
                this.CurrrentQuestionIndex--;
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (CurrrentQuestionIndex >= lstQuestion.Count - 1)
                MessageBox.Show("Cannot navigate out of range", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
                this.CurrrentQuestionIndex++;
        }
    }
}
