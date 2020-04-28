using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Windows.Forms;
using Dados;
using Model;

namespace Formulario
{
    public partial class CarroForm : Form
    {
        private DataBase db;
        public CarroForm()
        {
            InitializeComponent();
            ListAllMotores();
            ListAllGaragens();
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
                    var garagem = new Garagem()
                    {
                        Id = int.Parse(cmbGaragem.SelectedValue.ToString())
                    };

                    var motor = new Motor()
                    {
                        Id = int.Parse(cmbMotor.SelectedValue.ToString())
                    };

                    var carro = new Carro()
                    {
                        Nome = txtNome.Text,
                        Marca = txtMarca.Text,
                        Modelo = txtModelo.Text,
                        Cor = txtCor.Text,
                        AnoFabricacao = int.Parse(txtAnoFabricacao.Text),
                        AnoModelo = int.Parse(txtAnoModelo.Text),
                        Motor = motor,
                        Garagem = garagem
                    };
                    Save(carro);
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
            dgvCarros.DataSource = null;
        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            dgvCarros.DataSource = null;
            dgvCarros.DataSource = ListAll();
            FormatColumns();
        }

        private void Save(Carro carro)
        {
            var sql = $"INSERT INTO carro (nome, marca, modelo, cor, ano_fabricacao, ano_modelo, id_motor, id_garagem) " +
                $"VALUES ('{carro.Nome}', '{carro.Marca}', '{carro.Modelo}', '{carro.Cor}', {carro.AnoFabricacao}, {carro.AnoModelo}, {carro.Motor.Id}, {carro.Garagem.Id})";
            using (db = new DataBase())
            {
                db.ExecuteCommand(sql);
            }
        }

        private List<Carro> ListAll()
        {
            using (db = new DataBase())
            {
                var sql = "SELECT " +
                    "c.id, " +
                    "c.nome, " +
                    "c.marca, " +
                    "c.modelo, " +
                    "c.cor, " +
                    "c.ano_fabricacao, " +
                    "c.ano_modelo, " +
                    "m.descricao, " +
                    "g.nome AS nome_garagem " +
                    "FROM carro AS c " +
                    "INNER JOIN motor AS m ON m.id = c.id_motor " +
                    "INNER JOIN garagem AS g ON g.id = c.id_garagem " +
                    "ORDER BY c.nome ASC";
                var retorno = db.ExecuteCommandWithReturn(sql);
                return ReadList(retorno);
            }
        }

        private bool IsInvalidForm()
        {
            return string.IsNullOrWhiteSpace(txtNome.Text)
                || string.IsNullOrWhiteSpace(txtMarca.Text)
                || string.IsNullOrWhiteSpace(txtModelo.Text)
                || string.IsNullOrWhiteSpace(txtCor.Text)
                || string.IsNullOrWhiteSpace(txtAnoFabricacao.Text)
                || string.IsNullOrWhiteSpace(txtAnoModelo.Text)
                || cmbMotor.SelectedItem == null
                || cmbGaragem.SelectedItem == null;
        }

        private void ResetForm()
        {
            txtId.Clear();
            txtNome.Clear();
            txtMarca.Clear();
            txtModelo.Clear();
            txtCor.Clear();
            txtAnoFabricacao.Clear();
            txtAnoModelo.Clear();
            cmbMotor.SelectedItem = null;
            cmbGaragem.SelectedItem = null;
            txtNome.Focus();
        }

        private List<Carro> ReadList(SqlDataReader response)
        {
            List<Carro> carros = new List<Carro>();
            while (response.Read())
            {
                var carro = new Carro()
                {
                    Id = Convert.ToInt32(response["id"]),
                    Nome = response["nome"].ToString(),
                    Marca = response["marca"].ToString(),
                    Modelo = response["modelo"].ToString(),
                    Cor = response["cor"].ToString(),
                    AnoFabricacao = Convert.ToInt32(response["ano_fabricacao"]),
                    AnoModelo = Convert.ToInt32(response["ano_modelo"]),
                    descricaoMotor = response["descricao"].ToString(),
                    nomeGaragem = response["nome_garagem"].ToString()
                };
                carros.Add(carro);
            }
            return carros;
        }

        private void FormatColumns()
        {
            dgvCarros.Columns[7].Visible = false;
            dgvCarros.Columns[8].Visible = false;
            dgvCarros.Columns["AnoFabricacao"].HeaderText = "Ano Fabricação";
            dgvCarros.Columns["AnoModelo"].HeaderText = "Ano Modelo";
            dgvCarros.Columns["descricaoMotor"].HeaderText = "Motor";
            dgvCarros.Columns["nomeGaragem"].HeaderText = "Garagem";
        }

        private void ListAllMotores()
        {
            using (db = new DataBase())
            {
                var sql = "SELECT id, descricao FROM motor ORDER BY descricao ASC";
                var response = db.ExecuteCommandWithReturn(sql);
                var motores = new List<Motor>();
                while (response.Read())
                {
                    var motor = new Motor()
                    {
                        Id = Convert.ToInt32(response["id"]),
                        Descricao = response["descricao"].ToString(),
                    };
                    motores.Add(motor);
                }
                cmbMotor.DataSource = motores;
                cmbMotor.DisplayMember = "Descricao";
                cmbMotor.ValueMember = "Id";
                cmbMotor.SelectedItem = null;
            }
        }

        private void ListAllGaragens()
        {
            using (db = new DataBase())
            {
                var sql = "SELECT id, cnpj, nome, telefone FROM garagem ORDER BY nome ASC";
                var response = db.ExecuteCommandWithReturn(sql);
                var garagems = new List<Garagem>();
                while (response.Read())
                {
                    var garagem = new Garagem()
                    {
                        Id = Convert.ToInt32(response["id"].ToString()),
                        CNPJ = response["cnpj"].ToString(),
                        Nome = response["nome"].ToString(),
                        Telefone = response["telefone"].ToString()
                    };
                    garagems.Add(garagem);
                }
                cmbGaragem.DataSource = garagems;
                cmbGaragem.DisplayMember = "Nome";
                cmbGaragem.ValueMember = "Id";
                cmbGaragem.SelectedItem = null;
            }
        }
    }
}
