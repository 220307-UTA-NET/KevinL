using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School
{
    internal class School
    {

        //Fields
        IRepository repo;

        //Consructor
        public School(IRepository repo)
        {
            this.repo = repo;
        }

        //Methods
        public Student GetStudent(int ID)
        {
            return new Student(tmpStudent, Introduce());
        }

        public string IntroduceAllTeachers()
        {
            Stringbuilder sb = new StringBuilder();
            sb.Append("*********** Introducing the Teachers of the school! ***********\n");
            IEnumerable<Teacher> teachers = repo.GetAllTeachers();
            foreach(Teacher teacher in teachers)
            {
                Console.WriteLine(teacher.Introduce());
            }
            return sb.ToString();
        }
    }
}
