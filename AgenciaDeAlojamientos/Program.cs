
using System;

using AgenciaDeAlojamientos.Views;
using AgenciaDeAlojamientos.Models;

namespace AgenciaDeAlojamientos
{
    static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {

            Agencia model = new Agencia();

            AgenciaController agencia = new AgenciaController(model);
            //AgenciaController agencia = new AgenciaController();

            agencia.Iniciar();
        }

    }
}
