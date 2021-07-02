using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Painter
{
    public partial class capas : Form
    {
        public capas()
        {
            InitializeComponent();
            this.Controls.Add(dgvCapas);
            dgvCapas.Dock = DockStyle.Fill;
        }
        public DataGridView dgvCapas = new DataGridView();
        DataGridView datagridview1 = new DataGridView();
        
        private void capas_Load(object sender, EventArgs e)
        {

        }

        private void dgvCapas_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            MessageBox.Show("MSGBX TESTIGO: cambio el dato");
        }

    }
}
