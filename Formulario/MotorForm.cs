using System;
using System.Windows.Forms;
using Model;
using Persistence;

namespace Formulario
{
    public partial class MotorForm : Form
    {
        private MotorPersistence mp = new MotorPersistence();

        public MotorForm()
        {
            InitializeComponent();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (IsInvalidForm())
            {
                MessageBox.Show("É necessário preencher todos campos obrigatórios.");
            }
            else
            {
                var motor = new Motor
                {
                    Descricao = txtDescricao.Text
                };
                try
                {
                    mp.Create(motor);
                    MessageBox.Show("Registro salvo com sucesso.");
                    ResetForm();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Ocorreu um erro ao salvar o registro. Erro: {ex.Message}");
                }
            }
        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            dgvMotores.DataSource = null;
            dgvMotores.DataSource = mp.ListAll();
            FormatColumns();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            ResetForm();
            dgvMotores.DataSource = null;
        }

        private bool IsInvalidForm()
        {
            return string.IsNullOrWhiteSpace(txtDescricao.Text);
        }

        private void ResetForm()
        {
            txtId.Clear();
            txtDescricao.Clear();
            txtDescricao.Focus();
        }
        private void FormatColumns()
        {
            dgvMotores.Columns["Descricao"].HeaderText = "Descrição";
        }
    }
}
