using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListasDobles
{
    class Inventario
    {
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

        public void eliminar(int codigo)
        {
            Producto t = inicio;
            while(t != null)
            {
                if (t._codigo == codigo)
                {
                    if(t == inicio)
                    {
                        inicio = inicio._siguiente;
                        inicio._anterior = null;
                    }
                    else if(t == ultimo)
                    {
                        t._anterior._siguiente = null;
                        ultimo = t._anterior;
                    }
                    else
                    {
                        t._anterior._siguiente = t._siguiente;
                        t._siguiente._anterior = t._anterior;
                    }
                }
                t = t._siguiente;
            }
        }

        public void eliminarPrimero()
        {
            if (inicio != null)
            {
                eliminar(inicio._codigo);
            }
        }

        public void eliminarUltimo()
        {
            if(inicio != null)
            {
                eliminar(ultimo._codigo);
            }
        }

        public Producto buscar(int codigo)
        {
            if (inicio != null)
            {
                Producto t = inicio;
                while (t != null)
                {
                    if (t._codigo == codigo)
                    {
                        return t;
                    }
                    t = t._siguiente;
                }
            }
            return null;
        }

        public string listar()
        {
            string res = "";
            Producto t = inicio;
            while (t != null)
            {
                res += t.ToString() + Environment.NewLine;
                t = t._siguiente;
            }
            return res;
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
