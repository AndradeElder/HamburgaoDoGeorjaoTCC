using HamburgaoDoGeorjao.DAO.ValueObjects;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegraDeNegocios.Entidades
{
    internal class Movie
    {
        public int Id { get; set; }
        public string? Title { get; set; }
        [DataType(DataType.Date)]
        public DateTime ReleaseDate { get; set; }
        public string? Genre { get; set; }
        public decimal Price { get; set; }


        public MovieVo ToVo()
        {
            return new MovieVo { Id = Id, Title = Title, ReleaseDate = ReleaseDate, Genre = Genre, Price = Price };
        }
    }
}
