using System.Collections.Generic;
using System.Data.SqlClient;
using Dados;
using Model;

namespace Persistence
{
    public class CarroPersistence
    {
        private DataBase db;

        public void Create(Carro carro)
        {
            var sql = $"INSERT INTO carro (nome, marca, modelo, cor, ano_fabricacao, ano_modelo, id_motor, id_garagem) " +
                      $"VALUES ('{carro.Nome}', '{carro.Marca}', '{carro.Modelo}', '{carro.Cor}', {carro.AnoFabricacao}, {carro.AnoModelo}, {carro.Motor.Id}, {carro.Garagem.Id})";
            using (db = new DataBase())
            {
                db.ExecuteCommand(sql);
            }
        }

        public List<Carro> ListAll(string orderField)
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
                               "m.id AS id_motor, " +
                               "m.descricao AS descricao_motor, " +
                               "g.id AS id_garagem, " +
                               "g.cnpj AS cnpj_garagem, " +
                               "g.nome AS nome_garagem, " +
                               "g.telefone AS telefone_garagem " +
                          "FROM carro AS c " +
                          "INNER JOIN motor AS m ON m.id = c.id_motor " +
                          "INNER JOIN garagem AS g ON g.id = c.id_garagem " +
                          $"ORDER BY {orderField} ASC";
                var response = db.ExecuteCommandWithReturn(sql);
                return ReadList(response);
            }
        }

        private List<Carro> ReadList(SqlDataReader response)
        {
            List<Carro> carros = new List<Carro>();
            while (response.Read())
            {
                var motor = new Motor()
                {
                    Id = int.Parse(response["id_motor"].ToString()),
                    Descricao = response["descricao_motor"].ToString(),
                };

                var garagem = new Garagem()
                {
                    Id = int.Parse(response["id_garagem"].ToString()),
                    CNPJ = response["cnpj_garagem"].ToString(),
                    Nome = response["nome_garagem"].ToString(),
                    Telefone = response["telefone_garagem"].ToString()
                };

                var carro = new Carro()
                {
                    Id = int.Parse(response["id"].ToString()),
                    Nome = response["nome"].ToString(),
                    Marca = response["marca"].ToString(),
                    Modelo = response["modelo"].ToString(),
                    Cor = response["cor"].ToString(),
                    AnoFabricacao = int.Parse(response["ano_fabricacao"].ToString()),
                    AnoModelo = int.Parse(response["ano_modelo"].ToString()),
                    Motor = motor,
                    Garagem = garagem,
                    descricaoMotor = motor.Descricao,
                    nomeGaragem = garagem.Nome
                };
                carros.Add(carro);
            }
            return carros;
        }
    }
}
