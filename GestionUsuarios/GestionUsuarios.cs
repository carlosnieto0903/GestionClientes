using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestionUsuarios
{
    public partial class GestionUsuarios : Form
    {
        Cliente cliente = new Cliente();
        List<Cliente> clientes = new List<Cliente>();
        public GestionUsuarios()
        {
            InitializeComponent();
        }
        private void cargarClientes()
        {
            listClientes.Items.Clear();
            foreach (Cliente cliente in clientes)
            {
                listClientes.Items.Add(cliente.Nombre); 
            }

        }

        private void GestionUsuarios_Load(object sender, EventArgs e)
        {
            cargarClientes();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Cliente cli = new Cliente();
            listClientes.Items.Clear();
            cli.Nombre = txtNombre.Text;
            cli.Telefono = txtTelefono.Text;
            cli.Tarjeta = txtTarjeta.Text;
            clientes.Add(cli);
            cargarClientes();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            int indice = listClientes.SelectedIndex;
            if (indice >= 0 && indice < clientes.Count) 
            {
                listClientes.Items.RemoveAt(indice);
                clientes.RemoveAt(indice);
            }
        }
    }
}
