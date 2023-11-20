using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    public class Telecaster : IGuitar
    {
        public Telecaster()
        {


        }
        public void GuitarType()
        {
            Console.WriteLine("This will is the Telecaster of your dreams!");
        }
    }
}
