﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyFinal_Clases
{
    //CLASE PRODUCTOVENDIDO
    public class ProductoVendido
    {
        #region Atributos
        private int _id;
        private int _idProducto;
        private int _stock;
        private int _idVenta;
        #endregion
        #region Constructores
        public ProductoVendido(int id, int idProducto, int stock, int idVenta)
            {
                this._id = id;
                this._idProducto = idProducto;
                this._stock = stock;
                this._idVenta = idVenta;

            }
        #endregion
    }
}