using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace AgenciaDeAlojamientos.Views
{
    public partial class UserHome : Form
    {
        private String user;

        public UserHome(String user)
        {
            InitializeComponent();

            this.user = user;

            this.agregarDato(user);
        }

        public void agregarDato(String user)
        {
            this.lblUser.Text = user;
        }

    }
}
