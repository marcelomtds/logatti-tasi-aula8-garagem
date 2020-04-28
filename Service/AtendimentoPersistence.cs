using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using Dados;
using Model;

namespace Persistence
{
    public class AtendimentoPersistence
    {
        private DataBase db;

        public void Create(Atendimento atendimento)
        {
            var sql = $"INSERT INTO atendimento (data, id_cliente, id_carro) " +
                      $"VALUES ('{atendimento.Data}', {atendimento.Cliente.Id}, {atendimento.Carro.Id})";
            using (db = new DataBase())
            {
                db.ExecuteCommand(sql);
            }
        }

        public List<Atendimento> ListAll()
        {
            using (db = new DataBase())
            {
                var sql = "SELECT " +
                               "a.id, " +
                               "a.data, " +
                               "cli.id AS id_cliente, " +
                               "cli.nome AS nome_cliente, " +
                               "cli.telefone AS telefone_cliente, " +
                               "m.id AS id_motor, " +
                               "m.descricao AS descricao_motor, " +
                               "c.id AS id_carro, " +
                               "c.nome AS nome_carro, " +
                               "c.marca AS marca_carro, " +
                               "c.modelo AS modelo_carro, " +
                               "c.cor AS cor_carro, " +
                               "c.ano_fabricacao AS ano_fabricacao_carro, " +
                               "c.ano_modelo AS ano_modelo_carro " +
                          "FROM atendimento AS a " +
                          "INNER JOIN cliente AS cli ON cli.id = a.id_cliente " +
                          "INNER JOIN carro AS c ON c.id = a.id_carro " +
                          "INNER JOIN motor AS m ON m.id = c.id_motor " +
                          "ORDER BY a.data ASC";
                var response = db.ExecuteCommandWithReturn(sql);
                return ReadList(response);
            }
        }

        private List<Atendimento> ReadList(SqlDataReader response)
        {
            List<Atendimento> atendimentos = new List<Atendimento>();
            while (response.Read())
            {
                var motor = new Motor()
                {
                    Id = int.Parse(response["id_motor"].ToString()),
                    Descricao = response["descricao_motor"].ToString()
                };

                var carro = new Carro()
                {
                    Id = int.Parse(response["id_carro"].ToString()),
                    Nome = response["nome_carro"].ToString(),
                    Marca = response["marca_carro"].ToString(),
                    Modelo = response["modelo_carro"].ToString(),
                    Cor = response["cor_carro"].ToString(),
                    Motor = motor,
                    AnoFabricacao = int.Parse(response["ano_fabricacao_carro"].ToString()),
                    AnoModelo = int.Parse(response["ano_modelo_carro"].ToString())
                };

                var cliente = new Cliente()
                {
                    Id = int.Parse(response["id_cliente"].ToString()),
                    Nome = response["nome_cliente"].ToString(),
                    Telefone = response["telefone_cliente"].ToString()
                };

                var atendimento = new Atendimento()
                {
                    Id = int.Parse(response["id"].ToString()),
                    Data = Convert.ToDateTime(response["data"]),
                    Carro = carro,
                    Cliente = cliente,
                    nomeCliente = cliente.Nome,
                    nomeCarro = carro.Nome
                };
                atendimentos.Add(atendimento);
            }
            return atendimentos;
        }
    }
}