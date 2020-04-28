using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Windows.Forms;
using Dados;
using Model;

namespace Formulario
{
    public partial class GaragemForm : Form
    {
        private DataBase db;
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
                    Save(garagem);
                    MessageBox.Show("Registro salvo com sucesso.");
                    ResetForm();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Ocorreu um erro ao salvar o registro. Erro: {ex.Message}");
                }
            }
        }

        private void Save(Garagem garagem)
        {
            var sql = $"INSERT INTO garagem (cnpj, nome, telefone) VALUES ('{garagem.CNPJ}', '{garagem.Nome}', '{garagem.Telefone}')";
            using (db = new DataBase())
            {
                db.ExecuteCommand(sql);
            }
        }

        private List<Garagem> ListAll()
        {
            using (db = new DataBase())
            {
                var sql = "SELECT id, cnpj, nome, telefone FROM garagem ORDER BY nome ASC";
                var retorno = db.ExecuteCommandWithReturn(sql);
                return ReadList(retorno);
            }
        }

        private bool IsInvalidForm()
        {
            return string.IsNullOrWhiteSpace(txtCNPJ.Text)
                || string.IsNullOrWhiteSpace(txtTelefone.Text)
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

        private List<Garagem> ReadList(SqlDataReader response)
        {
            List<Garagem> garagens = new List<Garagem>();
            while (response.Read())
            {
                var garagem = new Garagem()
                {
                    Id = Convert.ToInt32(response["id"]),
                    CNPJ = response["cnpj"].ToString(),
                    Nome = response["nome"].ToString(),
                    Telefone = response["telefone"].ToString()
                };
                garagens.Add(garagem);
            }
            return garagens;
        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            dgvGaragens.DataSource = null;
            dgvGaragens.DataSource = ListAll();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            ResetForm();
            dgvGaragens.DataSource = null;
        }
    }
}
