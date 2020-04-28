using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Windows.Forms;
using Dados;
using Model;

namespace Formulario
{
    public partial class MotorForm : Form
    {
        private DataBase db;
        public MotorForm()
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
                var motor = new Motor
                {
                    Descricao = txtDescricao.Text
                };
                try
                {
                    Save(motor);
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
            dgvMotores.DataSource = null;
            dgvMotores.DataSource = ListAll();
            FormatColumns();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            ResetForm();
            dgvMotores.DataSource = null;
        }

        private void Save(Motor motor)
        {
            var sql = $"INSERT INTO MOTOR (descricao) VALUES ('{motor.Descricao}')";
            using (db = new DataBase())
            {
                db.ExecuteCommand(sql);
            }
        }

        private List<Motor> ListAll()
        {
            using (db = new DataBase())
            {
                var sql = "SELECT id, descricao FROM MOTOR ORDER BY descricao ASC";
                var retorno = db.ExecuteCommandWithReturn(sql);
                return ReadList(retorno);
            }
        }
        private bool IsInvalidForm()
        {
            return string.IsNullOrWhiteSpace(txtDescricao.Text);
        }

        private void ResetForm()
        {
            txtId.Clear();
            txtDescricao.Clear();
            txtDescricao.Focus();
        }

        private List<Motor> ReadList(SqlDataReader response)
        {
            List<Motor> motores = new List<Motor>();
            while (response.Read())
            {
                var motor = new Motor()
                {
                    Id = Convert.ToInt32(response["id"]),
                    Descricao = response["descricao"].ToString(),
                };
                motores.Add(motor);
            }
            return motores;
        }

        private void FormatColumns()
        {
            dgvMotores.Columns["Descricao"].HeaderText = "Descrição";
        }
    }
}
