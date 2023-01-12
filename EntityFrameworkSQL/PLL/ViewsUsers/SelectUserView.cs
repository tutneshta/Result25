using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;
using EntityFrameworkSQL.BLL.Exception;
using EntityFrameworkSQL.BLL.Models;
using EntityFrameworkSQL.DAL;
using EntityFrameworkSQL.DAL.Repositories;
using EntityFrameworkSQL.PLL.Helpers;
using AppContext = EntityFrameworkSQL.DAL.AppContext;

namespace EntityFrameworkSQL.PLL.Views
{
    public class SelectUserView
    {
        public static int IdUser;
        private UserRepository userRepository;
        public BookRepository bookRepository;

        public void Show()
        {
            userRepository = new UserRepository();
            bookRepository = new BookRepository();

            Console.WriteLine("Показать пользователя, введите его Id");
            var id = Convert.ToInt32(Console.ReadLine());


            try
            {
                var user = userRepository.SelectUserById(id);

                foreach (var variable in user)
                {
                    Console.WriteLine($"Id:\t{variable.Id}\nИмя:\t{variable.Name}\nПочта:\t{variable.Email}");
                }

                IdUser = id;
            }

            catch (NullIdException)
            {
                AlertMessage.Show($"Пользователь с Id {id} не найден");

                Console.WriteLine();
            }

            Console.WriteLine($"Количество книг у пользователя: {bookRepository.CountBookInUser(id)}\n");

            Console.WriteLine("Взять книгу нажмите 1");

            var keyValue = Console.ReadLine();

            switch (keyValue)
            {
                case "1":

                    Program.PickUpBookView?.Show();

                    break;
            }
        }
    }
}