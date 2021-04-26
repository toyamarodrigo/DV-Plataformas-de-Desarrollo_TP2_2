using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

using AgenciaDeAlojamientos.Views;

namespace AgenciaDeAlojamientos
{
    public partial class Login : Form
    {

        public Login()
        {
            InitializeComponent();
        }

        private void HandlerBtnLogin(object sender, EventArgs e)
        {
            String user = this.inputNombre.Text;
            String password = this.InputPassword.Text;

            if (user == "user")
            {
                UserHome userView = new UserHome(user);
                userView.Show();
                this.Hide();
            }
            else if (user == "admin")
            {
                AdminHome adminView = new AdminHome(user);
                adminView.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Usuarios validos: user, admin", "Ingreso al sistema");
            }
            //MessageBox.Show($"{user} - {password}", "Ingreso al sistema");

            Console.WriteLine("User: " + user);
            Console.WriteLine("Password: " + password);
            Application.Exit();
        }


    }
}
