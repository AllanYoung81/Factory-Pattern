using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    public class DuBourgAcoustic : IGuitar
    {
        public  DuBourgAcoustic()
        {

        }

        public void GuitarType()
        {
            
            {
                Console.WriteLine("This DuBourg acoustic guitar is a beast--it's extremely resonant!"); 
            }
    }
    }
}
