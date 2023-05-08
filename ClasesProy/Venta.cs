using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyFinal_Clases
{
    //CLASE VENTA
    public class Venta
    {
        #region Atributos
        private int _id;
        private string _comentarios;
        private int _idUsuario;
        #endregion
        #region Constructores
        public Venta(int id, string comentarios, int idUsuario)
            {
                this._id = id;
                this._comentarios = comentarios;
                this._idUsuario = idUsuario;

            }
        #endregion
    }
}
