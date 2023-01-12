using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;
using EntityFrameworkSQL.BLL.Models;

namespace EntityFrameworkSQL.BLL
{
    public class ShowConsoleBooks
    {
        public static void Show(List<Book> books)
        {
            Console.Clear();
            Console.WriteLine("{0,-3} {1,-20} {2,-20} {3,-20} {4,-20}", "id", "Название книги", "Дата", "Автор",
                "Жанр");

            Console.WriteLine();

            foreach (var book in books)
            {
                Console.WriteLine(
                    "{0,-3} {1,-20} {2,-20} {3,-20} {3,-20}", $"{book.Id}", $"{book.Title}",
                    $"{book.Date:d}", $"{book.Author}",
                    $"{book.Genre}");
            }

            Console.WriteLine();
        }
    }
}