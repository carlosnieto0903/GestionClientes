using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GestionUsuarios.dao;
using GestionUsuarios.modelos;

namespace GestionUsuarios
{
    public partial class GestionUsuarios : Form
    {
        Cliente cliente = new Cliente();
        string id = "";
        public GestionUsuarios()
        {
            InitializeComponent();
        }
        private void cargarClientes()
        {
            clientedao basedeDatos = new clientedao();
            List<Cliente> lista = basedeDatos.clientes();

            listClientes.Items.Clear();
            foreach (Cliente cliente in lista)
            {
                listClientes.Items.Add(cliente);
            }
        }

        private void GestionUsuarios_Load(object sender, EventArgs e)
        {
            btnActualizar.Visible = false;
            btnActualizar.Enabled = false;
            cargarClientes();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Cliente cli = new Cliente();
            listClientes.Items.Clear();
            cli.Nombre = txtNombre.Text;
            cli.Telefono = txtTelefono.Text;
            cli.Tarjeta = txtTarjeta.Text;
            clientedao basedeDatos = new clientedao();
            basedeDatos.Agregar(cli);
            cargarClientes();
            txtNombre.Text = "";
            txtTelefono.Text = "";
            txtTarjeta.Text = "";
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            Cliente indice = (Cliente)listClientes.SelectedItem;
            clientedao basedeDatos = new clientedao();
            basedeDatos.Eliminar(indice);
            cargarClientes();
        }

        private void btnVer_Click(object sender, EventArgs e)
        {
            Cliente indice = (Cliente)listClientes.SelectedItem;
            txtNombre.Text = indice.Nombre;
            txtTelefono.Text = indice.Telefono;
            txtTarjeta.Text = indice.Tarjeta;
            id = indice.Id;

            btnActualizar.Visible = true;
            btnActualizar.Enabled = true;
            btnAgregar.Enabled = false;
            btnEliminar.Enabled = false;
            btnVer.Enabled = false;
            btnVer.Visible = false;
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            Cliente cli = new Cliente();
            listClientes.Items.Clear();
            cli.Nombre = txtNombre.Text;
            cli.Telefono = txtTelefono.Text;
            cli.Tarjeta = txtTarjeta.Text;
            cli.Id = id;
            clientedao basedeDatos = new clientedao();
            basedeDatos.Editar(cli);
            cargarClientes();

            txtNombre.Text = "";
            txtTelefono.Text = "";
            txtTarjeta.Text = "";
            btnActualizar.Visible = false;
            btnActualizar.Enabled = false;
            btnVer.Enabled = true;
            btnVer.Visible = true;
            btnAgregar.Enabled = true;
            btnEliminar.Enabled = true;
        }
    }
}
