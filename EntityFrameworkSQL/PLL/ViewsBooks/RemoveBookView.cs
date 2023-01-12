using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityFrameworkSQL.BLL.Exception;
using EntityFrameworkSQL.BLL.Models;
using EntityFrameworkSQL.DAL.Repositories;
using EntityFrameworkSQL.PLL.Helpers;

namespace EntityFrameworkSQL.PLL.ViewsBooks
{
    public class RemoveBookView
    {
        public BookRepository BookRepository;


        public void Show()
        {
            Console.Clear();

            try
            {
                BookRepository = new BookRepository();

                Console.WriteLine("Введите Id книги");
                var id = Convert.ToInt32(Console.ReadLine());

                BookRepository.RemoveBookById(id);

                if (id == 0) return;

                Console.WriteLine($"Книга с ID: {id} удалена");
                Console.WriteLine();
            }
            catch (NullIdException)
            {
                AlertMessage.Show("Книга не удалена, т.к. Id не найден");
                Console.WriteLine();
            }
        }
    }
}