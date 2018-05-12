using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListasDobles
{
    class Inventario
    {
        private Producto[] _producto;
        private int _contador;


        public Inventario(int tamaño)
        {
            _producto = new Producto[tamaño];
            _contador = 0;
        }

        public void agregar(Producto nuevo)
        {
            if (inicio == null)
            {
                inicio = nuevo;
                ultimo = inicio;
            }
            else
            {
                ultimo._siguiente = nuevo;
                nuevo._anterior = ultimo;
                ultimo = nuevo;
            }
        }

        public string eliminar(int posicion)
        {
            for (int i = posicion; i < _contador - 1; i++)
            {
                _producto[i] = _producto[i + 1];
            }
            if (_contador - 1 > 0)
            {
                _producto[_contador - 1] = null;
                _contador--;
            }
            return "Producto eliminado";
        }

        public Producto buscar(int codigo)
        {
            for (int i = 0; i < _contador; i++)
            {
                if (_producto[i] != null)
                {
                    if (_producto[i]._codigo == codigo)
                        return _producto[i];
                }
            }
            return null;
        }

        public string listar()
        {
            string vector = "";
            for (int i = 0; i < _contador; i++)
            {
                vector += _producto[i].ToString();
            }
            return vector;
        }

        Producto inicio = null;
        Producto ultimo = null;

        public void agregar(Producto nuevo)
        {
            if (inicio == null)
            {
                inicio = nuevo;
                ultimo = inicio;
            }
            else
            {
                ultimo._siguiente = nuevo;
                nuevo._anterior = ultimo;
                ultimo = nuevo;
            }
        }

        public string invertirLista()
        {
            string res = "";
            Producto t = ultimo;
            while(t != null)
            {
                res += t.ToString() + Environment.NewLine;
                t = t._anterior;
            }
            return res;
        }
    }
}
