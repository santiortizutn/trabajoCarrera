using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace claseTres
{
    public class carrera
    {
        public auto autoUno;
        public auto autoDos;
        public auto autoTres;
        public auto autoCuatro;
        public auto autoCinco;
        public auto autoSeis;
        public Random randomKm;
        public int maximo = 0;
        public int minimo = 0;

        public carrera()
        {
            randomKm = new Random();
            this.autoUno = new auto();
            this.autoDos = new auto();
            this.autoTres = new auto();
            this.autoCuatro = new auto();
            this.autoCinco = new auto();
            this.autoSeis = new auto();


        }

        public void mostrarCarrera()
        {
            this.porTiempo(10);
            this.autoUno.mostrarAuto();
            this.autoDos.mostrarAuto();
            this.autoTres.mostrarAuto();
            this.autoCuatro.mostrarAuto();
            this.autoCinco.mostrarAuto();
            this.autoSeis.mostrarAuto();

            Console.WriteLine("Maximo km recorridos: " + this.maximo);
            Console.WriteLine("Minimo km recorridos: " + this.minimo);

        }

        public void porTiempo(int minutos)
        {
            int contador;
            for (contador = 0; contador < minutos; contador++)
            {
                this.autoUno.agregarKm(randomKm.Next(10, 100));
                this.autoDos.agregarKm(randomKm.Next(10, 100));
                this.autoTres.agregarKm(randomKm.Next(10, 100));
                this.autoCuatro.agregarKm(randomKm.Next(10, 100));
                this.autoCinco.agregarKm(randomKm.Next(10, 100));
                this.autoSeis.agregarKm(randomKm.Next(10, 100));
            }

            maximo = this.autoUno.retornarKm();
            minimo = this.autoUno.retornarKm();

            if (this.autoDos.retornarKm() < minimo)
                minimo = this.autoDos.retornarKm();

            if (this.autoDos.retornarKm() > maximo)
                maximo = this.autoDos.retornarKm();

            if (this.autoTres.retornarKm() < minimo)
                minimo = this.autoTres.retornarKm();

            if (this.autoTres.retornarKm() > maximo)
                maximo = this.autoTres.retornarKm();

            if (this.autoCuatro.retornarKm() < minimo)
                minimo = this.autoCuatro.retornarKm();

            if (this.autoCuatro.retornarKm() > maximo)
                maximo = this.autoCuatro.retornarKm();

            if (this.autoCinco.retornarKm() < minimo)
                minimo = this.autoCinco.retornarKm();

            if (this.autoCinco.retornarKm() > maximo)
                maximo = this.autoCinco.retornarKm();

            if (this.autoSeis.retornarKm() < minimo)
                minimo = this.autoSeis.retornarKm();

            if (this.autoSeis.retornarKm() > maximo)
                maximo = this.autoSeis.retornarKm();
 
        }
    }
}
