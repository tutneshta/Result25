using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityFrameworkSQL.BLL.Models;
using EntityFrameworkSQL.DAL.Repositories;
using EntityFrameworkSQL.PLL.Views;
using EntityFrameworkSQL.PLL.ViewsBooks;
using AppContext = EntityFrameworkSQL.DAL.AppContext;

namespace EntityFrameworkSQL.PLL.ViewsUsers
{
    public class PickUpBookView
    {
        public UserRepository userRepository;
        public BookRepository bookRepository;


        public void Show()
        {
            userRepository = new UserRepository();
            bookRepository = new BookRepository();

            Console.WriteLine("Введите  id книги, которую нужно выдать");
            int idBookPickUp = Convert.ToInt32(Console.ReadLine());

            var book = bookRepository.SelectBookById(idBookPickUp).FirstOrDefault();
            var user = userRepository.SelectUserById(SelectUserView.IdUser).FirstOrDefault();

            user.Books.Add(book);
            userRepository.Update(user);
        }
    }
}