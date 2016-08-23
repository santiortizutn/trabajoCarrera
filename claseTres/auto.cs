using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace claseTres
{
    public class auto
    {
        public static int contadorDeObjetos;
        private eFabricante fabricante;
        private int kmRecorridos;
        private static Random randomMarcas;
        public rueda di;
        public rueda dd;
        public rueda ti;
        public rueda td;

        public auto()
        {
           // this.fabricante = "Sin fabricante. ";
            
            int numero;
            numero = randomMarcas.Next(0, 2);

            this.fabricante = (eFabricante)numero;

            this.di = new rueda();
            this.dd = new rueda();
            this.ti = new rueda();
            this.td = new rueda();

            auto.contadorDeObjetos++;
        }

        static auto() // constructor static es pivado y se ejecuta en la primer llamada a la clase.
        {
            auto.contadorDeObjetos = 0;
            randomMarcas = new Random();
        }

        public void mostrarAuto()
        {
            Console.WriteLine("El fabricante: " + this.fabricante);
        }

        public static bool compararAuto(auto a, auto b)
        {
            if (a.fabricante == b.fabricante)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void volverACero()
        {
            kmRecorridos = 0;
        }

        public void agregarKm(int km)
        {
            km += km;
        }
    }
}
