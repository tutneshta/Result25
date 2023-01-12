using EntityFrameworkSQL.DAL.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityFrameworkSQL.BLL.Exception;
using EntityFrameworkSQL.PLL.Helpers;

namespace EntityFrameworkSQL.PLL.ViewsBooks
{
    public class UpdateBookByIdView
    {
        public BookRepository bookRepository;

        public void Show()
        {
            Console.Clear();

            try
            {
                bookRepository = new BookRepository();
                Console.WriteLine("Для обновления книги введите ее Id");
                var id = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Введите дату");
                DateTime date = Convert.ToDateTime(Console.ReadLine());

                bookRepository.UpdateDateBookById(id, date);

                if (id == 0) return;
                Console.WriteLine($"Дата книги изменена");
                Console.WriteLine();
            }
            catch (NullIdException)
            {
                AlertMessage.Show($"Дата НЕ изменена, т.к. Id не найден");
                Console.WriteLine();
            }
        }
    }
}