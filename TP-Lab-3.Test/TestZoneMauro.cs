using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace TP_Lab_3.Test
{
    public class TestZoneMauro
    {
        private College_System sysacad;
        public TestZoneMauro()
        {
            sysacad = new College_System();
            int legajos = 23000;
            do
            {
                sysacad.Add(new Student(legajos, "Juan", "Malveira", new DateTime(2002, 1, 18)));
                ++legajos;

            } while (legajos < 24000);
        }

        [Fact]
        public void removeAt_Test()
        {

            Assert.True(sysacad.Contains(23500));

            sysacad.RemoveAt(500);

            Assert.False(sysacad.Contains(23500));


        }

        [Fact]
        public void InsertItem_Test()
        {

            sysacad.Insert_student(500, new Student(1, "Nuevo", "Estudiante", new DateTime(2003, 5, 10)));

            Assert.True(sysacad.Contains(1));
        }

        [Fact]
        public void Remove_and_Insert_Test()
        {

            Assert.True(sysacad.Contains(23500));

            sysacad.RemoveAt(500);

            Assert.False(sysacad.Contains(23500));

            sysacad.Insert_student(500, new Student(23500, "Nuevo", "Estudiante", new DateTime(2003, 5, 10)));

            Assert.True(sysacad.Contains(23500));

        }
    }
}