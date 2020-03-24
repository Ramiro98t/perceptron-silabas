using System;
using System.Threading;
using System.Collections.Generic;
using System.Text;

namespace Practica4
{
    class Neurona3
    {
        private String dato;
        private Neurona1 n1;
        private Neurona2 n2;
        public Neurona3()
        {
            n1 = new Neurona1();
            n2 = new Neurona2();
        }
        public void Axon(String dato)
        {
            this.dato = dato;
        }
        public String getAxon()
        {
            return dato;
        }
        public void Platica()
        {
            String respuesta = "";
            n1.Axon(dato);
            n1.CaracterRandom();
            char c = n1.getAxon();
            Console.WriteLine("[Neurona 1]  Tienes el Caracter: " + c);
            Thread.Sleep(1000);
            n2.BuscaCaracter(c);
            if (n2.getAxon() == 0)
                respuesta = "No hay Coincidencias";
            else
                respuesta = "Si hay Coincidencias";
            Console.WriteLine("[Neurona 2] Caracter encontrados: " + respuesta);
            Thread.Sleep(1000);
            Platica();
        }
    }
}
