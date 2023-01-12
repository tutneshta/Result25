using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameworkSQL.BLL.Models
{
    public class Book
    {
        public int Id { get; set; }
        public string Title { get; set; }

        public DateTime Date { get; set; }
        public string? Author { get; set; }
        public string? Genre { get; set; }

        public ICollection<User> Users { get; set; }
    }
}