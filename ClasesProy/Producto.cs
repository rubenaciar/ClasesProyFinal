using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyFinal_Clases
{
    //CLASE PRODUCTO
    public class Producto
    {
        #region Atributos
        private int _id;
        private string _descripicion;
        private decimal _costo;
        private decimal _precioVenta;
        private int _stock;
        private int _idUsuario;
        #endregion
        #region Constructores
        public Producto(int id, string descripicion, decimal costo, decimal precioVenta, int stock, int idUsuario)
            {
                this._id = id;
                this._descripicion = descripicion;
                this._costo = costo;
                this._precioVenta = precioVenta;
                this._stock = stock;
                this._idUsuario = idUsuario;    
            }
        #endregion
    }
}