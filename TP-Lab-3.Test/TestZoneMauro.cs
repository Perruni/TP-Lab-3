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
            // Primero se verifica si el sistema contiene un estudiante con el número de legajo 23500
            Assert.True(sysacad.Contains(23500));
            // Luego se elimina un estudiante de la posición 500
            sysacad.RemoveAt(500);
            // Finalmente se verificar que el estudiante con el número de legajo 23500
            // ya no se encuentre después de la eliminación
            Assert.False(sysacad.Contains(23500));


        }

        [Fact]
        public void InsertItem_Test()
        {
            // Primero se inserta un nuevo estudiante en la posicion deseada  por ejemplo 500.
            sysacad.Insert_student(500, new Student(1, "Nuevo", "Estudiante", new DateTime(2003, 5, 10)));
            // Luego se verifica si el sistema académico contiene al estudiante que acabamos de insertar.
            Assert.True(sysacad.Contains(1));
        }

        //Este es un metodo que combina la funcionalidad de eliminación e inserción de la clase

        [Fact]
        public void Remove_and_Insert_Test()
        {
            //Se verifica si el sistema contiene un estudiante con el número de legajo 23500
            Assert.True(sysacad.Contains(23500));
            // Se elimina a un estudiante de la posición 500
            sysacad.RemoveAt(500);
            // Se verificar que el estudiante con el número de legajo 23500
            // ya no se encuentre después de la eliminación
            Assert.False(sysacad.Contains(23500));
            // Se inserta un nuevo estudiante con el número de legajo 23500 en la posición 500
            sysacad.Insert_student(500, new Student(23500, "Nuevo", "Estudiante", new DateTime(2003, 5, 10)));
            // Finalmente se comprobar que el estudiante con el número de legajo 23500
            // esté presente después de la inserción
            Assert.True(sysacad.Contains(23500));

        }
    }
}