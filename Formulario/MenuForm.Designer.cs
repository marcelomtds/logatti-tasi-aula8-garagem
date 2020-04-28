namespace Formulario
{
    partial class MenuForm
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.gerenciarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.itemMenuCliente = new System.Windows.Forms.ToolStripMenuItem();
            this.itemMenuFuncionario = new System.Windows.Forms.ToolStripMenuItem();
            this.itemMenuMotor = new System.Windows.Forms.ToolStripMenuItem();
            this.itemMenuCarro = new System.Windows.Forms.ToolStripMenuItem();
            this.itemMenuGaragem = new System.Windows.Forms.ToolStripMenuItem();
            this.itemMenuAtendimento = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gerenciarToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // gerenciarToolStripMenuItem
            // 
            this.gerenciarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.itemMenuCliente,
            this.itemMenuFuncionario,
            this.itemMenuMotor,
            this.itemMenuCarro,
            this.itemMenuGaragem,
            this.itemMenuAtendimento});
            this.gerenciarToolStripMenuItem.Name = "gerenciarToolStripMenuItem";
            this.gerenciarToolStripMenuItem.Size = new System.Drawing.Size(69, 20);
            this.gerenciarToolStripMenuItem.Text = "Gerenciar";
            // 
            // itemMenuCliente
            // 
            this.itemMenuCliente.Name = "itemMenuCliente";
            this.itemMenuCliente.Size = new System.Drawing.Size(180, 22);
            this.itemMenuCliente.Text = "Cliente";
            this.itemMenuCliente.Click += new System.EventHandler(this.itemMenuCliente_Click);
            // 
            // itemMenuFuncionario
            // 
            this.itemMenuFuncionario.Name = "itemMenuFuncionario";
            this.itemMenuFuncionario.Size = new System.Drawing.Size(180, 22);
            this.itemMenuFuncionario.Text = "Funcionário";
            this.itemMenuFuncionario.Click += new System.EventHandler(this.itemMenuFuncionario_Click);
            // 
            // itemMenuMotor
            // 
            this.itemMenuMotor.Name = "itemMenuMotor";
            this.itemMenuMotor.Size = new System.Drawing.Size(180, 22);
            this.itemMenuMotor.Text = "Motor";
            this.itemMenuMotor.Click += new System.EventHandler(this.itemMenuMotor_Click);
            // 
            // itemMenuCarro
            // 
            this.itemMenuCarro.Name = "itemMenuCarro";
            this.itemMenuCarro.Size = new System.Drawing.Size(180, 22);
            this.itemMenuCarro.Text = "Carro";
            this.itemMenuCarro.Click += new System.EventHandler(this.itemMenuCarro_Click);
            // 
            // itemMenuGaragem
            // 
            this.itemMenuGaragem.Name = "itemMenuGaragem";
            this.itemMenuGaragem.Size = new System.Drawing.Size(180, 22);
            this.itemMenuGaragem.Text = "Garagem";
            this.itemMenuGaragem.Click += new System.EventHandler(this.itemMenuGaragem_Click);
            // 
            // itemMenuAtendimento
            // 
            this.itemMenuAtendimento.Name = "itemMenuAtendimento";
            this.itemMenuAtendimento.Size = new System.Drawing.Size(180, 22);
            this.itemMenuAtendimento.Text = "Atendimento";
            this.itemMenuAtendimento.Click += new System.EventHandler(this.itemMenuAtendimento_Click);
            // 
            // MenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MenuForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sistema de Gerenciamento";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem gerenciarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem itemMenuCliente;
        private System.Windows.Forms.ToolStripMenuItem itemMenuFuncionario;
        private System.Windows.Forms.ToolStripMenuItem itemMenuMotor;
        private System.Windows.Forms.ToolStripMenuItem itemMenuCarro;
        private System.Windows.Forms.ToolStripMenuItem itemMenuGaragem;
        private System.Windows.Forms.ToolStripMenuItem itemMenuAtendimento;
    }
}

