using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Dados;
using Model;
using Persistence;

namespace Formulario
{
    public partial class CarroForm : Form
    {
        private CarroPersistence cp = new CarroPersistence();
        private MotorPersistence mp = new MotorPersistence();
        private GaragemPersistence gp = new GaragemPersistence();
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
                    cp.Create(carro);
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
            dgvCarros.DataSource = cp.ListAll("c.nome");
            FormatColumns();
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
            cmbMotor.DataSource = mp.ListAll();
            cmbMotor.DisplayMember = "Descricao";
            cmbMotor.ValueMember = "Id";
            cmbMotor.SelectedItem = null;
        }

        private void ListAllGaragens()
        {
            cmbGaragem.DataSource = gp.ListAll();
            cmbGaragem.DisplayMember = "Nome";
            cmbGaragem.ValueMember = "Id";
            cmbGaragem.SelectedItem = null;
        }
    }
}