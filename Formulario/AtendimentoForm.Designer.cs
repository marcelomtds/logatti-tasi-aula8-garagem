namespace Formulario
{
    partial class AtendimentoForm
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
            this.gbAtendimento = new System.Windows.Forms.GroupBox();
            this.dgvAtendimentos = new System.Windows.Forms.DataGridView();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnListar = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.gbDados = new System.Windows.Forms.GroupBox();
            this.dtpData = new System.Windows.Forms.DateTimePicker();
            this.lblData = new System.Windows.Forms.Label();
            this.cmbCarro = new System.Windows.Forms.ComboBox();
            this.lblCarro = new System.Windows.Forms.Label();
            this.cmbCliente = new System.Windows.Forms.ComboBox();
            this.lblCliente = new System.Windows.Forms.Label();
            this.lblId = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.gbAtendimento.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAtendimentos)).BeginInit();
            this.gbDados.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbAtendimento
            // 
            this.gbAtendimento.Controls.Add(this.dgvAtendimentos);
            this.gbAtendimento.Location = new System.Drawing.Point(12, 228);
            this.gbAtendimento.Name = "gbAtendimento";
            this.gbAtendimento.Size = new System.Drawing.Size(648, 221);
            this.gbAtendimento.TabIndex = 14;
            this.gbAtendimento.TabStop = false;
            this.gbAtendimento.Text = "Atendimentos";
            // 
            // dgvAtendimentos
            // 
            this.dgvAtendimentos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAtendimentos.Location = new System.Drawing.Point(6, 19);
            this.dgvAtendimentos.Name = "dgvAtendimentos";
            this.dgvAtendimentos.ReadOnly = true;
            this.dgvAtendimentos.Size = new System.Drawing.Size(633, 190);
            this.dgvAtendimentos.TabIndex = 5;
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(585, 199);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(75, 23);
            this.btnLimpar.TabIndex = 13;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // btnListar
            // 
            this.btnListar.Location = new System.Drawing.Point(93, 199);
            this.btnListar.Name = "btnListar";
            this.btnListar.Size = new System.Drawing.Size(75, 23);
            this.btnListar.TabIndex = 12;
            this.btnListar.Text = "Listar";
            this.btnListar.UseVisualStyleBackColor = true;
            this.btnListar.Click += new System.EventHandler(this.btnListar_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(12, 199);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(75, 23);
            this.btnSalvar.TabIndex = 11;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // gbDados
            // 
            this.gbDados.Controls.Add(this.dtpData);
            this.gbDados.Controls.Add(this.lblData);
            this.gbDados.Controls.Add(this.cmbCarro);
            this.gbDados.Controls.Add(this.lblCarro);
            this.gbDados.Controls.Add(this.cmbCliente);
            this.gbDados.Controls.Add(this.lblCliente);
            this.gbDados.Controls.Add(this.lblId);
            this.gbDados.Controls.Add(this.txtId);
            this.gbDados.ForeColor = System.Drawing.Color.Black;
            this.gbDados.Location = new System.Drawing.Point(12, 12);
            this.gbDados.Name = "gbDados";
            this.gbDados.Size = new System.Drawing.Size(648, 181);
            this.gbDados.TabIndex = 10;
            this.gbDados.TabStop = false;
            this.gbDados.Text = "Dados";
            // 
            // dtpData
            // 
            this.dtpData.Location = new System.Drawing.Point(11, 151);
            this.dtpData.Name = "dtpData";
            this.dtpData.Size = new System.Drawing.Size(319, 20);
            this.dtpData.TabIndex = 21;
            // 
            // lblData
            // 
            this.lblData.AutoSize = true;
            this.lblData.Location = new System.Drawing.Point(8, 135);
            this.lblData.Name = "lblData";
            this.lblData.Size = new System.Drawing.Size(37, 13);
            this.lblData.TabIndex = 20;
            this.lblData.Text = "Data *";
            // 
            // cmbCarro
            // 
            this.cmbCarro.FormattingEnabled = true;
            this.cmbCarro.Location = new System.Drawing.Point(9, 111);
            this.cmbCarro.Name = "cmbCarro";
            this.cmbCarro.Size = new System.Drawing.Size(410, 21);
            this.cmbCarro.TabIndex = 18;
            // 
            // lblCarro
            // 
            this.lblCarro.AutoSize = true;
            this.lblCarro.Location = new System.Drawing.Point(6, 95);
            this.lblCarro.Name = "lblCarro";
            this.lblCarro.Size = new System.Drawing.Size(39, 13);
            this.lblCarro.TabIndex = 17;
            this.lblCarro.Text = "Carro *";
            // 
            // cmbCliente
            // 
            this.cmbCliente.FormattingEnabled = true;
            this.cmbCliente.Location = new System.Drawing.Point(9, 71);
            this.cmbCliente.Name = "cmbCliente";
            this.cmbCliente.Size = new System.Drawing.Size(410, 21);
            this.cmbCliente.TabIndex = 16;
            // 
            // lblCliente
            // 
            this.lblCliente.AutoSize = true;
            this.lblCliente.Location = new System.Drawing.Point(6, 55);
            this.lblCliente.Name = "lblCliente";
            this.lblCliente.Size = new System.Drawing.Size(46, 13);
            this.lblCliente.TabIndex = 15;
            this.lblCliente.Text = "Cliente *";
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
            // AtendimentoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(672, 457);
            this.Controls.Add(this.gbAtendimento);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnListar);
            this.Controls.Add(this.gbDados);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AtendimentoForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Atendimento";
            this.gbAtendimento.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAtendimentos)).EndInit();
            this.gbDados.ResumeLayout(false);
            this.gbDados.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbAtendimento;
        private System.Windows.Forms.DataGridView dgvAtendimentos;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnListar;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.GroupBox gbDados;
        private System.Windows.Forms.ComboBox cmbCarro;
        private System.Windows.Forms.Label lblCarro;
        private System.Windows.Forms.ComboBox cmbCliente;
        private System.Windows.Forms.Label lblCliente;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label lblData;
        private System.Windows.Forms.DateTimePicker dtpData;
    }
}