namespace TP_Lab_3.Test
{
    public class TestZone
    {
        private int legacyCounter = 2000;
        private College_System students = new College_System();


        [Fact]
        public void Student_load_test()
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

            var aux = students[2050];

            Assert.Equal("Jhon", aux.FirstName);
            Assert.Equal(200, students.Count());
            //Assert.Equal(2001, students.Contains(2001));
            Assert.Equal(2050, aux.Legacy);

        }
    }
}