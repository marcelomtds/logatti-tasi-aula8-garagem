using System;
using System.Windows.Forms;
using Model;
using Persistence;

namespace Formulario
{
    public partial class ClienteForm : Form
    {
        private ClientePersistence cp = new ClientePersistence();
        public ClienteForm()
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
                var cliente = new Cliente
                {
                    Nome = txtNome.Text,
                    Telefone = txtTelefone.Text
                };
                try
                {
                    cp.Create(cliente);
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
            dgvClientes.DataSource = null;
            dgvClientes.DataSource = cp.ListAll();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            ResetForm();
            dgvClientes.DataSource = null;
        }

        private bool IsInvalidForm()
        {
            return string.IsNullOrWhiteSpace(txtNome.Text) || string.IsNullOrWhiteSpace(txtTelefone.Text);
        }

        private void ResetForm()
        {
            txtId.Clear();
            txtNome.Clear();
            txtTelefone.Clear();
            txtNome.Focus();
        }
    }
}