using HamburgaoDoGeorjao.DAO.ValueObjects;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// montar tabela de pedidos

namespace HamburgaoDoGeorjao.DAO.Dao
{
    public class PedidoDao
    {
        private readonly string _connectionString;

        public PedidoDao(string connectionString)
        {
            _connectionString = connectionString;
        }

        public void AddHamburguer(PedidoVo pedido)
        {
            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                conn.Open();
                // Tirar o PedidoVo, ClienteVO e HamburguerVO apos ligar as tabelas e a lista

                using (SqlCommand cmd = new SqlCommand("INSERT INTO Pedidos (PedidoVo, Descricao, ClienteVo, HamburguersDaLista, DataSolicitacao, DataPreparacao, DataSaidaEntrega, DataFinalizacaoEntrega)" +
                    " VALUES (@PedidoVo, @Descricao, @ClienteVo, @Hamburguers da Lista, @DataSolicitacao, @DataPreparacao, @DataSaidaEntrega, @DataFinalizacaoEntrega)", conn))
                {

                    // alterar para a coluna PedidoVo puxar a tabela PedidoVo.... ---- implementar ----
                    // alterar para a coluna ClienteVo puxar a tabela ClienteVo.... ---- implementar ----
                    // alterar para a coluna Hamburguers da lista e puxar os dados.... ---- implementar ----
                    /*
                     *  public PedidoVo()
                        {
                            DataSolicitacao = DateTime.Now;               ???????????????????????????
                            Hamburguers = new List<HamburguerVo>();       ???????????????????????????
                        }
                        public string Descricao { get; set; }
                        public ClienteVo Cliente { get; set; }
                        public List<HamburguerVo> Hamburguers { get; set; }
                        public DateTime DataSolicitacao { get; set; }
                        public DateTime? DataPreparacao { get; set; }
                        public DateTime? DataSaidaEntrega { get; set; }
                        public DateTime? DataFinalizacaoEntrega { get; set; }
                     */

                    cmd.Parameters.AddWithValue("@Id", pedido.Id);
                    // alterar
                    cmd.Parameters.AddWithValue("@PedidoVo", pedido.PedidoVo);
                    cmd.Parameters.AddWithValue("@Descricao", pedido.Descricao);
                    // alterar
                    cmd.Parameters.AddWithValue("@ClienteVo", pedido.ClienteVo);
                    // alterar
                    cmd.Parameters.AddWithValue("@HamburguersDaLista", pedido.HamburguersDaLista);

                    cmd.Parameters.AddWithValue("@DataSolicitacao", pedido.DataSolicitacao);
                    cmd.Parameters.AddWithValue("@DataPreparacao", pedido.DataPreparacao);
                    cmd.Parameters.AddWithValue("@DataSaidaEntrega", pedido.DataSaidaEntrega);
                    cmd.Parameters.AddWithValue("@DataFinalizacaoEntrega", pedido.DataFinalizacaoEntrega);

                    cmd.ExecuteNonQuery();
                }
            }
        }

        public List<PedidoVo> GetAllHamburguer()
        {
            List<PedidoVo> pedidos = new List<PedidoVo>();

            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand("SELECT * FROM Pedidos", conn))
                {
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            pedidos.Add(new PedidoVo
                            {
                                Id = Convert.ToInt32(reader["Id"]),

                                /*
                                    public IngredientesVo Ingredientes { get; set; } --->>> adicionar tabela para puxar outros dados dessa tabelas
                                */
                                PedidoVo = PedidoVo,
                                Descricao = reader["Descricao"].ToString(),
                                ClienteVo = ClienteVo,
                                HamburguersDaLista = List<HamburguerVo>,
                                DataSolicitacao = Convert.ToDateTime(reader["DataSolicitacao"]),
                                DataPreparacao = Convert.ToDateTime(reader["DataPreparacao"]),
                                DataSaidaEntrega = Convert.ToDateTime(reader["DataSaidaEntrega"]),
                                DataFinalizacaoEntrega = Convert.ToDateTime(reader["DataFinalizacaoEntrega"]),
                            });
                        }
                    }
                }
            }

            return pedidos;
        }
    }
}