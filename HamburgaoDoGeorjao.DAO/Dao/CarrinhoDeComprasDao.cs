using HamburgaoDoGeorjao.DAO.ValueObjects;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HamburgaoDoGeorjao.DAO.Dao
{


    public class CarrinhoDeComprasDao
    {
        private readonly string _connectionString;

        public CarrinhoDeComprasDao(string connectionString)
        {
            _connectionString = connectionString;
        }

        public void AddIngrediente(CarrinhoDeComprasVo carrinho)
        {
            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand("INSERT INTO CarrinhoDeCompras (ClienteVo, PedidoVo, Quantidade)", conn))
                {

                    // alterar para a coluna ClienteVo puxar a tabela ClienteVo.... ---- implementar ----
                    // alterar para a coluna PedidoVo puxar a tabela PedidoVo.... ---- implementar ----

                    cmd.Parameters.AddWithValue("@Id", carrinho.Id);
                    cmd.Parameters.AddWithValue("@Quantidade", carrinho.Quantidade);

                    cmd.ExecuteNonQuery();
                }
            }
        }

        public List<CarrinhoDeComprasVo> GetAllIngrediente()
        {
            List<CarrinhoDeComprasVo> carrinhos = new List<CarrinhoDeComprasVo>();

            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand("SELECT * FROM Ingredientes", conn))
                {
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            carrinhos.Add(new CarrinhoDeComprasVo
                            {
                                Id = Convert.ToInt32(reader["Id"]),

                                /*
                                        public ClienteVo Cliente { get; set; }  --->>> adicionar tabela para puxar outros dados dessa tabelas
                                        public PedidoVo Pedido { get; set; }    --->>> adicionar tabela para puxar outros dados dessa tabelas
                                */


                                Quantidade = Convert.ToInt32(reader["Quantidade"])
                            });
                        }
                    }
                }
            }

            return carrinhos;
        }
    }
}
