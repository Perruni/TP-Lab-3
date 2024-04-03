using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_Lab_3
{
    public class Person
    {
        public string FirstName
        { get; set; }

        public string LastName 
        { get; set; }

        public DateTime BirthDate
        { get; set; }

        private int age
        {get; set;}
        public int Age
        {
            get
            {
                DateTime fechaActual = DateTime.Now;
                this.age = fechaActual.Year - BirthDate.Year;

                if (BirthDate > (fechaActual.AddYears(-this.age)))
                {
                    this.age--;
                }

                return this.age;
            }
        }
        public override string ToString()
        {
            return $"{FirstName} {LastName} {Age}";
        }

        public string FullName()
        {
            return $"{FirstName} {LastName}";
        }



    }
}
