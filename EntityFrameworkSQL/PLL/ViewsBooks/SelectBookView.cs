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
    internal class SelectBookView
    {
        private BookRepository bookRepository;

        public void Show()
        {
            Console.Clear();
            bookRepository = new BookRepository();

            Console.WriteLine("Показать книгу, введите ее Id");
            var id = Convert.ToInt32(Console.ReadLine());

            try
            {
                var books = bookRepository.SelectBookById(id);

                Console.WriteLine("Пользователи, бравшие книгу: ");
                Console.WriteLine();
            }

            catch (NullIdException)
            {
                AlertMessage.Show($"Книга с  Id: {id} не найдена");
                Console.WriteLine();
            }

            Console.WriteLine();
        }
    }
}