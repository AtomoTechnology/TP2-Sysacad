using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Data.Database;
using Business.Entities;

namespace Business.Logic
{
    public class UsuarioLogic : BusinessLogic
    {
        private UsuarioAdapter _usuarioData;
        private static UsuarioLogic singleton;


        public static UsuarioLogic GetInstance()
        {

            if (singleton == null)
            {
                singleton = new UsuarioLogic();
            }

            return singleton;

        }

        public UsuarioAdapter Usuario
        {
            get { return _usuarioData; }
            set { _usuarioData = value; }
        }

        public UsuarioLogic()
        {
            _usuarioData = new UsuarioAdapter();
        }
        public List<Usuario> GetAll(int? tipoPersona = null )
        {
            return Usuario.GetAll( tipoPersona );
        }
        public Usuario GetOne(int id)
        {
            return Usuario.GetOne(id);
        }
        public void Delete(int id)
        {
            Usuario.Delete(id);
        }
        public void Save(Usuario usuario)
        {
            Usuario.Save(usuario);
        }
        public Usuario LogIn(string username, string password)
        {
            return Usuario.LogIn(username, password);
        }

    }
}
