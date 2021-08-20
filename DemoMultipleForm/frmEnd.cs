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
    public partial class frmEnd : Form
    {
        public frmEnd()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void frmEnd_Load(object sender, EventArgs e)
        {
            lblUser.Text = User.Name;
        }
    }
}
