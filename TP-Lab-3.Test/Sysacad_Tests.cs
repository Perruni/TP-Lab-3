using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace TP_Lab_3.Test
{
    public class Sysacad_Tests

    {  
        private College_System _sysacad = new College_System();

        
        public Sysacad_Tests()
        {
            _sysacad = new College_System();
            int legajos = 23000;
            do
            {
                _sysacad.Add(new Student(legajos, "Juan", "Malveira", new DateTime(2002, 1, 18)));
                ++legajos;

            } while (legajos < 24000);
        }



        [Fact]
        public void dostuff()
        {

        }

    }
}


