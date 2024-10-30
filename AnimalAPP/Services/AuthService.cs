using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AnimalAPP.Models;

namespace AnimalAPP.Services
{
    public class AuthService
    {
        private List<Usuario> usuarios = new List<Usuario>();

        public bool RegistrarUsuario(Usuario usuario)
        {
            if (usuarios.Any(u => u.Email == usuario.Email))
                return false; // El usuario ya existe

            usuarios.Add(usuario);
            return true;
        }

        public Usuario Login(string email, string password)
        {
            return usuarios.FirstOrDefault(u => u.Email == email && u.Password == password);
        }

        public bool EsAdmin(Usuario usuario)
        {
            return usuario?.Rol == "Admin";
        }
    }
}
