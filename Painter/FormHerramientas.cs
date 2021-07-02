using System;
using System.Drawing;
using System.Windows.Forms;

namespace Painter
{
    public partial class FormHerramientas : Form
    {
        public FormHerramientas()
        {
            InitializeComponent();

        }

        public static Color mainColor;
        public Color colorBorde;
        public static String textoADibujar;


        //Form1 main = new Form1();
        private void btnLinea_Click(object sender, EventArgs e)
        {
            Form1.index = 5;
        }

        private void btnLapiz_Click(object sender, EventArgs e)
        {
            Form1.index = 1;
        }
       

        private void btnGoma_Click(object sender, EventArgs e)
        {
            Form1.index = 2;
        }

        private void btnElipse_Click(object sender, EventArgs e)
        {
            Form1.index = 3;
        }

        private void btnRectangulo_Click(object sender, EventArgs e)
        {
            Form1.index = 4;
        }

        private void btnRelleno_Click(object sender, EventArgs e)
        {
            Form1.index = 7;
        }

        private void chkRelleno_CheckedChanged(object sender, EventArgs e)
        {
            if (chkRelleno.Checked)
            {
                Form1.relleno = true;
                chkBorde.Visible = true;
            }
            else
            {
                Form1.relleno = false;
                Form1.borde = false;
                chkBorde.Visible = false;

            }
        }

        private void chkBorde_CheckedChanged(object sender, EventArgs e)
        {
            if (chkBorde.Checked)
            {
                Form1.borde = true;
            }
            else
            {
                Form1.borde = false;
            }
        }

        private void boxTextoADibujar_TextChanged(object sender, EventArgs e)
        {
            Form1.texto = boxTextoADibujar.Text.ToString();
        }

        private void groupBox4_Enter(object sender, EventArgs e)
        {

        }


        private void button1_Click(object sender, EventArgs e)
        {
            if(boxTextoADibujar.Text.Length == 0)
            {
                MessageBox.Show("¿te olvidaste de insertar texto?");
            }
            MessageBox.Show("Clickea donde quieras insertar tu texto, y a continuación elegí la tipografía.");
            Form1.index = 99;
        }

        private void FormHerramientas_Load(object sender, EventArgs e)
        {

        }
    }
}
