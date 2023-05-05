using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyFinal_Clases
{
    public class Venta
    {
        private int _ID;
        private string _Comentarios;
        private int _IDUsuario;

        public Venta(int idVenta, string Comentarios, int IDUsuario)
        {
            this._ID = idVenta;
            this._Comentarios = Comentarios;
            this._IDUsuario = IDUsuario;

        }
    }
}
