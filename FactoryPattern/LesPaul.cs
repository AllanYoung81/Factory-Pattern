using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    public class LesPaul : IGuitar
    {
        public  LesPaul() 
        { 
        
        }

        public void GuitarType()
        {
            Console.WriteLine("This Les Paul is the Holy Grail of electric guitars!");
        }
    }
}
