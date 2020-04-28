namespace Formulario
{
    partial class FuncionarioForm
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
            this.gbFuncionario = new System.Windows.Forms.GroupBox();
            this.dgvFuncionarios = new System.Windows.Forms.DataGridView();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnListar = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.gbDados = new System.Windows.Forms.GroupBox();
            this.lblSalario = new System.Windows.Forms.Label();
            this.txtSalario = new System.Windows.Forms.TextBox();
            this.lblTelefone = new System.Windows.Forms.Label();
            this.txtTelefone = new System.Windows.Forms.TextBox();
            this.lblNome = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.lblId = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.gbFuncionario.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFuncionarios)).BeginInit();
            this.gbDados.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbFuncionario
            // 
            this.gbFuncionario.Controls.Add(this.dgvFuncionarios);
            this.gbFuncionario.Location = new System.Drawing.Point(12, 189);
            this.gbFuncionario.Name = "gbFuncionario";
            this.gbFuncionario.Size = new System.Drawing.Size(416, 215);
            this.gbFuncionario.TabIndex = 9;
            this.gbFuncionario.TabStop = false;
            this.gbFuncionario.Text = "Funcionários";
            // 
            // dgvFuncionarios
            // 
            this.dgvFuncionarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFuncionarios.Location = new System.Drawing.Point(9, 19);
            this.dgvFuncionarios.Name = "dgvFuncionarios";
            this.dgvFuncionarios.ReadOnly = true;
            this.dgvFuncionarios.Size = new System.Drawing.Size(401, 190);
            this.dgvFuncionarios.TabIndex = 5;
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(353, 160);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(75, 23);
            this.btnLimpar.TabIndex = 8;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // btnListar
            // 
            this.btnListar.Location = new System.Drawing.Point(93, 160);
            this.btnListar.Name = "btnListar";
            this.btnListar.Size = new System.Drawing.Size(75, 23);
            this.btnListar.TabIndex = 7;
            this.btnListar.Text = "Listar";
            this.btnListar.UseVisualStyleBackColor = true;
            this.btnListar.Click += new System.EventHandler(this.btnListar_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(12, 160);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(75, 23);
            this.btnSalvar.TabIndex = 6;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // gbDados
            // 
            this.gbDados.Controls.Add(this.lblSalario);
            this.gbDados.Controls.Add(this.txtSalario);
            this.gbDados.Controls.Add(this.lblTelefone);
            this.gbDados.Controls.Add(this.txtTelefone);
            this.gbDados.Controls.Add(this.lblNome);
            this.gbDados.Controls.Add(this.txtNome);
            this.gbDados.Controls.Add(this.lblId);
            this.gbDados.Controls.Add(this.txtId);
            this.gbDados.Location = new System.Drawing.Point(12, 12);
            this.gbDados.Name = "gbDados";
            this.gbDados.Size = new System.Drawing.Size(416, 142);
            this.gbDados.TabIndex = 5;
            this.gbDados.TabStop = false;
            this.gbDados.Text = "Dados";
            // 
            // lblSalario
            // 
            this.lblSalario.AutoSize = true;
            this.lblSalario.Location = new System.Drawing.Point(159, 94);
            this.lblSalario.Name = "lblSalario";
            this.lblSalario.Size = new System.Drawing.Size(46, 13);
            this.lblSalario.TabIndex = 7;
            this.lblSalario.Text = "Salário *";
            // 
            // txtSalario
            // 
            this.txtSalario.Location = new System.Drawing.Point(162, 110);
            this.txtSalario.MaxLength = 8;
            this.txtSalario.Name = "txtSalario";
            this.txtSalario.Size = new System.Drawing.Size(172, 20);
            this.txtSalario.TabIndex = 6;
            // 
            // lblTelefone
            // 
            this.lblTelefone.AutoSize = true;
            this.lblTelefone.Location = new System.Drawing.Point(6, 94);
            this.lblTelefone.Name = "lblTelefone";
            this.lblTelefone.Size = new System.Drawing.Size(56, 13);
            this.lblTelefone.TabIndex = 5;
            this.lblTelefone.Text = "Telefone *";
            // 
            // txtTelefone
            // 
            this.txtTelefone.Location = new System.Drawing.Point(9, 110);
            this.txtTelefone.MaxLength = 15;
            this.txtTelefone.Name = "txtTelefone";
            this.txtTelefone.Size = new System.Drawing.Size(147, 20);
            this.txtTelefone.TabIndex = 4;
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(6, 55);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(42, 13);
            this.lblNome.TabIndex = 3;
            this.lblNome.Text = "Nome *";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(9, 71);
            this.txtNome.MaxLength = 100;
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(325, 20);
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
            // FuncionarioForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(440, 412);
            this.Controls.Add(this.gbFuncionario);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnListar);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.gbDados);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FuncionarioForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Funcionário";
            this.gbFuncionario.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvFuncionarios)).EndInit();
            this.gbDados.ResumeLayout(false);
            this.gbDados.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbFuncionario;
        private System.Windows.Forms.DataGridView dgvFuncionarios;
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
        private System.Windows.Forms.Label lblSalario;
        private System.Windows.Forms.TextBox txtSalario;
    }
}