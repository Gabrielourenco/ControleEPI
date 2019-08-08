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
    public partial class FrmSaida : Form
    {
        public FrmSaida()
        {
            InitializeComponent();
        }

        private void FrmSaida_Load(object sender, EventArgs e)
        {

        }

        private void TxtCodigo_Leave(object sender, EventArgs e)
        {
            if (!(TxtCodigo.Text.Trim() == ""))
            {
                EPI oEPI = _Control.Selecionar((int.Parse(TxtCodigo.Text)));
                if (oEPI == null)
                {
                    incluir = true;
                    BtnIncluir.Enabled = true;

                    BtnAlterar.Enabled = false;
                    BtnExcluir.Enabled = false;
                }
                else
                {
                    TxtNome.Text = oEPI.Nome;
                    TxtCA.Text = oEPI.CA.ToString();
                    TxtQTD.Text = oEPI.Quantidade.ToString();
                    BtnIncluir.Enabled = false;
                    BtnAlterar.Enabled = true;
                    BtnExcluir.Enabled = true;
                    HabilitaControles(false);
                }
            }
        }
    }
}
