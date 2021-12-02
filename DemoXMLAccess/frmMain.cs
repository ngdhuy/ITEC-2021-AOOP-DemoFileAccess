using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace DemoXMLAccess
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
            LoadStudentListXML();
        }

        private void LoadStudentListXML()
        {
            XmlReader reader = XmlReader.Create("Data.xml");
            while(reader.ReadToFollowing("student"))
            {
                Student student = new Student();
                student.ID = int.Parse(reader.GetAttribute("id"));
                reader.ReadToFollowing("name");
                student.Name = reader.ReadElementContentAsString();
                reader.ReadToFollowing("address");
                student.Address = reader.ReadElementContentAsString();
                lstStudent.Add(student);
            }
            reader.Close();
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
            XmlWriter writer = XmlWriter.Create("Data.xml", new XmlWriterSettings() { Indent = true });
            
            writer.WriteStartElement("students");

            foreach (Student student in lstStudent)
            {
                writer.WriteStartElement("student");
                writer.WriteAttributeString("id", student.ID.ToString());

                writer.WriteStartElement("name");
                writer.WriteValue(student.Name);
                writer.WriteEndElement();

                writer.WriteStartElement("address");
                writer.WriteValue(student.Address);
                writer.WriteEndElement();

                writer.WriteEndElement();
            }

            writer.WriteEndElement();
            writer.Close();
        }
    }
}
