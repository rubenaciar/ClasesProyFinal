using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyFinal_Clases
{
    public class Usuario
    {
        private int _ID;
        private string _Nombre;
        private string _Apellido;
        private string _NombreUsuario;
        private string _Contraseña;
        private string _Mail;

        public Usuario(int idUsuario, string Nombre, string Apellido, string NombreUsuario, string Contraseña, string Mail )
        {
            this._ID = idUsuario;
            this._Nombre = Nombre;
            this._Apellido = Apellido;
            this._NombreUsuario = NombreUsuario;
            this._Contraseña = Contraseña;
            this._Mail = Mail;
        }

    }
}
