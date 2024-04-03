using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_Lab_3
{
    public class Student : Person
    {
        public int Legacy { get; set; }

        public Student(int legacy, string firstName, string lastName, DateTime birthDate)
        {
            Legacy = legacy;
            FirstName = firstName;
            LastName = lastName;
            BirthDate = birthDate;

        }

        public Student()
        {
        }
    }
}
