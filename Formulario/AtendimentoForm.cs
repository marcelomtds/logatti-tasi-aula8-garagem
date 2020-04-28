using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Windows.Forms;
using Dados;
using Model;

namespace Formulario
{
    public partial class AtendimentoForm : Form
    {
        private DataBase db;
        public AtendimentoForm()
        {
            InitializeComponent();
            ListAllCarros();
            ListAllClientes();
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
                    var cliente = new Cliente()
                    {
                        Id = int.Parse(cmbCliente.SelectedValue.ToString())
                    };

                    var carro = new Carro()
                    {
                        Id = int.Parse(cmbCarro.SelectedValue.ToString())
                    };

                    var atendimento = new Atendimento()
                    {
                        Data = dtpData.Value,
                        Cliente = cliente,
                        Carro = carro
                    };
                    Save(atendimento);
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
            dgvAtendimentos.DataSource = null;
        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            dgvAtendimentos.DataSource = null;
            dgvAtendimentos.DataSource = ListAll();
            FormatColumns();
        }

        private void Save(Atendimento atendimento)
        {
            var sql = $"INSERT INTO atendimento (data, id_cliente, id_carro) " +
                $"VALUES ('{atendimento.Data}', '{atendimento.Cliente.Id}', '{atendimento.Carro.Id}')";
            using (db = new DataBase())
            {
                db.ExecuteCommand(sql);
            }
        }

        private List<Atendimento> ListAll()
        {
            using (db = new DataBase())
            {
                var sql = "SELECT " +
                    "a.id, " +
                    "a.data, " +
                    "cli.nome AS [nome_cliente], " +
                    "c.nome AS [nome_carro] " +
                    "FROM atendimento AS a " +
                    "INNER JOIN cliente AS cli ON cli.id = a.id_cliente " +
                    "INNER JOIN carro AS c ON c.id = a.id_carro " +
                    "ORDER BY a.data ASC";
                var retorno = db.ExecuteCommandWithReturn(sql);
                return ReadList(retorno);
            }
        }

        private bool IsInvalidForm()
        {
            return string.IsNullOrWhiteSpace(dtpData.Text)
                || cmbCliente.SelectedItem == null
                || cmbCarro.SelectedItem == null;
        }

        private void ResetForm()
        {
            dtpData.Text = null;
            cmbCliente.SelectedItem = null;
            cmbCarro.SelectedItem = null;
        }

        private List<Atendimento> ReadList(SqlDataReader response)
        {
            List<Atendimento> atendimentos = new List<Atendimento>();
            while (response.Read())
            {
                var atendimento = new Atendimento()
                {
                    Id = Convert.ToInt32(response["id"]),
                    Data = Convert.ToDateTime(response["data"]),
                    nomeCliente = response["nome_cliente"].ToString(),
                    nomeCarro = response["nome_carro"].ToString()
                };
                atendimentos.Add(atendimento);
            }
            return atendimentos;
        }

        private void FormatColumns()
        {
            dgvAtendimentos.Columns[1].Visible = false;
            dgvAtendimentos.Columns[2].Visible = false;
            dgvAtendimentos.Columns["nomeCliente"].HeaderText = "Cliente";
            dgvAtendimentos.Columns["nomeCarro"].HeaderText = "Carro";
        }

        private void ListAllCarros()
        {
            using (db = new DataBase())
            {
                var sql = "SELECT id, nome FROM carro ORDER BY nome ASC";
                var response = db.ExecuteCommandWithReturn(sql);
                var carros = new List<Carro>();
                while (response.Read())
                {
                    var carro = new Carro()
                    {
                        Id = Convert.ToInt32(response["id"]),
                        Nome = response["nome"].ToString(),
                    };
                    carros.Add(carro);
                }
                cmbCarro.DataSource = carros;
                cmbCarro.DisplayMember = "Nome";
                cmbCarro.ValueMember = "Id";
                cmbCarro.SelectedItem = null;
            }
        }

        private void ListAllClientes()
        {
            using (db = new DataBase())
            {
                var sql = "SELECT id, nome FROM cliente ORDER BY nome ASC";
                var response = db.ExecuteCommandWithReturn(sql);
                var clientes = new List<Cliente>();
                while (response.Read())
                {
                    var cliente = new Cliente()
                    {
                        Id = Convert.ToInt32(response["id"].ToString()),
                        Nome = response["nome"].ToString()
                    };
                    clientes.Add(cliente);
                }
                cmbCliente.DataSource = clientes;
                cmbCliente.DisplayMember = "Nome";
                cmbCliente.ValueMember = "Id";
                cmbCliente.SelectedItem = null;
            }
        }
    }
}
