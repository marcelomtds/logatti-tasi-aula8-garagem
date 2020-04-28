using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using Dados;
using Model;

namespace Persistence
{
    public class ClientePersistence
    {
        private DataBase db;
        public void Create(Cliente cliente)
        {
            var sql = $"INSERT INTO cliente (nome, telefone) " +
                      $"VALUES ('{cliente.Nome}', '{cliente.Telefone}')";
            using (db = new DataBase())
            {
                db.ExecuteCommand(sql);
            }
        }

        public List<Cliente> ListAll()
        {
            using (db = new DataBase())
            {
                var sql = "SELECT " +
                            "id, " +
                            "nome, " +
                            "telefone " +
                          "FROM cliente " +
                          "ORDER BY nome ASC";
                var response = db.ExecuteCommandWithReturn(sql);
                return ReadList(response);
            }
        }

        private List<Cliente> ReadList(SqlDataReader response)
        {
            List<Cliente> clientes = new List<Cliente>();
            while (response.Read())
            {
                var cliente = new Cliente()
                {
                    Id = int.Parse(response["id"].ToString()),
                    Nome = response["nome"].ToString(),
                    Telefone = response["telefone"].ToString()
                };
                clientes.Add(cliente);
            }
            return clientes;
        }
    }
}