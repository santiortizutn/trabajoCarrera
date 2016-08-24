using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace claseTres
{
    public class rueda
    {
        private eFRueda marca;
        public float tamaño;
        private static Random randomMarcas;
        private static Random randomTamaño;

        public rueda() // constructor.se llama igual que la clase si o si.no devuelve nada.se ejecuta una vez por objeto, cuando se crea.
        {
            
            int numero;
           // int numero2;

           // numero2 = randomTamaño.Next(0, 5);
            numero = randomMarcas.Next(0, 2);

            this.marca = (eFRueda)numero;
            this.tamaño = 5;
        }

        static rueda()
        {
            randomMarcas = new Random();
           // randomTamaño = new Random();
        }

        public void mostrarRueda()
        {
            Console.WriteLine("Tamaño: "+ this.tamaño);
            Console.WriteLine("Marca: " + this.marca);
        }
    }
}
