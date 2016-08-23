using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace claseTres
{
    public class Program
    {
        static void Main(string[] args)
        {
           /* eFabricante fabricante;
            fabricante = eFabricante.Honda;

            Console.WriteLine(fabricante);
            fabricante = (eFabricante)1;
            
            Console.WriteLine(fabricante);
            
            
            rueda nuevaRueda;
            nuevaRueda = new rueda(); // es la llamada a un constructor, va hasta la calse y lo ejecuta.

            auto nuevoAuto = new auto();
            auto autoDos = new auto();
            auto autoTres = new auto();
            auto autoCuatro = new auto();
            */

            carrera nuevaCarrera;
            nuevaCarrera = new carrera();

            nuevaCarrera.mostrarCarrera();

            
            Console.ReadKey();
        }
    }
}
