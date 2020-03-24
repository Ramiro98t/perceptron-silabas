using System;


namespace Practica4
{
    class Perceptron
    {
        Neurona3 n3;
        public Perceptron()
        {
            n3 = new Neurona3();
            n3.Dato = ("bcdfghjklmnñpqrstvwxyz");
            n3.Platica();
        }
        static void Main(string[] args)
        {
            new Perceptron();
        }
    }
}
