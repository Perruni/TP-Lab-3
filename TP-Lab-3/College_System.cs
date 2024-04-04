using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
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
        
    }
 }

