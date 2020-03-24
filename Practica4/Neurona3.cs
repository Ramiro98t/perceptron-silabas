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
        public String Dato { get => dato; set => dato = value; }

        public void Platica()
        {
            String respuesta = "";
            n1.Axon(dato);          // Manda a neurona 1 la cadena de caracteres a buscar
            n1.CaracterRandom();    // Genera un caracter random dentro de la cadena anterior
            char c = n1.getAxon();  // Retorna el caracter generado aleatoriamente
            Console.WriteLine("[Neurona 1]  Tienes el Caracter: " + c);
            Thread.Sleep(1000);

            char x = n2.BuscaCaracter(dato);
            Console.WriteLine("[Neurona 2]  Tienes el Caracter: " + x);
            if (x != 'f')
            {
                respuesta = "[Silaba] : " + c + x;
            }
            else
                respuesta = "No hay Posibles silabas";

            Console.WriteLine(respuesta);
            //Console.WriteLine("[Neurona 2] Caracter encontrados: " + respuesta);
            Thread.Sleep(1000);
            Platica();
        }
    }
}
