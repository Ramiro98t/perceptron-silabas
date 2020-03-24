using System;
using System.Collections.Generic;
using System.Text;

namespace Practica4
{
    class Neurona2
    {
        private double TASA_APRENDIZAJE = 0.5d;
        private String dato;
        private String BaseConocimiento = "murcielago";
        private int totalcaracter = 0;
        private Random ran;
        public Neurona2()
        {
            ran = new Random();
        }
        public void Axon(String dato)
        {
            this.dato = dato;
        }
        public int getAxon()
        {
            return this.totalcaracter;
        }

        public char BuscaCaracter(String cadena)
        {
            totalcaracter = 0;
            char segC;

            for (int x = 0; x < this.BaseConocimiento.Length - 1; x++)
            {
                x = ran.Next(this.BaseConocimiento.Length);
                if (!cadena.Contains(this.BaseConocimiento[x]))     // Si no contiene una consonante
                {
                    segC = this.BaseConocimiento[x];

                    //totalcaracter += 1;
                    return segC;
                }
            }
            return 'f';
        }
    }
}
