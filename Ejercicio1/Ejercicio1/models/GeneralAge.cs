using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1.models
{
    internal class GeneralAge
    {
        //modificadores de acceso, me permetien acceder o no a un objrto
        private int[] ages = new int[10];

        //decirle la poscion
        public void AddElement(int age, int pos)
        {

            ages[pos] = age;    
        }

        public int[] GetElements()
        {
            return ages;
        }

        
    }


}
