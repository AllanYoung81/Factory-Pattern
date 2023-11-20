using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    public class LesPaulJr : IGuitar
    {

        public LesPaulJr()
        {

        }
        public void GuitarType()
        {
            Console.WriteLine("This Les Paul Jr. snarls--it's the best of both worlds!");
        }
    }
}
