using HamburgaoDoGeorjao.DAO.Dao;
using HamburgaoDoGeorjao.DAO.Regras;
using HamburgaoDoGeorjao.DAO.ValueObjects;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



/*        public int Id { get; set; }
        public string? Title { get; set; }
        [DataType(DataType.Date)]
        public DateTime ReleaseDate { get; set; }
        public string? Genre { get; set; }
        public decimal Price { get; set; }
*/

namespace HamburgaoDoGeorjao.DAO.Dao
{
    public class ClienteDao : BaseDao<ClienteVo>, IClienteDao
    {
        private const string TABELA_Cliente_NOME = "TB_Movie";

        private const string TABELA_Cliente = @$"CREATE TABLE IF NOT EXISTS {TABELA_Cliente_NOME}
                (
                    ID INTEGER PRIMARY KEY AUTOINCREMENT,
                    Title VARCHAR(50) not null
                    UserId VARCHAR(50) not null
                )";

        private const string INSERIR_Cliente = @$"
                INSERT INTO {TABELA_Cliente_NOME} (Nome,UserId)
                VALUES (@Nome,@UserId)";

        private const string UPDATE_Cliente = @$"
    UPDATE {TABELA_Cliente_NOME}
    SET
        Nome = @Nome,
        UserId = @UserId
    WHERE
        ID = @Id";

        private const string DELETE_Cliente = $@"
    DELETE FROM {TABELA_Cliente_NOME} 
    WHERE ID = @ID";

        private const string SELECT_Cliente = @$"SELECT * FROM {TABELA_Cliente_NOME}";

        private const string SELECT_Cliente_By_ID = @$"SELECT * FROM {TABELA_Cliente_NOME} WHERE ID = @ID";

        public ClienteDao(IOptions<ConnectionStrings> connectionStringOptions) : base(
            TABELA_Cliente,
            SELECT_Cliente,
            INSERIR_Cliente,
            TABELA_Cliente_NOME,
            UPDATE_Cliente,
            DELETE_Cliente,
            SELECT_Cliente_By_ID,
            connectionStringOptions)
        { }

        protected override ClienteVo CriarInstancia(SqliteDataReader sqliteDataReader)
        {
            return new ClienteVo
            {
                Id = Convert.ToInt32(sqliteDataReader["Id"]),
                Nome = sqliteDataReader["Nome"].ToString()
            };
        }
    }
}