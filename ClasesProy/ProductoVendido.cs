using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyFinal_Clases
{
    public class ProductoVendido
    {
        private int _ID;
        private int _idProducto;
        private int _Stock;
        private int _idVenta;

        public ProductoVendido(int idProductoVendido, int idProducto, int Stock, int idVenta)
        {
            this._ID = idProductoVendido;
            this._idProducto = idProducto;
            this._Stock = Stock;
            this._idVenta = idVenta;

        }
    }
}