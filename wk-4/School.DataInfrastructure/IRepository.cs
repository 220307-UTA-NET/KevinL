using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School.DataInfrastructure
{
    interface IRepository
    {
        // repository design pattern : implement basic CRUD operations
        // CRUD - Create, Read, Update, Delete
        // operations that the rest of the app may need, but we can abstract the implementation details.
        // advantage: it makes the rest of the program more unit-testable

        // often repositories don't "save" immediately, instead using a special save method
        // to wrap all the changes into one transaction.

        // sometimes one repository per "entity", per type of thing we want to track in the DB
        // transactions across multiple repositories/entites requires the "unit of work" design pattern
        // which manages multiple repositories, and saves the changes of all of them at once.

        public interface IRepository
        {
            // an interface is a contract,that defines a set of conditions.
            // it can contains methods, properties, or events
            // but it does not fully define them, only provides the signature
            //  Access-Modifier Return-Type Method-Name (Parameter types/names)
            // in C#, we can use multiple Interfaces to simulate multiple-inheritance
            IEnumerable<Teacher> GetAllTeachers();
            Teacher CreateNewTeacher(Teacher NewTeacher);

            string GetStudentName(int ID)
        }
            
          


    }
}
