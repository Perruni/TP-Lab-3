using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_Lab_3.Test
{
    public class TestZone_Marcos
    {

        private int legacyCounter = 2000;
        private College_System students = new College_System();

        public TestZone_Marcos()
        {
            for (int i = 0; i < 1000000; i++)
            {
                var _student = new Student()
                {
                    Legacy = legacyCounter++,
                    FirstName = "Jhon",
                    LastName = "Doe",
                    BirthDate = new DateTime(2000, 01, 01)


                };

                students.Add(_student);

            }

            for (int i = 0; i < 1000000; i++)
            {
                var _student = new Student()
                {
                    Legacy = legacyCounter++,
                    FirstName = "Jane",
                    LastName = "Doe",
                    BirthDate = new DateTime(2019, 10, 01)


                };

                students.Add(_student);

            }
        }

        [Fact]
        public void Student_load_test()
        {

            var aux = students[345000];

            Assert.Equal("Jhon", aux.FirstName);
            Assert.Equal(2000000, students.Count());
            Assert.Equal(345000, aux.Legacy);

        }

        [Fact]
        public void Update_or_remplace_Student_Info()
        {

            var aux = students[200005];


            Assert.Equal("Jhon", aux.FirstName);

            var newStudent = students[200005];

            if (newStudent != null)
            {
                newStudent.FirstName = "Pedro";
                newStudent.LastName = "Pascal";
                newStudent.BirthDate = new DateTime(2001, 01, 1);
            }

            Assert.Equal("Pedro", aux.FirstName);


        }
        [Fact]
        public void Remove_student_test()
        {
            Assert.True(students.Contains(200005));

            students.Remove(200005);

            Assert.False(students.Contains(200005));
        }

        [Fact]
        public void SetItem_for_student_remplace_test()
        {        

            Assert.Equal("Jhon", students[34500].FirstName);

            students.ReplaceStudent(new Student(34500, "Carlos", "Santana", new DateTime(1990, 07, 23)));

            Assert.Equal("Carlos", students[34500].FirstName);

        }
    }
}
