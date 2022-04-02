using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace school.Logic
{
    //Fields
    string CourseID;
    string CourseName;
    int TeacherID;
    DateTime StartDate;
    DateTime EndDate;

    //List<students>?
    public Course() { }
    public Course(string CourseID, string CourseName, int TeacherID, DateTime StartDate, DateTime EndDate)
    {
        this.CourseID = CourseID;
        this.CourseName = CourseName;
        this.TeacherID = TeacherID;
        this.StartDate = StartDate;
        this.EndDate = EndDate;
    }

    //Constructor

    //Methods
    public string GetCourseID()
    { return this.CourseID; }

    public string GetCourseName()
    { return this.CourseName; }

    public int GetTeacherID()
    { return this.TeacherID; }

    public DateTime GetStartDate()
    { return this.StartDate; }

    public DateTime GetEndDate()
    { return this.EndDate; }

}