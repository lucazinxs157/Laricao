using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class UsuarioModelo
    {
        public int id;
        public string nome;
        public string senha;
        public string email;
        public int idperfil;

        public UsuarioModelo()
        {
            nome = null;
            senha = null;
            email = null;
            idperfil = 2;
        }
    }
}
