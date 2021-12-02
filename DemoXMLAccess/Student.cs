using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoXMLAccess
{
    internal class Student
    {
        public int ID { get; set; }
        public String Name { get; set; }
        public String Address { get; set; }

        public Student()
        {
            this.ID = 0;
            this.Name = "";
            this.Address = String.Empty;
        }

        public Student(String sID, String Name, String Address)
        {
            this.ID = int.Parse(sID);
            this.Name = Name;
            this.Address = Address;
        }

        public override string ToString()
        {
            return this.ID.ToString() + ". " + this.Name + " - " + this.Address;
        }
    }
}
