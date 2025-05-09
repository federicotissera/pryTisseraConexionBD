namespace pryTisseraConexionBD
{
    public partial class Form1 : Form
    {
        clsConexion conexion = new clsConexion();
        public Form1()
        {
            InitializeComponent();
            conexion.ConectarBD();
        }
    }
}
