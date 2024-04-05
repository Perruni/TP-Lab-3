using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace TP_Lab_3.Test
{
    public class TestZone_JuanMa
    {
        private readonly College_System _sysacad;
        public TestZone_JuanMa()
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
        public void TestZone_Juanma_sysacad_addStudent()
        {
            //crea un estudiante
            var std = new Student(25000, "Juan", "Malveira", new DateTime(2002, 1, 18));
            //Inserta en el Collection
            _sysacad.Insert(2, std);
            //Lo inserta?
            Assert.True(_sysacad.Contains(25000));
            //Reemplaza el anterior o solo lo incrusta en esa posicion?
            Assert.Equal(1001, _sysacad.Count);
            //  .Insert() incrusta el item y actualiza el indice del resto
        }

        [Fact]
        public void TestZone_JuanMa_sysacad_Clear()
        {
            //Llamada al método que limpia la collection existente
            _sysacad.Clear();

            //Creamos una nueva KeyedCollection
            College_System _emptySysacad = new();
            //Llamada al método clear desde la collection nueva
            _emptySysacad.Clear();

            //El metodo no vuelve null las collection, porque ya estan creadas
            Assert.False(_sysacad == null);
            Assert.False(_emptySysacad == null);

            //Si vacia de elementos la Collection cargada
            Assert.True(_sysacad.Count()==0);
            
            //Para una Collection vacía no tiene conflictos
            Assert.True(_emptySysacad.Count() == 0);
        }
    }
}
