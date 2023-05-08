using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyFinal_Clases
{
    //CLASE USUARIO
    public class Usuario
    {
        #region Atributos
        private int _id;
        private string _nombre;
        private string _apellido;
        private string _nombreUsuario;
        private string _contraseña;
        private string _mail;
        #endregion
        #region Constructores
        public Usuario(int id, string nombre, string apellido, string nombreUsuario, string contraseña, string mail )
            {
                this._id = id;
                this._nombre = nombre;
                this._apellido = apellido;
                this._nombreUsuario = nombreUsuario;
                this._contraseña = contraseña;
                this._mail = mail;
            }
        #endregion
    }
}
