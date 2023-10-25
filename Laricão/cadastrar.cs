using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Org.BouncyCastle.Asn1.Pkcs;
using Modelo;
using Controle;
using Google.Protobuf.WellKnownTypes;


namespace Laricão
{
    public partial class cadastrar : Form
    {
        UsuarioControle uscontroller = new UsuarioControle();
        PrivateFontCollection pfc = new PrivateFontCollection();
        UsuarioModelo modelo = new UsuarioModelo();
        UsuarioControle controle = new UsuarioControle();
        Conexao con = new Conexao();
        int idPerfil;
        int id;
        int perfiluser;
    

        public cadastrar()
        {
            InitializeComponent();
        }

        public cadastrar(int id)
        {
            this.id = id;
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
       
        }
    }
}
