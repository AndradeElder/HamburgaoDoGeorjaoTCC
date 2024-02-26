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

        public void AddMovie(EnderecoVo endereco)
        {
            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand("INSERT INTO Endereco (Rua, Bairro, Numero, Complemento) VALUES (@Rua, @Bairro, @Numero, @Complemento)", conn))
                {
                    cmd.Parameters.AddWithValue("@Id", endereco.Id);
                    cmd.Parameters.AddWithValue("@Title", endereco.Rua);
                    cmd.Parameters.AddWithValue("@ReleaseDate", endereco.Bairro);
                    cmd.Parameters.AddWithValue("@Genre", endereco.Numero);
                    cmd.Parameters.AddWithValue("@Price", endereco.Complemento);

                    cmd.ExecuteNonQuery();
                }
            }
        }

        public List<EnderecoVo> GetAllMovies()
        {
            List<EnderecoVo> endereco = new List<EnderecoVo>();

            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand("SELECT * FROM Movie", conn))
                {
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            // alterar para as tabelas originais
                            // alterar para as tabelas originais
                            // alterar para as tabelas originais
                            // alterar para as tabelas originais
                            endereco.Add(new EnderecoVo
                            {
                                Id = Convert.ToInt32(reader["Id"]),
                                Title = reader["Title"].ToString(),
                                ReleaseDate = Convert.ToDateTime(reader["ReleaseDate"]),
                                Genre = reader["Genre"].ToString(),
                                Price = Convert.ToDecimal(reader["Price"])
                            });
                        }
                    }
                }
            }

            return movies;
        }
    }
}
