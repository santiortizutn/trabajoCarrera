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
        private static Random randomFabricante;
        public rueda ruedaDI;
        public rueda ruedaDD;
        public rueda ruedaTI;
        public rueda ruedaTD;

        public auto()
        {
           // this.fabricante = "Sin fabricante. ";
            
            int numero;
            numero = randomFabricante.Next(0, 6);

            this.fabricante = (eFabricante)numero;

            this.ruedaDI = new rueda();
            this.ruedaDD = new rueda();
            this.ruedaTI = new rueda();
            this.ruedaTD = new rueda();

            auto.contadorDeObjetos++;
        }

        static auto() // constructor static es pivado y se ejecuta en la primer llamada a la clase.
        {
            auto.contadorDeObjetos = 0;
            randomFabricante = new Random();
        }

        public void mostrarAuto()
        {
            Console.WriteLine("--AUTO--");
            Console.WriteLine("El fabricante: " + this.fabricante);
            Console.WriteLine("Rueda DI: ");
            this.ruedaDI.mostrarRueda();
            this.ruedaDD.mostrarRueda();
            this.ruedaTI.mostrarRueda();
            this.ruedaTD.mostrarRueda();
            Console.WriteLine("km recorridos: " + this.kmRecorridos);
            Console.WriteLine();
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
            this.kmRecorridos = 0;
        }

        public void agregarKm(int km)
        {
            this.kmRecorridos = this.kmRecorridos + km;
        }

        public int retornarKm()
        {
            return this.kmRecorridos;
        }
    }
}
