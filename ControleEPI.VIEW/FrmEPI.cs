using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ControleEPI.MODEL;

namespace ControleEPI.VIEW
{
    public partial class FrmEPI : Form
    {
        Controller.CEPI _Control;
        private bool incluir;

        public FrmEPI()
        {
            InitializeComponent();
            _Control = new Controller.CEPI();
        }

        private void HabilitaControles(bool Habilita)
        {
            TxtCodigo.Enabled = Habilita;
            TxtNome.Enabled = Habilita;
            TxtCA.Enabled = Habilita;
           
            TxtQTD.Enabled = Habilita;
        }

        private void LimpaControles()
        {
            TxtCodigo.Text = "";
            TxtNome.Text = "";
            TxtCA.Text = "";
            TxtQTD.Text = "";
        

        }

        private bool ValidaControles()
        {
            if (TxtCodigo.Text.Trim() == "")
            {
                MessageBox.Show("Preencha o conteúdo do campo Código.", ProductName, MessageBoxButtons.OK);
                TxtCodigo.Focus();
                return false;
            }
            else if (TxtNome.Text.Trim() == "")
            {
                MessageBox.Show("Preencha o conteúdo do campo Nome.", ProductName, MessageBoxButtons.OK);
                TxtNome.Focus();
                return false;
            }
            
            else if (TxtQTD.Text.Trim() == "")
            {
                MessageBox.Show("Preencha o conteúdo do campo Quantidade.", ProductName, MessageBoxButtons.OK);
                TxtQTD.Focus();
                return false;
            }
            
            return true;
        }
        private void CarregaGrid()
        {
            GRDEPI.DataSource = _Control.SelecionarTodos();
            
        }
        private void BtnIncluir_Click(object sender, EventArgs e)
        {
            if (ValidaControles())
            {
                if (incluir)
                {
                    EPI oEPI = new EPI();
                    oEPI.Codigo = int.Parse(TxtCodigo.Text);
                    oEPI.Nome = (TxtNome.Text).ToString();
                    oEPI.CA = int.Parse(TxtCA.Text);
                    oEPI.Quantidade = int.Parse(TxtQTD.Text);
                    oEPI.DataEntrada = DateTime.Now;
                    _Control.Incluir(oEPI);
                    incluir = false;
                }
                else
                {
                    var oEPI = _Control.Selecionar(int.Parse(TxtCodigo.Text));
                    oEPI.Nome = (TxtNome.Text).ToString();
                    oEPI.CA = int.Parse(TxtCA.Text);
                    oEPI.Quantidade = int.Parse(TxtQTD.Text);
                    oEPI.DataEntrada = DateTime.Now;
                    _Control.Alterar(oEPI);
                }
                HabilitaControles(false);
                BtnIncluir.Enabled = true;
                BtnAlterar.Enabled = true;
                BtnExcluir.Enabled = false;
                CarregaGrid();

                LimpaControles();
                HabilitaControles(true);
                BtnAlterar.Enabled = false;

                TxtCodigo.Focus();
            }
        }

            private void FrmEPI_Load(object sender, EventArgs e)
        {
            CarregaGrid();
            }

        private void TxtCodigo_Leave(object sender, EventArgs e)
        {
            if (!(TxtCodigo.Text.Trim() == ""))
            {
                EPI oEPI  = _Control.Selecionar((int.Parse (TxtCodigo.Text)));
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
        private void BtnAlterar_Click(object sender, EventArgs e)
        {
            BtnIncluir.Enabled = true;
            BtnAlterar.Enabled = false;
            BtnExcluir.Enabled = false;
            HabilitaControles(true);
            TxtCodigo.Enabled = false;
            TxtNome.Focus();
            incluir = false;
        }
        private void BtnExcluir_Click(object sender, EventArgs e)
        {
            var oEPI = _Control.Selecionar(int.Parse(TxtCodigo.Text));
            _Control.Excluir(oEPI);
            HabilitaControles(true);
            LimpaControles();
            BtnAlterar.Enabled = false;
            BtnExcluir.Enabled = false;
            BtnIncluir.Enabled = true;
            CarregaGrid();
            MessageBox.Show("Registro excluído com sucesso.", ProductName, MessageBoxButtons.OK);
            TxtCodigo.Focus();
        }

        private void TxtCodigo_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
