namespace TP_Lab_3.Test
{
    public class TestZone
    {
        private int legacyCounter = 2000;
        private College_System students = new College_System();

        public TestZone()
        {
            for (int i = 0; i < 100; i++)
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

            for (int i = 0; i < 100; i++)
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

            var aux = students[2050];

            Assert.Equal("Jhon", aux.FirstName);
            Assert.Equal(200, students.Count());
            Assert.Equal(2050, aux.Legacy);

        }

        [Fact]
        public void Update_or_remplace_Student_Info()
        {

            var newStudent = students[2005];

            if (newStudent != null)
            {
                newStudent.FirstName = "Pedro";
                newStudent.LastName = "Pascal";
                newStudent.BirthDate = new DateTime(2001, 01, 1);
            }

            Assert.Equal(newStudent, students[2005]);

            students.Remove(2005);

            Assert.False(students.Contains(2005));
        }
    }
}