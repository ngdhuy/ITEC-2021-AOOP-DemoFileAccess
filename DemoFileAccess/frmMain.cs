using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DemoFileAccess
{
    public partial class frmMain : Form
    {
        BindingList<Student> lstStudent = new BindingList<Student>();

        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            LoadStudentList();
        }

        private void LoadStudentList()
        {
            StreamReader sr = File.OpenText("Data.txt");
            int n = int.Parse(sr.ReadLine());
            for(int i = 0; i < n; i++)
            {
                String sLine = sr.ReadLine();
                String[] arrObject = sLine.Split('|');
                Student student = new Student(arrObject[0], arrObject[1], arrObject[2]);
                lstStudent.Add(student);
            }
            sr.Close();

            lbStudents.DataSource = lstStudent;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Student student = new Student();
            student.ID = lstStudent.Count + 1;
            student.Name = txtName.Text;
            student.Address = txtAddress.Text;

            lstStudent.Add(student);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            SaveStudentList();
        }

        private void SaveStudentList()
        {
            StreamWriter sw = File.CreateText("Data.txt");
            sw.WriteLine(lstStudent.Count);
            foreach(Student student in lstStudent)
            {
                String sObject = student.ID.ToString() + "|" + student.Name + "|" + student.Address;
                sw.WriteLine(sObject);
            }
            sw.Close();
        }
    }
}
