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
    public class EnderecoDao
    {
        private readonly string _connectionString;

        public EnderecoDao(string connectionString)
        {
            _connectionString = connectionString;
        }

        public void AddEndereco(EnderecoVo endereco)
        {
            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand("INSERT INTO Endereco (Rua, Bairro, Numero, Complemento) VALUES (@Rua, @Bairro, @Numero, @Complemento)", conn))
                {
                    cmd.Parameters.AddWithValue("@Id", endereco.Id);
                    cmd.Parameters.AddWithValue("@Rua", endereco.Rua);
                    cmd.Parameters.AddWithValue("@Bairro", endereco.Bairro);
                    cmd.Parameters.AddWithValue("@Numero", endereco.Numero);
                    cmd.Parameters.AddWithValue("@Complemento", endereco.Complemento);

                    cmd.ExecuteNonQuery();
                }
            }
        }

        public List<EnderecoVo> GetAllEndereco()
        {
            List<EnderecoVo> endereco = new List<EnderecoVo>();

            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand("SELECT * FROM Endereco", conn))
                {
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {            
                            endereco.Add(new EnderecoVo
                            {
                                Id = Convert.ToInt32(reader["Id"]),
                                Rua = reader["Rua"].ToString(),
                                Bairro = reader["Bairro"].ToString(),
                                Numero = Convert.ToInt32(reader["Numero"]),
                                Complemento = reader["Complemento"].ToString()
                            });
                        }
                    }
                }
            }

            return endereco;
        }
    }
}
