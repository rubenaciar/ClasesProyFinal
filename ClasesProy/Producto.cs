using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyFinal_Clases
{
    public class Producto
    {
        private int _ID;
        private string _Descripicion;
        private decimal _Costo;
        private decimal _PrecioVenta;
        private int _Stock;
        private int _IDUsuario;

        public Producto(int idProducto, string Descripicion, decimal Costo, decimal PrecioVenta, int Stock, int IDUsuario)
        {
            this._ID = idProducto;
            this._Descripicion = Descripicion;
            this._Costo = Costo;
            this._PrecioVenta = PrecioVenta;
            this._Stock = Stock;
            this._IDUsuario = IDUsuario;    
        }

    }
}