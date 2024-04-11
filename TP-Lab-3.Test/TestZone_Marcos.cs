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
        //Variable contador de legajos
        private int legacyCounter = 20000;

        //Creacion de la coleccion basado en College_System
        //College_System hereda de KeyedCollection
        private College_System students = new College_System();

        public TestZone_Marcos()
        {
            //Carga previa de los estudiantes para la realizacion de los test
            for (int i = 0; i < 1000; i++)
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

            //Segunda carga tomando en cuenta el ultimo numero de legajo cargado
            for (int i = 0; i < 1000; i++)
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

        //Test de carga de estudiantes
        //Se cargan 2.000 de estudiantes
        [Fact]
        public void Student_load_test()
        {
            //Almacenamiento de un estudiante de ejemplo
            var aux = students[20500];

            //Variable para comprobar cumpleaños
            DateTime BirthCheck = aux.BirthDate;

            //Verificación que se cargaron los 2.000 de estudiantes
            Assert.Equal(2000, students.Count());                  

            //Comprobación que el legajo corresponda al estudiante
            Assert.Equal(20500, aux.Legacy);

            //Comprobación de datos del estudiante
            Assert.Equal("Jhon", aux.FirstName);
            Assert.Equal("Doe", aux.LastName);
            Assert.Equal(BirthCheck, aux.BirthDate);

        }

        //Test para modificar informacion de un estudiante
        //Se utiliza su legajo(Key asociada)
        [Fact]
        public void Update_or_remplace_Student_Info()
        {         
            //Carga de un estudiante x en una variable auxiliar
            var aux = students[20005];

            //Variable para comprobar cumpleaños
            DateTime BirthCheck = aux.BirthDate;
            DateTime NewBirth = new DateTime(2001, 01, 1);

            //Verificación de datos antes del cambio
            Assert.Equal("Jhon", aux.FirstName);
            Assert.Equal("Doe", aux.LastName);
            Assert.Equal(BirthCheck, aux.BirthDate);

            //Modificación de los datos
            aux.FirstName = "Pedro";
            aux.LastName = "Pascal";
            aux.BirthDate = new DateTime(2001, 01, 1);

            //Comprobación de datos despues del cambio
            Assert.Equal("Pedro", aux.FirstName);
            Assert.Equal("Pascal", aux.LastName);
            Assert.Equal(NewBirth, aux.BirthDate);

        }

        //Test para remover un estudiante
        //Se remueve en base a su legajo(Key asociada)
        [Fact]
        public void Remove_student_test()
        {
            //Comprobación que la coleccion contiene al estudiante
            Assert.True(students.Contains(20005));

            //Se remueve al estudiante segun su Key
            students.Remove(20005);

            //Comprobación de que se elimino el estudiante
            Assert.False(students.Contains(20005));
        }

        //Test para reemplazo de estudiante
        [Fact]
        public void SetItem_for_student_remplace_test()
        {
            //Carga de un estudiante x en una variable auxiliar
            var aux = students[20500];

            //Variable para comprobar cumpleaños
            DateTime BirthCheck = aux.BirthDate;

            //Verificación de datos antes del reemplazo
            Assert.Equal("Jhon", aux.FirstName);
            Assert.Equal("Doe", aux.LastName);
            Assert.Equal(BirthCheck, aux.BirthDate);

            //Llamada a la funcion para el reemplazo
            //Se pasa los datos de un nuevo estudiante para
            //reemplazar a otro
            students.ReplaceStudent(new Student(20500, "Carlos", "Santana", new DateTime(1990, 07, 23)));

            //Se cargan de nuevo los datos para verificación
            aux = students[20500];
            BirthCheck = aux.BirthDate;
            
            //Verificación de datos despues del reemplazo
            Assert.Equal("Carlos", aux.FirstName);
            Assert.Equal("Santana", aux.LastName);
            Assert.Equal(BirthCheck, aux.BirthDate);

        }
    }
}
