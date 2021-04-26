using System;
using System.Collections.Generic;
using System.Text;

namespace AgenciaDeAlojamientos.Models
{
    class Cabania : Alojamiento
    {
        private double precioPorDia;
        private int habitaciones;
        private int banios;

        public Cabania(int codigo, string ciudad, string barrio, int estrellas, int cantidadDePersonas, bool tv, double precioPorDia, int habitaciones, int banios) : 
            base(codigo, ciudad, barrio, estrellas, cantidadDePersonas, tv)
        {
            this.precioPorDia = precioPorDia;
            this.habitaciones = habitaciones;
            this.banios = banios;
        }


        public override double Precio()
        {
            return this.precioPorDia;
        }

        /* GETTERS Y SETTERS */
        public double GetPrecioPorDia()
        {
            return this.precioPorDia;
        }
        public int GetHabitaciones()
        {
            return this.habitaciones;
        }
        public int GetBanios()
        {
            return this.banios;
        }

    }
}
