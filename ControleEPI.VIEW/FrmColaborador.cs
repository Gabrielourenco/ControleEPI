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
    public partial class FrmColaborador : Form
    {
        Controller.CColaboradores _Control = new Controller.CColaboradores();
        bool incluir;

        public FrmColaborador()
        {
            InitializeComponent();
        }

        private void HabilitaControles(bool Habilita)
        {
            TxtRE.Enabled = Habilita;
            TxtNomeC.Enabled = Habilita;
            TxtFuncao.Enabled = Habilita;
           
        }

        private void LimpaControles()
        {
            TxtRE.Text = "";
            TxtNomeC.Text = "";
            TxtFuncao.Text = "";
        }

        private bool ValidaControles()
        {
            if (TxtRE.Text.Trim() == "")
            {
                MessageBox.Show("Preencha o conteúdo do campo RE.", ProductName, MessageBoxButtons.OK);
                TxtRE.Focus();
                return false;
            }
            else if (TxtNomeC.Text.Trim() == "")
            {
                MessageBox.Show("Preencha o conteúdo do campo Nome.", ProductName, MessageBoxButtons.OK);
                TxtNomeC.Focus();
                return false;
            }
            else if (TxtFuncao.Text.Trim() == "")
            {
                MessageBox.Show("Preencha o conteúdo do campo Função.", ProductName, MessageBoxButtons.OK);
                TxtFuncao.Focus();
                return false;
            }
            

            return true;
        }

        private void CarregaGrid()
        {
            GrdColaborador.DataSource = _Control.SelecionarTodos();
            GrdColaborador.AutoResizeColumns();
        }

        private void BtnIncluir_Click(object sender, EventArgs e)
        {
            if (ValidaControles())
            {
                Colaborador oColaborador = new Colaborador();
                oColaborador.RE = int.Parse(TxtRE.Text);
                oColaborador.Nome = (TxtNomeC.Text).ToString();
                oColaborador.Funcao = (TxtFuncao.Text).ToString();
              

                if (incluir)
                {
                    _Control.Incluir(oColaborador);
                    incluir = false;
                }
                else
                {
                    _Control.Alterar(oColaborador);
                }
                HabilitaControles(false);
                BtnIncluir.Enabled = true;
                BtnAlterar.Enabled = true;
                BtnExcluir.Enabled = false;
                CarregaGrid();
            }
        }



        private void FrmColaborador_Load(object sender, EventArgs e)
        {
            GrdColaborador.DataSource = _Control.SelecionarTodos();
        }

        private void TxtRE_Leave(object sender, EventArgs e)
        {
            if (!(TxtRE.Text.Trim() == ""))
            {
                Colaborador oColaborador = _Control.Selecionar((int.Parse(TxtRE.Text)));
                if (oColaborador == null)
                {
                    incluir = true;
                    BtnIncluir.Enabled = true;

                    BtnAlterar.Enabled = false;
                    BtnExcluir.Enabled = false;
                }
                else
                {
                    TxtNomeC.Text = oColaborador.Nome;
                    TxtFuncao.Text = oColaborador.Funcao.ToString();
                   


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
            TxtRE.Enabled = false;
            TxtNomeC.Focus();
            incluir = false;
        }
        private void BtnExcluir_Click(object sender, EventArgs e)
        {
            Colaborador oColaborador = new Colaborador();
            oColaborador.RE = int.Parse(TxtRE.Text);
            _Control.Excluir(oColaborador);
            HabilitaControles(true);
            LimpaControles();
            BtnAlterar.Enabled = false;
            BtnExcluir.Enabled = false;
            BtnIncluir.Enabled = true;
            CarregaGrid();
            MessageBox.Show("Registro excluído com sucesso.", ProductName, MessageBoxButtons.OK);
        }
    }
}
