using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    public static class GuitarFactory
    {
        public static IGuitar GetGuitar(string typeOfPickups)
        {
            switch (typeOfPickups)
            {
                case "humbuckers":
                    return new LesPaul();

                case "single coils":
                    return new Telecaster();

                case "p90s":
                    return new LesPaulJr();


                default:
                    return new DuBourgAcoustic();



            }

        }
    }
}
