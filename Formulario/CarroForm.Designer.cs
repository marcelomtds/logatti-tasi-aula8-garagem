namespace Formulario
{
    partial class CarroForm
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
            this.gbCliente = new System.Windows.Forms.GroupBox();
            this.dgvCarros = new System.Windows.Forms.DataGridView();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnListar = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.gbDados = new System.Windows.Forms.GroupBox();
            this.cmbGaragem = new System.Windows.Forms.ComboBox();
            this.lblGaragem = new System.Windows.Forms.Label();
            this.cmbMotor = new System.Windows.Forms.ComboBox();
            this.lblMotor = new System.Windows.Forms.Label();
            this.txtAnoModelo = new System.Windows.Forms.TextBox();
            this.lblAnoModelo = new System.Windows.Forms.Label();
            this.txtAnoFabricacao = new System.Windows.Forms.TextBox();
            this.lblAnoFabricacao = new System.Windows.Forms.Label();
            this.txtCor = new System.Windows.Forms.TextBox();
            this.lblCor = new System.Windows.Forms.Label();
            this.txtModelo = new System.Windows.Forms.TextBox();
            this.lblModelo = new System.Windows.Forms.Label();
            this.txtMarca = new System.Windows.Forms.TextBox();
            this.lblMarca = new System.Windows.Forms.Label();
            this.lblNome = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.lblId = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.gbCliente.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCarros)).BeginInit();
            this.gbDados.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbCliente
            // 
            this.gbCliente.Controls.Add(this.dgvCarros);
            this.gbCliente.Location = new System.Drawing.Point(12, 193);
            this.gbCliente.Name = "gbCliente";
            this.gbCliente.Size = new System.Drawing.Size(626, 215);
            this.gbCliente.TabIndex = 9;
            this.gbCliente.TabStop = false;
            this.gbCliente.Text = "Carros";
            // 
            // dgvCarros
            // 
            this.dgvCarros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCarros.Location = new System.Drawing.Point(9, 19);
            this.dgvCarros.Name = "dgvCarros";
            this.dgvCarros.ReadOnly = true;
            this.dgvCarros.Size = new System.Drawing.Size(611, 190);
            this.dgvCarros.TabIndex = 5;
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(563, 164);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(75, 23);
            this.btnLimpar.TabIndex = 8;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // btnListar
            // 
            this.btnListar.Location = new System.Drawing.Point(93, 164);
            this.btnListar.Name = "btnListar";
            this.btnListar.Size = new System.Drawing.Size(75, 23);
            this.btnListar.TabIndex = 7;
            this.btnListar.Text = "Listar";
            this.btnListar.UseVisualStyleBackColor = true;
            this.btnListar.Click += new System.EventHandler(this.btnListar_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(12, 164);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(75, 23);
            this.btnSalvar.TabIndex = 6;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // gbDados
            // 
            this.gbDados.Controls.Add(this.cmbGaragem);
            this.gbDados.Controls.Add(this.lblGaragem);
            this.gbDados.Controls.Add(this.cmbMotor);
            this.gbDados.Controls.Add(this.lblMotor);
            this.gbDados.Controls.Add(this.txtAnoModelo);
            this.gbDados.Controls.Add(this.lblAnoModelo);
            this.gbDados.Controls.Add(this.txtAnoFabricacao);
            this.gbDados.Controls.Add(this.lblAnoFabricacao);
            this.gbDados.Controls.Add(this.txtCor);
            this.gbDados.Controls.Add(this.lblCor);
            this.gbDados.Controls.Add(this.txtModelo);
            this.gbDados.Controls.Add(this.lblModelo);
            this.gbDados.Controls.Add(this.txtMarca);
            this.gbDados.Controls.Add(this.lblMarca);
            this.gbDados.Controls.Add(this.lblNome);
            this.gbDados.Controls.Add(this.txtNome);
            this.gbDados.Controls.Add(this.lblId);
            this.gbDados.Controls.Add(this.txtId);
            this.gbDados.Location = new System.Drawing.Point(12, 12);
            this.gbDados.Name = "gbDados";
            this.gbDados.Size = new System.Drawing.Size(626, 146);
            this.gbDados.TabIndex = 5;
            this.gbDados.TabStop = false;
            this.gbDados.Text = "Dados";
            // 
            // cmbGaragem
            // 
            this.cmbGaragem.FormattingEnabled = true;
            this.cmbGaragem.Location = new System.Drawing.Point(215, 110);
            this.cmbGaragem.Name = "cmbGaragem";
            this.cmbGaragem.Size = new System.Drawing.Size(199, 21);
            this.cmbGaragem.TabIndex = 18;
            // 
            // lblGaragem
            // 
            this.lblGaragem.AutoSize = true;
            this.lblGaragem.Location = new System.Drawing.Point(212, 94);
            this.lblGaragem.Name = "lblGaragem";
            this.lblGaragem.Size = new System.Drawing.Size(57, 13);
            this.lblGaragem.TabIndex = 17;
            this.lblGaragem.Text = "Garagem *";
            // 
            // cmbMotor
            // 
            this.cmbMotor.FormattingEnabled = true;
            this.cmbMotor.Location = new System.Drawing.Point(10, 110);
            this.cmbMotor.Name = "cmbMotor";
            this.cmbMotor.Size = new System.Drawing.Size(199, 21);
            this.cmbMotor.TabIndex = 16;
            // 
            // lblMotor
            // 
            this.lblMotor.AutoSize = true;
            this.lblMotor.Location = new System.Drawing.Point(6, 94);
            this.lblMotor.Name = "lblMotor";
            this.lblMotor.Size = new System.Drawing.Size(41, 13);
            this.lblMotor.TabIndex = 15;
            this.lblMotor.Text = "Motor *";
            // 
            // txtAnoModelo
            // 
            this.txtAnoModelo.Location = new System.Drawing.Point(534, 71);
            this.txtAnoModelo.MaxLength = 4;
            this.txtAnoModelo.Name = "txtAnoModelo";
            this.txtAnoModelo.Size = new System.Drawing.Size(86, 20);
            this.txtAnoModelo.TabIndex = 14;
            // 
            // lblAnoModelo
            // 
            this.lblAnoModelo.AutoSize = true;
            this.lblAnoModelo.Location = new System.Drawing.Point(531, 55);
            this.lblAnoModelo.Name = "lblAnoModelo";
            this.lblAnoModelo.Size = new System.Drawing.Size(71, 13);
            this.lblAnoModelo.TabIndex = 13;
            this.lblAnoModelo.Text = "Ano Modelo *";
            // 
            // txtAnoFabricacao
            // 
            this.txtAnoFabricacao.Location = new System.Drawing.Point(442, 71);
            this.txtAnoFabricacao.MaxLength = 4;
            this.txtAnoFabricacao.Name = "txtAnoFabricacao";
            this.txtAnoFabricacao.Size = new System.Drawing.Size(86, 20);
            this.txtAnoFabricacao.TabIndex = 12;
            // 
            // lblAnoFabricacao
            // 
            this.lblAnoFabricacao.AutoSize = true;
            this.lblAnoFabricacao.Location = new System.Drawing.Point(439, 55);
            this.lblAnoFabricacao.Name = "lblAnoFabricacao";
            this.lblAnoFabricacao.Size = new System.Drawing.Size(89, 13);
            this.lblAnoFabricacao.TabIndex = 11;
            this.lblAnoFabricacao.Text = "Ano Fabricação *";
            // 
            // txtCor
            // 
            this.txtCor.Location = new System.Drawing.Point(290, 71);
            this.txtCor.MaxLength = 50;
            this.txtCor.Name = "txtCor";
            this.txtCor.Size = new System.Drawing.Size(146, 20);
            this.txtCor.TabIndex = 10;
            // 
            // lblCor
            // 
            this.lblCor.AutoSize = true;
            this.lblCor.Location = new System.Drawing.Point(287, 55);
            this.lblCor.Name = "lblCor";
            this.lblCor.Size = new System.Drawing.Size(30, 13);
            this.lblCor.TabIndex = 9;
            this.lblCor.Text = "Cor *";
            // 
            // txtModelo
            // 
            this.txtModelo.Location = new System.Drawing.Point(9, 71);
            this.txtModelo.MaxLength = 100;
            this.txtModelo.Name = "txtModelo";
            this.txtModelo.Size = new System.Drawing.Size(275, 20);
            this.txtModelo.TabIndex = 8;
            // 
            // lblModelo
            // 
            this.lblModelo.AutoSize = true;
            this.lblModelo.Location = new System.Drawing.Point(6, 55);
            this.lblModelo.Name = "lblModelo";
            this.lblModelo.Size = new System.Drawing.Size(49, 13);
            this.lblModelo.TabIndex = 7;
            this.lblModelo.Text = "Modelo *";
            // 
            // txtMarca
            // 
            this.txtMarca.Location = new System.Drawing.Point(396, 32);
            this.txtMarca.MaxLength = 100;
            this.txtMarca.Name = "txtMarca";
            this.txtMarca.Size = new System.Drawing.Size(225, 20);
            this.txtMarca.TabIndex = 6;
            // 
            // lblMarca
            // 
            this.lblMarca.AutoSize = true;
            this.lblMarca.Location = new System.Drawing.Point(393, 16);
            this.lblMarca.Name = "lblMarca";
            this.lblMarca.Size = new System.Drawing.Size(44, 13);
            this.lblMarca.TabIndex = 5;
            this.lblMarca.Text = "Marca *";
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(112, 16);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(42, 13);
            this.lblNome.TabIndex = 3;
            this.lblNome.Text = "Nome *";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(115, 32);
            this.txtNome.MaxLength = 100;
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(275, 20);
            this.txtNome.TabIndex = 2;
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(6, 16);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(18, 13);
            this.lblId.TabIndex = 1;
            this.lblId.Text = "ID";
            // 
            // txtId
            // 
            this.txtId.Enabled = false;
            this.txtId.Location = new System.Drawing.Point(9, 32);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(100, 20);
            this.txtId.TabIndex = 0;
            // 
            // CarroForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(650, 420);
            this.Controls.Add(this.gbCliente);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnListar);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.gbDados);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CarroForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Carro";
            this.gbCliente.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCarros)).EndInit();
            this.gbDados.ResumeLayout(false);
            this.gbDados.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbCliente;
        private System.Windows.Forms.DataGridView dgvCarros;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnListar;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.GroupBox gbDados;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.TextBox txtModelo;
        private System.Windows.Forms.Label lblModelo;
        private System.Windows.Forms.TextBox txtMarca;
        private System.Windows.Forms.Label lblMarca;
        private System.Windows.Forms.TextBox txtCor;
        private System.Windows.Forms.Label lblCor;
        private System.Windows.Forms.TextBox txtAnoFabricacao;
        private System.Windows.Forms.Label lblAnoFabricacao;
        private System.Windows.Forms.TextBox txtAnoModelo;
        private System.Windows.Forms.Label lblAnoModelo;
        private System.Windows.Forms.ComboBox cmbGaragem;
        private System.Windows.Forms.Label lblGaragem;
        private System.Windows.Forms.ComboBox cmbMotor;
        private System.Windows.Forms.Label lblMotor;
    }
}