﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Practica4
{
    class Neurona1
    {

        private double TASA_APRENDIZAJE = 0.5d;
        private String dato;

        private char caracter;
        private Random ran;
        public Neurona1()
        {

        }
        public void Axon(String dato)
        {
            this.dato = dato;
        }
        public char getAxon()
        {
            return this.caracter;
        }

        public void CaracterRandom()
        {
            ran = new Random();
            int posicion = this.dato.Length;
            this.caracter = this.dato[ran.Next(posicion)];
        }
    }
}
