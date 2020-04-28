using System;
using System.Windows.Forms;
using Model;
using Persistence;

namespace Formulario
{
    public partial class GaragemForm : Form
    {
        private GaragemPersistence gp = new GaragemPersistence();
        public GaragemForm()
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
                var garagem = new Garagem
                {
                    CNPJ = txtCNPJ.Text,
                    Nome = txtNome.Text,
                    Telefone = txtTelefone.Text
                };
                try
                {
                    gp.Create(garagem);
                    MessageBox.Show("Registro salvo com sucesso.");
                    ResetForm();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Ocorreu um erro ao salvar o registro. Erro: {ex.Message}");
                }
            }
        }

        private bool IsInvalidForm()
        {
            return string.IsNullOrWhiteSpace(txtCNPJ.Text)
                || string.IsNullOrWhiteSpace(txtNome.Text)
                || string.IsNullOrWhiteSpace(txtTelefone.Text);
        }

        private void ResetForm()
        {
            txtId.Clear();
            txtCNPJ.Clear();
            txtNome.Clear();
            txtTelefone.Clear();
            txtCNPJ.Focus();
        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            dgvGaragens.DataSource = null;
            dgvGaragens.DataSource = gp.ListAll();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            ResetForm();
            dgvGaragens.DataSource = null;
        }
    }
}