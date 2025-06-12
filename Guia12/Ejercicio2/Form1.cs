using System.Diagnostics.Eventing.Reader;

namespace Ejercicio2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSolicitar_Click(object sender, EventArgs e)
        {
            EjemploModal Ventana = new Form1();
            if (Ventana.ShowDialog() == DialogResult.OK) ;
            {
                lbMostrarValor.Text = $"{Ventana.tbValor.Text}";
            else
                    lbMostrarValor.Text = "Ingreso cancelado";
            }
           
        }
    }
}
