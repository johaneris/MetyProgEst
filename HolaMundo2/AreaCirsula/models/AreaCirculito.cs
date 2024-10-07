using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AreaCirsula.models
{
    internal class AreaCirculito
    {
        //primero se crea un constructor
        private const double pi = 3.14;
        public AreaCirculito(double radio)
        {

           double area = pi * (radio * radio);
        }
    }
}
