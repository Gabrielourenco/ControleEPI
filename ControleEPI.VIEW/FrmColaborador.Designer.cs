namespace ControleEPI.VIEW
{
    partial class FrmColaborador
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.BtnExcluir = new System.Windows.Forms.Button();
            this.BtnAlterar = new System.Windows.Forms.Button();
            this.BtnIncluir = new System.Windows.Forms.Button();
            this.TxtFuncao = new System.Windows.Forms.TextBox();
            this.TxtNomeC = new System.Windows.Forms.TextBox();
            this.TxtRE = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.GrdColaborador = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.GrdColaborador)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnExcluir
            // 
            this.BtnExcluir.Location = new System.Drawing.Point(248, 113);
            this.BtnExcluir.Name = "BtnExcluir";
            this.BtnExcluir.Size = new System.Drawing.Size(83, 27);
            this.BtnExcluir.TabIndex = 26;
            this.BtnExcluir.Text = "Excluir";
            this.BtnExcluir.UseVisualStyleBackColor = true;
            this.BtnExcluir.Click += new System.EventHandler(this.BtnExcluir_Click);
            // 
            // BtnAlterar
            // 
            this.BtnAlterar.Location = new System.Drawing.Point(149, 113);
            this.BtnAlterar.Name = "BtnAlterar";
            this.BtnAlterar.Size = new System.Drawing.Size(83, 27);
            this.BtnAlterar.TabIndex = 25;
            this.BtnAlterar.Text = "Alterar";
            this.BtnAlterar.UseVisualStyleBackColor = true;
            this.BtnAlterar.Click += new System.EventHandler(this.BtnAlterar_Click);
            // 
            // BtnIncluir
            // 
            this.BtnIncluir.Location = new System.Drawing.Point(49, 113);
            this.BtnIncluir.Name = "BtnIncluir";
            this.BtnIncluir.Size = new System.Drawing.Size(83, 27);
            this.BtnIncluir.TabIndex = 24;
            this.BtnIncluir.Text = "Incluir";
            this.BtnIncluir.UseVisualStyleBackColor = true;
            this.BtnIncluir.Click += new System.EventHandler(this.BtnIncluir_Click);
            // 
            // TxtFuncao
            // 
            this.TxtFuncao.Location = new System.Drawing.Point(9, 74);
            this.TxtFuncao.Name = "TxtFuncao";
            this.TxtFuncao.Size = new System.Drawing.Size(100, 20);
            this.TxtFuncao.TabIndex = 23;
            // 
            // TxtNomeC
            // 
            this.TxtNomeC.Location = new System.Drawing.Point(95, 24);
            this.TxtNomeC.Name = "TxtNomeC";
            this.TxtNomeC.Size = new System.Drawing.Size(266, 20);
            this.TxtNomeC.TabIndex = 22;
            // 
            // TxtRE
            // 
            this.TxtRE.Location = new System.Drawing.Point(9, 25);
            this.TxtRE.Name = "TxtRE";
            this.TxtRE.Size = new System.Drawing.Size(68, 20);
            this.TxtRE.TabIndex = 21;
            this.TxtRE.Leave += new System.EventHandler(this.TxtRE_Leave);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 58);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 20;
            this.label3.Text = "Função";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(92, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 19;
            this.label2.Text = "Nome";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(22, 13);
            this.label1.TabIndex = 18;
            this.label1.Text = "RE";
            // 
            // GrdColaborador
            // 
            this.GrdColaborador.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GrdColaborador.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.GrdColaborador.Location = new System.Drawing.Point(0, 146);
            this.GrdColaborador.Name = "GrdColaborador";
            this.GrdColaborador.Size = new System.Drawing.Size(394, 304);
            this.GrdColaborador.TabIndex = 27;
            // 
            // FrmColaborador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(394, 450);
            this.Controls.Add(this.GrdColaborador);
            this.Controls.Add(this.BtnExcluir);
            this.Controls.Add(this.BtnAlterar);
            this.Controls.Add(this.BtnIncluir);
            this.Controls.Add(this.TxtFuncao);
            this.Controls.Add(this.TxtNomeC);
            this.Controls.Add(this.TxtRE);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FrmColaborador";
            this.Text = "FrmColaborador";
            this.Load += new System.EventHandler(this.FrmColaborador_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GrdColaborador)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnExcluir;
        private System.Windows.Forms.Button BtnAlterar;
        private System.Windows.Forms.Button BtnIncluir;
        private System.Windows.Forms.TextBox TxtFuncao;
        private System.Windows.Forms.TextBox TxtNomeC;
        private System.Windows.Forms.TextBox TxtRE;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView GrdColaborador;
    }
}