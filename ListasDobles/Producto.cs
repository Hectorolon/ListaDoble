using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListasDobles
{
    class Producto
    {
        public int _codigo { get; set; }
        public string _nombre { get; set; }
        public string _descripcion { get; set; }
        public int _cantidad { get; set; }
        public int _precio { get; set; }

        public Producto _siguiente { get; set; }
        public Producto _anterior { get; set; }

        public Producto(int codigo, string nombre, string descripcion, int cantidad, int precio)
        {
            _codigo = codigo;
            _nombre = nombre;
            _descripcion = descripcion;
            _cantidad = cantidad;
            _precio = precio;
        }

        public override string ToString()
        {
            return "Codigo: " + _codigo + Environment.NewLine +
                "Nombre: " + _nombre + Environment.NewLine +
                "Descripcion: " + _descripcion + Environment.NewLine +
                "Cantidad: " + _cantidad + Environment.NewLine +
                "Precio: " + _precio + Environment.NewLine + Environment.NewLine;
        }
    }
}
