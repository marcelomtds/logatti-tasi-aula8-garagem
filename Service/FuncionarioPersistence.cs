using System.Collections.Generic;
using System.Data.SqlClient;
using System.Globalization;
using Dados;
using Model;

namespace Persistence
{
    public class FuncionarioPersistence
    {
        private DataBase db;

        public void Create(Funcionario funcionario)
        {
            var sql = $"INSERT INTO funcionario (nome, telefone, salario) " +
                      $"VALUES ('{funcionario.Nome}', '{funcionario.Telefone}', '{funcionario.Salario.ToString(CultureInfo.CreateSpecificCulture("en-US"))}')";
            using (db = new DataBase())
            {
                db.ExecuteCommand(sql);
            }
        }

        public List<Funcionario> ListAll()
        {
            using (db = new DataBase())
            {
                var sql = "SELECT " +
                            "id, " +
                            "nome, " +
                            "telefone, " +
                            "salario " +
                          "FROM funcionario " +
                          "ORDER BY nome ASC";
                var response = db.ExecuteCommandWithReturn(sql);
                return ReadList(response);
            }
        }

        private List<Funcionario> ReadList(SqlDataReader response)
        {
            List<Funcionario> funcionarios = new List<Funcionario>();
            while (response.Read())
            {
                var funcionario = new Funcionario()
                {
                    Id = int.Parse(response["id"].ToString()),
                    Nome = response["nome"].ToString(),
                    Telefone = response["telefone"].ToString(),
                    Salario = decimal.Parse(response["salario"].ToString())
                };
                funcionarios.Add(funcionario);
            }
            return funcionarios;
        }
    }
}