using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School.Logic
{
    public class Teacher
    {
        //Fields
        int ID;
        string Name;
        //List<course>

        //Constructor
        public Teacher() { }
        public Teacher(int ID, string name) 
        {
            this.ID = ID;
            this.Name = Name;

        }

        //Methods

        public int GetEmployeeID()
        {
            return this.EmployeeID;
        }

        public string GetName()
        {
            return this.Name;
        }

        public void SetName(string Name)
        {
            this.Name = Name;
        }

        public string Introduce()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append($"Hello,my name is {this.Name}, and I am Student{this.ID}");
            return sb.ToString();
        }
    }
}