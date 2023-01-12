using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityFrameworkSQL.BLL.Models;
using EntityFrameworkSQL.DAL.Repositories;
using EntityFrameworkSQL.PLL.Helpers;

namespace EntityFrameworkSQL.PLL.Views
{
    internal class AddUserView
    {
        public UserRepository userRepository;


        public void Show()
        {
            userRepository = new UserRepository();

            Console.WriteLine("Введите имя пользователя");
            var name = Console.ReadLine();

            Console.WriteLine("Введите почту, если имеется");
            var email = Console.ReadLine();

            if (name != "")
            {
                userRepository.AddUser(name, email);

                Console.WriteLine($"Пользователь {name} добавлен");
                Console.WriteLine();
            }
            else
            {
                AlertMessage.Show("Имя не может быть пустым");
                Console.WriteLine();
            }
        }
    }
}