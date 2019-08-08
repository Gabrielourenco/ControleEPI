using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ControleEPI.VIEW
{
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
        }

        private void ePIToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmEPI oFrmEPI = new FrmEPI();
            oFrmEPI.Show();
        }

        private void saídaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmSaida ofrmSaida = new FrmSaida();
            ofrmSaida.Show();
        }
    }
}
