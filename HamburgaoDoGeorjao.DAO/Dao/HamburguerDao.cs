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
    public class HamburguerDao
    {
        private readonly string _connectionString;

        public HamburguerDao(string connectionString)
        {
            _connectionString = connectionString;
        }

        public void AddHamburguer(HamburguerVo hamburguer)
        {
            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand("INSERT INTO Hamburguer (TipoDePao, Valor, BurgerBliss, BurgerSupremo, PicanhaParadise, RancheroRodeo, SinfoniaDeCogumelos, FrangoFantastico)" +
                    " VALUES (@TipoDePao, @Valor, @BurgerBliss, @BurgerSupremo, @PicanhaParadise, @RancheroRodeo, @SinfoniaDeCogumelos, @FrangoFantastico)", conn))
                {

                    // alterar para a coluna Ingredientes puxar a tabela ingredientes.... ---- implementar ----
                    // alterar para a coluna Ingredientes puxar a tabela ingredientes.... ---- implementar ----
                    // alterar para a coluna Ingredientes puxar a tabela ingredientes.... ---- implementar ----

                    cmd.Parameters.AddWithValue("@Id", hamburguer.Id);
                    cmd.Parameters.AddWithValue("@TipoDePao", hamburguer.TipoDePao);
                    cmd.Parameters.AddWithValue("@Valor", hamburguer.Valor);
                    cmd.Parameters.AddWithValue("@BurgerBliss", hamburguer.BurgerBliss);
                    cmd.Parameters.AddWithValue("@BurgerSupremo", hamburguer.BurgerSupremo);
                    cmd.Parameters.AddWithValue("@PicanhaParadise", hamburguer.PicanhaParadise);
                    cmd.Parameters.AddWithValue("@RancheroRodeo", hamburguer.RancheroRodeo);
                    cmd.Parameters.AddWithValue("@SinfoniaDeCogumelos", hamburguer.SinfoniaDeCogumelos);
                    cmd.Parameters.AddWithValue("@FrangoFantastico", hamburguer.FrangoFantastico);

                    cmd.ExecuteNonQuery();
                }
            }
        }

        public List<HamburguerVo> GetAllHamburguer()
        {
            List<HamburguerVo> hamburguers = new List<HamburguerVo>();

            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand("SELECT * FROM Hamburguer", conn))
                {
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            hamburguers.Add(new HamburguerVo
                            {
                                Id = Convert.ToInt32(reader["Id"]),

                                /*
                                    public IngredientesVo Ingredientes { get; set; } --->>> adicionar tabela para puxar outros dados dessa tabelas
                                */

                                TipoDePao = reader["TipoDePao"].ToString(),
                                Valor = Convert.ToInt32(reader["Valor"]),
                                BurgerBliss = reader["BurgerBliss"].ToString(),
                                BurgerSupremo = reader["BurgerSupremo"].ToString(),
                                PicanhaParadise = reader["PicanhaParadise"].ToString(),
                                RancheroRodeo = reader["RancheroRodeo"].ToString(),
                                SinfoniaDeCogumelos = reader["SinfoniaDeCogumelos"].ToString(),
                                FrangoFantastico = reader["FrangoFantastico"].ToString()
                            });
                        }
                    }
                }
            }

            return hamburguers;
        }
    }
}
