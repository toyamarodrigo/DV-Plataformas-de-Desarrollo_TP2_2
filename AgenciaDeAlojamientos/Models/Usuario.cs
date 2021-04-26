using System;
using System.Collections.Generic;
using System.Text;

namespace AgenciaDeAlojamientos.Models
{
    class Usuario
    {
        private int dni;
        private String nombre;
        private String email;
        private String password;
        private bool esAdmin;
        private bool bloqueado;

        public Usuario(int dni, String nombre, String email,String password, bool esAdmin)
        {
            this.dni = dni;
            this.nombre = nombre;
            this.email = email;
            this.password = password;
            this.esAdmin = esAdmin;
            this.bloqueado = false;
        }

        /* METODOS AGREGADOS */
        public List<String> GetUsuario()
        {
            return new List<string>() { this.dni.ToString(), this.nombre, this.email, this.esAdmin ? "admin":"usuario", this.bloqueado ? "si" : "no" };
        }


        /* GETTERS Y SETTERS */
        public int GetDni()
        {
            return this.dni;
        }

    }
}
