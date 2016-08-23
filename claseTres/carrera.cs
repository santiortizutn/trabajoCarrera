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

        public carrera()
        {
            this.autoUno = new auto();
            this.autoDos = new auto();
            this.autoTres = new auto();
            this.autoCuatro = new auto();
            this.autoCinco = new auto();
            this.autoSeis = new auto();


        }

        public void mostrarCarrera()
        {
            this.autoUno.mostrarAuto();
            this.autoDos.mostrarAuto();
            this.autoTres.mostrarAuto();
            this.autoCuatro.mostrarAuto();
            this.autoCinco.mostrarAuto();
            this.autoSeis.mostrarAuto();

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
 
        }
    }
}
