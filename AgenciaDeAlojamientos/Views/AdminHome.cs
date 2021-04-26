using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace AgenciaDeAlojamientos.Views
{
    public partial class AdminHome : Form
    {
        
        private String user;

        public AdminHome(String user)
        {
            InitializeComponent();
            
            this.user = user;

            this.agregarDatos(user);
        }

        private void agregarDatos(String user)
        {
            this.lblUser.Text = user;
        }

    }
}
