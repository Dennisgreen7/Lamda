using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Students
{
    
    public class Fillter
    {
        public FilterDelegate FilterByGrade { get;} = (Student student, string grade) => student.Grade == Convert.ToDecimal(grade);

        public FilterDelegate FilterByFirstName { get; } = (Student student, string firstname) => student.FirstName == firstname;

        public FilterDelegate FilterByLastName { get; } = (Student student, string lastname) => student.LastName == lastname;

        public FilterDelegate FilterById { get; } = (Student student, string id) => student.Id == id;

        public CheckDelegate GradeBelow50 { get; } = (Student student) => Convert.ToDecimal(student.Grade) < 50;

        public CheckDelegate SameFirstCharFLNames { get; } = (Student student) => student.FirstName[0] == student.LastName[0];
    }
}
