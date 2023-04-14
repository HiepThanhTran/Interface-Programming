using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LTGD_BaiThucHanh6.model
{
    internal class Student
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Id { get; set; }

        public Student() { }

        public Student(string firstName, string lastName, string id)
        {
            FirstName = firstName;
            LastName = lastName;
            Id = id;
        }
    }
}
