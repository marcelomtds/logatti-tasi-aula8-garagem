using System;
using System.Windows.Forms;
using Model;
using Persistence;

namespace Formulario
{
    public partial class FuncionarioForm : Form
    {
        private FuncionarioPersistence fp = new FuncionarioPersistence();
        public FuncionarioForm()
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
                try
                {
                    var funcionario = new Funcionario
                    {
                        Nome = txtNome.Text,
                        Telefone = txtTelefone.Text,
                        Salario = decimal.Parse(txtSalario.Text.ToString())
                    };
                    fp.Create(funcionario);
                    MessageBox.Show("Registro salvo com sucesso.");
                    ResetForm();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Ocorreu um erro ao salvar o registro. Erro: {ex.Message}");
                }
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            ResetForm();
            dgvFuncionarios.DataSource = null;
        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            dgvFuncionarios.DataSource = null;
            dgvFuncionarios.DataSource = fp.ListAll();
            FormatColumns();
        }

        private bool IsInvalidForm()
        {
            return string.IsNullOrWhiteSpace(txtNome.Text)
                || string.IsNullOrWhiteSpace(txtTelefone.Text)
                || string.IsNullOrWhiteSpace(txtSalario.Text);
        }

        private void ResetForm()
        {
            txtId.Clear();
            txtNome.Clear();
            txtTelefone.Clear();
            txtSalario.Clear();
            txtNome.Focus();
        }

        private void FormatColumns()
        {
            dgvFuncionarios.Columns["Id"].DisplayIndex = 0;
            dgvFuncionarios.Columns["Nome"].DisplayIndex = 1;
            dgvFuncionarios.Columns["Telefone"].DisplayIndex = 2;
            dgvFuncionarios.Columns["Salario"].DisplayIndex = 3;
            dgvFuncionarios.Columns["Salario"].HeaderText = "Salário";
        }
    }
}