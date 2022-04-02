using System;
using School.Logic;
using School.DataInfrastructure;

namespace School
{
    class Program
    {
        static void Main(string[] args)
        {
           /* Console.WriteLine("Hello World!");

            Student temp = new Student(123, "Kevin");
            Console.WriteLine(temp.Introduce());

            Teacher temp2 = new Teacher(098, "Brian");
            Console.WriteLine(temp2.Introduce());*/


            string connectionString = File.ReadAllText("LAPTOP-16481HHS/SQLEXPRESS"); //CONNECTION STRINGS GOES HERE!!

           IRepository repo = new SqlRepository(connectionString);

            School mySchool = new School(repo);

            Student tempStudent = mySchool.GetStudent(4);



           /* IEnumerable<Teacher> teacher = repo.GetAllTeachers();

            foreach (Teacher teacher in teachers)
            {
                Console.WriteLine(teacher.Introduce());
            }

            //Teacher NewTeacher = repo.CreateNewTeacher("Jerome");
            //Console.WriteLine(NewTeacher.Introduce());

            Console.WriteLine(repo.GetStudentName(4));*/

            Student tmpStudent = GetStudent(4, repo);
            Console.WriteLine(tmpStudent.Introduce());
        }

         public Student GetStudnet(int ID, IRepository repo)
        {
            return new Student(ID, repo.GetStudentName(ID));
        }
    }
}
