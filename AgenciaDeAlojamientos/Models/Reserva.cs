using System;
using System.Collections.Generic;
using System.Text;

namespace AgenciaDeAlojamientos.Models
{
    class Reserva
    {
        private static int proximoId = 0;

        private int id;
        private DateTime fechaDesde;
        private DateTime fechaHasta;
        private Alojamiento alojamiento;
        private Usuario usuario;
        private double precio;

        public Reserva(DateTime fechaDesde, DateTime fechaHasta, Alojamiento alojamiento, Usuario usuario, double precio)
        {
            this.id = Reserva.generarId();
            this.fechaDesde = fechaDesde;
            this.fechaHasta = fechaHasta;
            this.alojamiento = alojamiento;
            this.usuario = usuario;
            this.precio = precio;
        }

        private static int generarId()
        {
            int id = Reserva.proximoId;
            Reserva.proximoId++;

            return id;
        }

        public List<String> GetReserva()
        {
            return new List<string>()
            {
                this.id.ToString(),
                this.fechaDesde.ToString(),
                this.fechaHasta.ToString(),
                this.alojamiento.GetCodigo().ToString(),
                this.usuario.GetDni().ToString(),
                this.precio.ToString()
            };
        }

    }
}
