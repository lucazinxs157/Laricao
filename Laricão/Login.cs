using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Modelo;
using Controle;

namespace LaricãoHamburgueria
{
    public partial class Login : Form
    {
            UsuarioControle controle = new UsuarioControle();
            UsuarioModelo modelo = new UsuarioModelo();
        public Login()
        {
            InitializeComponent();
        }

        private void btn_logar_Click(object sender, EventArgs e)
        {
            modelo.nome = txtLogin.Text;
            modelo.senha = txtSenha.Text;
            controle.logar(modelo);
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }
}
