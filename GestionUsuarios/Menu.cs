namespace GestionUsuarios
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            GestionUsuarios usuarios = new GestionUsuarios();
            usuarios.Show();
        }
    }
}