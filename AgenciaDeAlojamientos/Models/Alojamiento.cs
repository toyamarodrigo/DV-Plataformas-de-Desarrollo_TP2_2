using System;
using System.Collections.Generic;
using System.Text;

namespace AgenciaDeAlojamientos.Models
{
    abstract class Alojamiento
    {
        public const int MAXIMO_NUMERO_DE_ESTRELLAS = 5;
        public const int MINIMO_NUMERO_DE_ESTRELLAS = 1;

        private int codigo;
        private String ciudad;
        private String barrio;
        private int estrellas;
        private int cantidadDePersonas;
        private bool tv;
    
        public Alojamiento(int codigo, String ciudad, String barrio, int estrellas, int cantidadDePersonas, bool tv )
        {
            this.codigo = codigo;
            this.ciudad = ciudad;
            this.barrio = barrio;
            this.estrellas = estrellas;
            this.cantidadDePersonas= cantidadDePersonas;
            this.tv= tv;
        }
    
        public static bool ValidarEstrellas(int estrellas)
        {
            return Alojamiento.MINIMO_NUMERO_DE_ESTRELLAS >= estrellas && estrellas <= Alojamiento.MAXIMO_NUMERO_DE_ESTRELLAS;
        }

        public bool IgualCodigo(Alojamiento alojamiento)
        {
            return alojamiento.GetCodigo() == this.GetCodigo();
        }

        /* METODOS AGREGADOS */
        public List<String> GetAlojamientoInLista()
        {
            return new List<string>() { 
                this.GetCodigo().ToString(),
                this.GetCiudad().ToString(), 
                this.GetBarrio(), 
                this.GetEstrellas().ToString(), 
                this.GetCantidadDePersonas().ToString(), 
                this.GetTV() ? "si" : "no",
                this.Precio().ToString()
            };
        }

        /* METODOS ABSTRACTOS */
        public abstract double Precio();

        /* GETTERS Y SETTERS */
        public int GetCodigo()
        {
            return this.codigo;
        }
        public String GetCiudad()
        {
            return this.ciudad;
        }
        public String GetBarrio()
        {
            return this.barrio;
        }
        public int GetEstrellas()
        {
            return this.estrellas;
        }
        public int GetCantidadDePersonas()
        {
            return this.cantidadDePersonas;
        }
        public bool GetTV()
        {
            return this.tv;
        }

    }
}
