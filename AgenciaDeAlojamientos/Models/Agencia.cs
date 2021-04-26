
using System;
using System.Collections.Generic;

namespace AgenciaDeAlojamientos.Models
{
    class Agencia
    {

        private List<Alojamiento> alojamientos;
        private int cantidadDeAlojamientos;

        public Agencia()
        {
            this.alojamientos = new List<Alojamiento>();
            this.cantidadDeAlojamientos = 0;
        }
        
        // TODO: modificarAlojamiento y eliminarAlojamiento incompletos
        public bool AgregarAlojamiento(Alojamiento alojamiento)
        {
            if (this.ExisteAlojamiento(alojamiento)) return false;

            this.alojamientos.Add(alojamiento);
            this.cantidadDeAlojamientos++;
            return true;
        }
        public bool ModificarAlojamiento(Alojamiento alojamiento)
        {
            Alojamiento al = this.FindAlojamientoForCodigo(alojamiento.GetCodigo());

            if (!this.EliminarAlojamiento(al)) return false;

            if (this.AgregarAlojamiento(alojamiento)) return true;

            return false;
        }
        public bool EliminarAlojamiento(Alojamiento alojamiento)
        {
            if (!this.ExisteAlojamiento(alojamiento)) return false;

            this.alojamientos.Remove(alojamiento);
            this.cantidadDeAlojamientos--;
            return true;
        }

        public Agencia GetHoteles()
        {
            Agencia agencia = new Agencia();
            foreach(Alojamiento al in this.alojamientos)
            {
                if( al is Hotel)
                {
                    agencia.AgregarAlojamiento(al);
                }
            }
            return agencia;
        }
        public Agencia GetCabanias()
        {
            Agencia agencia = new Agencia();
            foreach (Alojamiento al in this.alojamientos)
            {
                if (al is Cabania)
                {
                    agencia.AgregarAlojamiento(al);
                }
            }
            return agencia;
        }

        public Agencia GetAlojamientosConUnMinimoDeEstrellas(int minimo)
        {
            Agencia agencia = new Agencia();
            foreach (Alojamiento al in this.alojamientos)
            {
                if (al.GetEstrellas() >= minimo)
                {
                    agencia.AgregarAlojamiento(al);
                }
            }
            return agencia;
        }
        public Agencia AlojamientosEntrePrecios(double minimo, double maximo)
        {
            Agencia agencia = new Agencia();
            foreach(Alojamiento al in this.alojamientos)
            {
                if(al.Precio() >= minimo && al.Precio() <= maximo)
                {
                    agencia.AgregarAlojamiento(al);
                }
            }
            return agencia;
        }
        public Agencia GetCabaniasEntrePrecios(double minimo, double maximo)
        {
            Agencia agencia = new Agencia();
            foreach(Alojamiento al in this.alojamientos)
            {
                if ( al is Cabania && al.Precio() >= minimo && al.Precio() <= maximo)
                {
                    agencia.AgregarAlojamiento(al);
                }
            }
            return agencia;
        }
        public Agencia GetHotelesEntrePrecios(double minimo, double maximo)
        {
            Agencia agencia = new Agencia();
            foreach (Alojamiento al in this.alojamientos)
            {
                if (al is Hotel && al.Precio() >= minimo && al.Precio() <= maximo)
                {
                    agencia.AgregarAlojamiento(al);
                }
            }
            return agencia;
        }


        /* METODOS AGREGADOS */
        public Alojamiento FindAlojamientoForCodigo(int codigoAlojamiento)
        {
            return this.alojamientos.Find( al => al.GetCodigo() == codigoAlojamiento );
        }
        public bool ExisteAlojamiento(Alojamiento alojamiento)
        {
            foreach (Alojamiento al in this.alojamientos)
            {
                if (al.IgualCodigo(alojamiento)) return true;
            }
            return false;
        }


        // Devuelve una lista de listas con todos los atributos de cada alojamiento
        public List<List<String>> GetAllAlojamientos()
        {
            List<List<String>> alojamientos = new List<List<String>>();

            foreach( Alojamiento al in this.alojamientos )
            {
                List<String> alojamiento = al.GetAlojamientoInLista();

                alojamientos.Add( alojamiento );
            }
            return alojamientos;
        }


        /* GETTERS Y SETTERS */
        public int GetCantidadDeAlojamientos()
        {
            return this.cantidadDeAlojamientos;
        }
        public List<Alojamiento> GetAlojamientos()
        {
            return this.alojamientos;
        }

    }
}
