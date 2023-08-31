using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modelo;
using MySql.Data.MySqlClient;

namespace Controle
{
    public class UsuarioControle
    {
        Conexao con = new Conexao();
        public void logar(UsuarioModelo login)
        {
            con.AddUser(login);
        }
        public bool teste()
        {
            if (con.GetConexao() == null)
                return false;
            else
                return true;
        }
    }
}
