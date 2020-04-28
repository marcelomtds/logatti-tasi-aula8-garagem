namespace Formulario
{
    partial class GaragemForm
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
            this.gbGaragem = new System.Windows.Forms.GroupBox();
            this.dgvGaragens = new System.Windows.Forms.DataGridView();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnListar = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.gbDados = new System.Windows.Forms.GroupBox();
            this.lblCNPJ = new System.Windows.Forms.Label();
            this.txtCNPJ = new System.Windows.Forms.TextBox();
            this.lblTelefone = new System.Windows.Forms.Label();
            this.txtTelefone = new System.Windows.Forms.TextBox();
            this.lblNome = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.lblId = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.gbGaragem.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGaragens)).BeginInit();
            this.gbDados.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbGaragem
            // 
            this.gbGaragem.Controls.Add(this.dgvGaragens);
            this.gbGaragem.Location = new System.Drawing.Point(12, 191);
            this.gbGaragem.Name = "gbGaragem";
            this.gbGaragem.Size = new System.Drawing.Size(417, 215);
            this.gbGaragem.TabIndex = 9;
            this.gbGaragem.TabStop = false;
            this.gbGaragem.Text = "Garagens";
            // 
            // dgvGaragens
            // 
            this.dgvGaragens.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGaragens.Location = new System.Drawing.Point(9, 19);
            this.dgvGaragens.Name = "dgvGaragens";
            this.dgvGaragens.ReadOnly = true;
            this.dgvGaragens.Size = new System.Drawing.Size(402, 190);
            this.dgvGaragens.TabIndex = 5;
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(354, 162);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(75, 23);
            this.btnLimpar.TabIndex = 8;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // btnListar
            // 
            this.btnListar.Location = new System.Drawing.Point(93, 162);
            this.btnListar.Name = "btnListar";
            this.btnListar.Size = new System.Drawing.Size(75, 23);
            this.btnListar.TabIndex = 7;
            this.btnListar.Text = "Listar";
            this.btnListar.UseVisualStyleBackColor = true;
            this.btnListar.Click += new System.EventHandler(this.btnListar_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(12, 162);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(75, 23);
            this.btnSalvar.TabIndex = 6;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // gbDados
            // 
            this.gbDados.Controls.Add(this.lblCNPJ);
            this.gbDados.Controls.Add(this.txtCNPJ);
            this.gbDados.Controls.Add(this.lblTelefone);
            this.gbDados.Controls.Add(this.txtTelefone);
            this.gbDados.Controls.Add(this.lblNome);
            this.gbDados.Controls.Add(this.txtNome);
            this.gbDados.Controls.Add(this.lblId);
            this.gbDados.Controls.Add(this.txtId);
            this.gbDados.Location = new System.Drawing.Point(12, 12);
            this.gbDados.Name = "gbDados";
            this.gbDados.Size = new System.Drawing.Size(417, 144);
            this.gbDados.TabIndex = 5;
            this.gbDados.TabStop = false;
            this.gbDados.Text = "Dados";
            // 
            // lblCNPJ
            // 
            this.lblCNPJ.AutoSize = true;
            this.lblCNPJ.Location = new System.Drawing.Point(109, 16);
            this.lblCNPJ.Name = "lblCNPJ";
            this.lblCNPJ.Size = new System.Drawing.Size(41, 13);
            this.lblCNPJ.TabIndex = 7;
            this.lblCNPJ.Text = "CNPJ *";
            // 
            // txtCNPJ
            // 
            this.txtCNPJ.Location = new System.Drawing.Point(112, 32);
            this.txtCNPJ.MaxLength = 14;
            this.txtCNPJ.Name = "txtCNPJ";
            this.txtCNPJ.Size = new System.Drawing.Size(190, 20);
            this.txtCNPJ.TabIndex = 6;
            // 
            // lblTelefone
            // 
            this.lblTelefone.AutoSize = true;
            this.lblTelefone.Location = new System.Drawing.Point(3, 94);
            this.lblTelefone.Name = "lblTelefone";
            this.lblTelefone.Size = new System.Drawing.Size(56, 13);
            this.lblTelefone.TabIndex = 5;
            this.lblTelefone.Text = "Telefone *";
            // 
            // txtTelefone
            // 
            this.txtTelefone.Location = new System.Drawing.Point(6, 110);
            this.txtTelefone.MaxLength = 15;
            this.txtTelefone.Name = "txtTelefone";
            this.txtTelefone.Size = new System.Drawing.Size(150, 20);
            this.txtTelefone.TabIndex = 4;
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(3, 55);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(42, 13);
            this.lblNome.TabIndex = 3;
            this.lblNome.Text = "Nome *";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(6, 71);
            this.txtNome.MaxLength = 100;
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(296, 20);
            this.txtNome.TabIndex = 2;
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(3, 16);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(18, 13);
            this.lblId.TabIndex = 1;
            this.lblId.Text = "ID";
            // 
            // txtId
            // 
            this.txtId.Enabled = false;
            this.txtId.Location = new System.Drawing.Point(6, 32);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(100, 20);
            this.txtId.TabIndex = 0;
            // 
            // GaragemForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(443, 418);
            this.Controls.Add(this.gbGaragem);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnListar);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.gbDados);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "GaragemForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Garagem";
            this.gbGaragem.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvGaragens)).EndInit();
            this.gbDados.ResumeLayout(false);
            this.gbDados.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbGaragem;
        private System.Windows.Forms.DataGridView dgvGaragens;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnListar;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.GroupBox gbDados;
        private System.Windows.Forms.Label lblTelefone;
        private System.Windows.Forms.TextBox txtTelefone;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label lblCNPJ;
        private System.Windows.Forms.TextBox txtCNPJ;
    }
}