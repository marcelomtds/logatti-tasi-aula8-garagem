using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Globalization;
using System.Windows.Forms;
using Dados;
using Model;

namespace Formulario
{
    public partial class FuncionarioForm : Form
    {
        private DataBase db;
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
                        Salario = Convert.ToDecimal(txtSalario.Text.ToString())
                    };
                    Save(funcionario);
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
            dgvFuncionarios.DataSource = ListAll();
            FormatColumns();
        }

        private void Save(Funcionario funcionario)
        {
            var sql = $"INSERT INTO FUNCIONARIO (nome, telefone, salario) VALUES ('{funcionario.Nome}', '{funcionario.Telefone}', '{funcionario.Salario.ToString(CultureInfo.CreateSpecificCulture("en-US"))}')";
            using (db = new DataBase())
            {
                db.ExecuteCommand(sql);
            }
        }

        private List<Funcionario> ListAll()
        {
            using (db = new DataBase())
            {
                var sql = "SELECT id, nome, telefone, salario FROM FUNCIONARIO ORDER BY nome ASC";
                var retorno = db.ExecuteCommandWithReturn(sql);
                return ReadList(retorno);
            }
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
        }

        private List<Funcionario> ReadList(SqlDataReader response)
        {
            List<Funcionario> funcionarios = new List<Funcionario>();
            while (response.Read())
            {
                var funcionario = new Funcionario()
                {
                    Id = Convert.ToInt32(response["id"]),
                    Nome = response["nome"].ToString(),
                    Telefone = response["telefone"].ToString(),
                    Salario = Convert.ToDecimal(response["salario"].ToString())
                };
                funcionarios.Add(funcionario);
            }
            return funcionarios;
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
