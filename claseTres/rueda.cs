using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace claseTres
{
    public class rueda
    {
        public string marca;
        public float tamaño;

        public rueda() // constructor.se llama igual que la clase si o si.no devuelve nada.se ejecuta una vez por objeto, cuando se crea.
        {
            this.marca = "Sin marca";
        }

        public void mostrarTamaño()
        {
            Console.WriteLine("Tamaño: "+ tamaño);
        }
    }
}
