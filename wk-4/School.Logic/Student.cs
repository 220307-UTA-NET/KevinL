using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School.Logic
{
    public class Student
    {
        //Fields
        int ID;
        string Name;
        //List<course>

        //Constructor
        public Student() { }
        public Student(int ID, string name) 
        {
            this.ID = ID;
            this.Name = Name;

        }

        //Methods

        public int GetID()
        {
            return this.ID;
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

        public Student GetStudnet(int ID, IRepository repo)
        {
            return new Student(ID, repo.GetStudentName(ID));
        }
    }
}
