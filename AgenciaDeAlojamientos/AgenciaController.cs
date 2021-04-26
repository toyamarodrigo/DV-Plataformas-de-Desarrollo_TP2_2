using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

using AgenciaDeAlojamientos.Views;
using AgenciaDeAlojamientos.Models;

namespace AgenciaDeAlojamientos
{
    class AgenciaController
    {

        private Agencia agenciaModel;

        public AgenciaController(Agencia agencia)
        {
            this.agenciaModel = agencia;
        }

        public void Iniciar()
        {
            /* ~~~~ Form login ~~~~ */
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Login());
            /* ~~~~~~~~~~~~~~~~~~~~ */


        }



    }
}
