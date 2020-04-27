using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;
using System.Windows.Forms;
using Dados;
using Model;

namespace Formulario
{
    public partial class ClienteForm : Form
    {
        private DataBase db;
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
                    Save(cliente);
                    MessageBox.Show("Cliente salvo com sucesso.");
                    ResetForm();
                }
                catch (Exception)
                {
                    MessageBox.Show("Ocorreu um erro ao salvar o cliente.");
                }
            }
        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            dgvClientes.DataSource = null;
            dgvClientes.DataSource = ListAll();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            ResetForm();
            dgvClientes.DataSource = null;
        }

        private void Save(Cliente cliente)
        {
            var sql = $"INSERT INTO CLIENTE (nome, telefone) VALUES ('{cliente.Nome}', '{cliente.Telefone}')";
            using (db = new DataBase())
            {
                db.ExecuteCommand(sql);
            }
        }

        private List<Cliente> ListAll()
        {
            using (db = new DataBase())
            {
                var sql = "SELECT id, nome, telefone FROM CLIENTE ORDER BY nome ASC";
                var retorno = db.ExecuteCommandWithReturn(sql);
                return ReadList(retorno);
            }
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
        }

        private List<Cliente> ReadList(SqlDataReader response)
        {
            List<Cliente> clientes = new List<Cliente>();
            while (response.Read())
            {
                var cliente = new Cliente()
                {
                    Id = Convert.ToInt32(response["id"]),
                    Nome = response["nome"].ToString(),
                    Telefone = response["telefone"].ToString()
                };
                clientes.Add(cliente);
            }
            return clientes;
        }

    }
}
