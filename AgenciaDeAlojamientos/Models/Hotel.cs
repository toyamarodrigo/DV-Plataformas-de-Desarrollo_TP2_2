using System;
using System.Collections.Generic;
using System.Text;

namespace AgenciaDeAlojamientos.Models
{
    class Hotel : Alojamiento
    {
        private double precioPorPersona;

        public Hotel(int codigo, string ciudad, string barrio, int estrellas, int cantidadDePersonas, bool tv, double precioPorPersona) : 
            base(codigo, ciudad, barrio, estrellas, cantidadDePersonas, tv)
        {
            this.precioPorPersona = precioPorPersona;
        }

        public override double Precio()
        {
            return this.GetPrecioPorPersona() * this.GetCantidadDePersonas();
        }

        /* GETTERS Y SETTERS */
        public double GetPrecioPorPersona()
        {
            return this.precioPorPersona;
        }

    }
}
