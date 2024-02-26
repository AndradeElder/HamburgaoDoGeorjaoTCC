using HamburgaoDoGeorjao.DAO.ValueObjects;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Adicionar tabelas para aparecer quantidade de cada item. e alterar apenas a quantidade. os nomes dos itens ja estão listados como coluna.

namespace HamburgaoDoGeorjao.DAO.Dao
{
    public class IngredientesDao
    {
        private readonly string _connectionString;

        public IngredientesDao(string connectionString)
        {
            _connectionString = connectionString;
        }

        public void AddIngrediente(IngredientesVo ingrediente)
        {
            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand("INSERT INTO Ingredientes (Pao, Carne, Maionese, Alface, Bacon, Ovo, Tomate, Queijo, Picles, QueijoCheddar)" +
                    " VALUES (@Pao, @Carne, @Maionese, @Alface, @Bacon, @Ovo, @Tomate, @Queijo, @Picles, @QueijoCheddar)", conn))
                {

                    // alterar para a coluna Ingredientes puxar a tabela ingredientes.... ---- implementar ----
                    // alterar para a coluna Ingredientes puxar a tabela ingredientes.... ---- implementar ----
                    // alterar para a coluna Ingredientes puxar a tabela ingredientes.... ---- implementar ----

                    cmd.Parameters.AddWithValue("@Id", ingrediente.Id);
                    cmd.Parameters.AddWithValue("@Pao", ingrediente.Pao);
                    cmd.Parameters.AddWithValue("@Carne", ingrediente.Carne);
                    cmd.Parameters.AddWithValue("@Maionese", ingrediente.Maionese);
                    cmd.Parameters.AddWithValue("@Alface", ingrediente.Alface);
                    cmd.Parameters.AddWithValue("@Bacon", ingrediente.Bacon);
                    cmd.Parameters.AddWithValue("@Ovo", ingrediente.Ovo);
                    cmd.Parameters.AddWithValue("@Tomate", ingrediente.Tomate);
                    cmd.Parameters.AddWithValue("@Queijo", ingrediente.Queijo);
                    cmd.Parameters.AddWithValue("@Picles", ingrediente.Picles);
                    cmd.Parameters.AddWithValue("@QueijoCheddar", ingrediente.QueijoCheddar);

                    cmd.ExecuteNonQuery();
                }
            }
        }

        public List<IngredientesVo> GetAllIngrediente()
        {
            List<IngredientesVo> ingredientes = new List<IngredientesVo>();

            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand("SELECT * FROM Ingredientes", conn))
                {
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            ingredientes.Add(new IngredientesVo
                            {
                                Id = Convert.ToInt32(reader["Id"]),

                                /*
                                    public IngredientesVo Ingredientes { get; set; } --->>> adicionar tabela para puxar outros dados dessa tabelas
                                */

                                Pao = reader["Pao"].ToString(),
                                Carne = reader["Carne"].ToString(),
                                Maionese = reader["Maionese"].ToString(),
                                Alface = reader["Alface"].ToString(),
                                Bacon = reader["Bacon"].ToString(),
                                Ovo = reader["Ovo"].ToString(),
                                Tomate = reader["Tomate"].ToString(),
                                Queijo = reader["Queijo"].ToString(),
                                Picles = reader["Picles"].ToString(),
                                QueijoCheddar = reader["QueijoCheddar"].ToString()
                            });
                        }
                    }
                }
            }

            return ingredientes;
        }
    }
}
