using System.Collections.Generic;
using System.Data.SqlClient;
using Dados;
using Model;

namespace Persistence
{
    public class GaragemPersistence
    {
        private DataBase db;

        public void Create(Garagem garagem)
        {
            var sql = $"INSERT INTO garagem (cnpj, nome, telefone) " +
                      $"VALUES ('{garagem.CNPJ}', '{garagem.Nome}', '{garagem.Telefone}')";
            using (db = new DataBase())
            {
                db.ExecuteCommand(sql);
            }
        }

        public List<Garagem> ListAll()
        {
            using (db = new DataBase())
            {
                var sql = "SELECT " +
                             "id, " +
                             "cnpj, " +
                             "nome, " +
                             "telefone " +
                          "FROM garagem " +
                          "ORDER BY nome ASC";
                var response = db.ExecuteCommandWithReturn(sql);
                return ReadList(response);
            }
        }

        private List<Garagem> ReadList(SqlDataReader response)
        {
            List<Garagem> garagens = new List<Garagem>();
            while (response.Read())
            {
                var garagem = new Garagem()
                {
                    Id = int.Parse(response["id"].ToString()),
                    CNPJ = response["cnpj"].ToString(),
                    Nome = response["nome"].ToString(),
                    Telefone = response["telefone"].ToString()
                };
                garagens.Add(garagem);
            }
            return garagens;
        }
    }
}