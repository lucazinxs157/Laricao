using Modelo;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controle
{
    public class Conexao
    {
        static private string servidor = "localhost";
        static private string db = "laricão";
        static private string usuario = "root";
        static private string senha = "";
        public MySqlConnection con = null;

        static private string StrCon = "server=" + servidor + ";database=" + db + ";user=" + usuario + ";password=" + senha;

        public MySqlConnection GetConexao()
        {
            MySqlConnection conexao = new MySqlConnection(StrCon);
            return conexao;
        }

        public bool AddUser(UsuarioModelo modelo)
        {
            try
            {
                string sqlComand = "INSERT INTO usuario (nome, senha, email, perfil) VALUES (@nome,@senha, @email, @perfil)";

                con = GetConexao();
                con.Open();
                MySqlCommand cmd = new MySqlCommand(sqlComand, con);
                cmd.Parameters.AddWithValue("@nome", modelo.nome);
                cmd.Parameters.AddWithValue("@senha", modelo.senha);
                cmd.Parameters.AddWithValue("@email", modelo.email);
                cmd.Parameters.AddWithValue("@perfil", modelo.idperfil);
                cmd.ExecuteNonQuery();
                con.Close();
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
