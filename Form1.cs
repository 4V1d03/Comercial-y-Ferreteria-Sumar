using Comercial_y_Ferreteria_Sumar.Clases;

namespace Comercial_y_Ferreteria_Sumar
{
    public partial class Form1 : Form
    {
       Funciones c = new Funciones();


        public Form1()
        {
            InitializeComponent();
        }       

        private void btningresarlg_Click(object sender, EventArgs e)
        {
            c.abrir();

            if (c.iniciarsesion(txtusuariolg.Text, txtclavelg.Text) == 1 )
            {
                Menu menu = new Menu();
                menu.Show(this);
                this.Hide();
            }
            else
            {
                MessageBox.Show("El usuario no existe");
            }

            c.cerrar();
        }

        private void Form1_Load_1(object sender, EventArgs e)
        {
            this.CenterToScreen();
            this.MaximizeBox = false;
            this.AutoSizeMode = AutoSizeMode.GrowAndShrink;
        }
    }
}