using System.Collections.Generic;
using System.Data.SqlClient;
using Dados;
using Model;

namespace Persistence
{
    public class MotorPersistence
    {
        private DataBase db;

        public void Create(Motor motor)
        {
            var sql = $"INSERT INTO motor (descricao) " +
                      $"VALUES ('{motor.Descricao}')";
            using (db = new DataBase())
            {
                db.ExecuteCommand(sql);
            }
        }

        public List<Motor> ListAll()
        {
            using (db = new DataBase())
            {
                var sql = "SELECT " +
                            "id, " +
                            "descricao " +
                          "FROM motor " +
                          "ORDER BY descricao ASC";
                var response = db.ExecuteCommandWithReturn(sql);
                return ReadList(response);
            }
        }

        private List<Motor> ReadList(SqlDataReader response)
        {
            List<Motor> motores = new List<Motor>();
            while (response.Read())
            {
                var motor = new Motor()
                {
                    Id = int.Parse(response["id"].ToString()),
                    Descricao = response["descricao"].ToString(),
                };
                motores.Add(motor);
            }
            return motores;
        }
    }
}
