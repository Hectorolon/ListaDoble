﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ListasDobles
{
    public partial class Form1 : Form
    {
        Inventario inventario = new Inventario();
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int codigo = Convert.ToInt32(txtBuscar.Text);
            Producto buscar = inventario.buscar(codigo);
            if (buscar != null)
            {
                txtMostrar.Text = buscar.ToString();
            }
            else
            {
                txtMostrar.Text = "Producto no encontrado";
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            int codigo = Convert.ToInt32(txtCodigo.Text);
            int cantidad = Convert.ToInt32(txtCantidad.Text);
            int precio = Convert.ToInt32(txtPrecio.Text);
            inventario.agregar(new Producto
                (codigo, txtNombre.Text, txtDescripcion.Text,
                cantidad, precio));
            txtCodigo.Clear();
            txtNombre.Clear();
            txtDescripcion.Clear();
            txtCantidad.Clear();
            txtPrecio.Clear();
            txtCodigo.Focus();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            txtMostrar.Clear();
            int codigo = Convert.ToInt32(txtEliminar.Text);
            inventario.eliminar(codigo);
        }

        private void btnLista_Click(object sender, EventArgs e)
        {
            txtMostrar.Text = inventario.listar();

        }

        private void btnInvertirLista_Click(object sender, EventArgs e)
        {
            txtMostrar.Text = inventario.invertirLista();
        }

        private void btnEliminarInicio_Click(object sender, EventArgs e)
        {
            txtMostrar.Clear();
            inventario.eliminarPrimero();
        }

        private void btnEliminarUltimo_Click(object sender, EventArgs e)
        {
            txtMostrar.Clear();
            inventario.eliminarUltimo();
        }
    }
}
