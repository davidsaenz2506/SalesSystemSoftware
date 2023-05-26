using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentación
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            Inicio form = new Inicio();

            form.Show();
            this.Hide();

            form.FormClosing += frm_clossing;

        }

        private void frm_clossing(object sender, FormClosingEventArgs e)
        {
            txtDocument.Text = "";
            txtClave.Text = "";

            this.Show();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }
}
