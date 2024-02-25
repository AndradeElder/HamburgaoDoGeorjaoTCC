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
    public class MovieDao
    {
        private readonly string _connectionString;

        public MovieDao(string connectionString)
        {
            _connectionString = connectionString;
        }

        public void AddMovie(MovieVo movie)
        {
            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand("INSERT INTO Movie (Title, ReleaseDate, Genre, Price) VALUES (@Title, @ReleaseDate, @Genre, @Price)", conn))
                {
                    cmd.Parameters.AddWithValue("@Id", movie.Id);
                    cmd.Parameters.AddWithValue("@Title", movie.Title);
                    cmd.Parameters.AddWithValue("@ReleaseDate", movie.ReleaseDate);
                    cmd.Parameters.AddWithValue("@Genre", movie.Genre);
                    cmd.Parameters.AddWithValue("@Price", movie.Price);

                    cmd.ExecuteNonQuery();
                }
            }
        }

        public List<MovieVo> GetAllMovies()
        {
            List<MovieVo> movies = new List<MovieVo>();

            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand("SELECT * FROM Movie", conn))
                {
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            movies.Add(new MovieVo
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
