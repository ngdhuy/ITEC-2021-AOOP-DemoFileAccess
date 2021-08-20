using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DemoMultipleForm
{
    public partial class frmTest : Form
    {
        private String userName;
        public String UserName { 
            get { return this.userName; } 
            set { 
                this.userName = value;
                lblUserName.Text = this.userName;
            } 
        }
        public frmTest()
        {
            InitializeComponent();
        }

        private void btnDone_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("DONE", "Application message", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                frmEnd frm = new frmEnd();
                this.Hide();
                frm.ShowDialog();
            }
        }
    }
}
