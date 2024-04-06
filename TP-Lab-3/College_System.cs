using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace TP_Lab_3
{
    public class College_System : KeyedCollection<int, Student>
    {
        
        protected override int GetKeyForItem(Student student)
        {
            return student.Legacy;
        }

        //Funcion encarga del reemplazo de un estudiante, esta funcion recibe el estudiante nuevo
        public void ReplaceStudent(Student student)
        {
            //Uso de IndexOf para conseguir el indice del estudiante que se va a reemplazar
            int index = IndexOf(this[student.Legacy]);

            //Llamado a la base de SetItem que se encargara del reemplazo
            //En caso de no existir el estudiante lo agregara
            base.SetItem(index, student);         
         
        }

    }
}

