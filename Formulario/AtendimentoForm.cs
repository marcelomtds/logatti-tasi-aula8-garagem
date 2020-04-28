using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Windows.Forms;
using Dados;
using Model;
using Persistence;

namespace Formulario
{
    public partial class AtendimentoForm : Form
    {

        private AtendimentoPersistence ap = new AtendimentoPersistence();
        private CarroPersistence carroPersistence = new CarroPersistence();
        private ClientePersistence clientePersistence = new ClientePersistence();
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
                    ap.Create(atendimento);
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
            var atendimentos = ap.ListAll();
            atendimentos.ForEach(it => it.nomeCarro = $"{it.Carro.Marca} {it.Carro.Nome} {it.Carro.Modelo} {it.Carro.Motor.Descricao} {it.Carro.Cor} {it.Carro.AnoFabricacao}/{it.Carro.AnoModelo}");
            dgvAtendimentos.DataSource = null;
            dgvAtendimentos.DataSource = atendimentos;
            FormatColumns();
        }

        private bool IsInvalidForm()
        {
            return string.IsNullOrWhiteSpace(dtpData.Text)
                || cmbCliente.SelectedItem == null
                || cmbCarro.SelectedItem == null;
        }

        private void ResetForm()
        {
            txtId.Text = null;
            dtpData.Text = null;
            cmbCliente.SelectedItem = null;
            cmbCarro.SelectedItem = null;
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
            var carros = carroPersistence.ListAll("c.marca");
            carros.ForEach(it => it.Nome = $"{it.Marca} {it.Nome} {it.Modelo} {it.Motor.Descricao} {it.Cor} {it.AnoFabricacao}/{it.AnoModelo}");
            cmbCarro.DataSource = carros;
            cmbCarro.DisplayMember = "Nome";
            cmbCarro.ValueMember = "Id";
            cmbCarro.SelectedItem = null;
        }

        private void ListAllClientes()
        {
            cmbCliente.DataSource = clientePersistence.ListAll();
            cmbCliente.DisplayMember = "Nome";
            cmbCliente.ValueMember = "Id";
            cmbCliente.SelectedItem = null;

        }
    }
}
