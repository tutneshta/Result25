using EntityFrameworkSQL.DAL.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityFrameworkSQL.BLL;

namespace EntityFrameworkSQL.PLL.ViewsBooks
{
    internal class GetAllBooksSortTitleView
    {
        BookRepository bookRepository;


        public void Show()
        {
            Console.Clear();
            bookRepository = new BookRepository();

            ShowConsoleBooks.Show(bookRepository.GetAllBooksSortTitle());
            Console.WriteLine();
        }
    }
}