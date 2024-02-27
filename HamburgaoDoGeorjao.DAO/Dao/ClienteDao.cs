using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using HamburgaoDoGeorjao.DAO.ValueObjects;


namespace HamburgaoDoGeorjao.DAO.Dao
{
    public class ClienteDao
    {
        private readonly string _connectionString;

        public ClienteDao(string connectionString)
        {
            _connectionString = connectionString;
        }

        public void AddCliente(ClienteVo cliente)
        {
            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand("INSERT INTO Cliente (Nome, CPF, Email, Numero) VALUES (@Nome, @CPF, @Email, @Numero)", conn))
                {

                    // alterar para a coluna Endereco puxar a tabela endereco.... ---- implementar ----
                    // alterar para a coluna Endereco puxar a tabela endereco.... ---- implementar ----
                    // alterar para a coluna Endereco puxar a tabela endereco.... ---- implementar ----

                    cmd.Parameters.AddWithValue("@Id", cliente.Id);
                    cmd.Parameters.AddWithValue("@UserId", cliente.UserId);
                    cmd.Parameters.AddWithValue("@Nome", cliente.Nome);
                    cmd.Parameters.AddWithValue("@CPF", cliente.CPF);
                    cmd.Parameters.AddWithValue("@Email", cliente.Email);
                    cmd.Parameters.AddWithValue("@Senha", cliente.Senha);

                    cmd.ExecuteNonQuery();
                }
            }
        }

        public List<ClienteVo> GetAllClientes()
        {
            List<ClienteVo> clientes = new List<ClienteVo>();

            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand("SELECT * FROM Cliente", conn))
                {
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            clientes.Add(new ClienteVo
                            {
                                Id = Convert.ToInt32(reader["Id"]),

                                //conferir o UserID
                                //conferir o UserID
                                //conferir o UserID

                                UserId = (Guid)reader["UserId"],
                                Nome = reader["Nome"].ToString(),
                                CPF = Convert.ToInt32(reader["CPF"]),
                                Email = reader["Email"].ToString(),
                                Senha = reader["Senha"].ToString()
                            });
                        }
                    }
                }
            }

            return clientes;
        }
    }
}
