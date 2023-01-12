using EntityFrameworkSQL.DAL.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityFrameworkSQL.BLL.Exception;
using EntityFrameworkSQL.PLL.Helpers;

namespace EntityFrameworkSQL.PLL.ViewsUser
{
    public class UpdateUserByIdView
    {
        public UserRepository userRepository;

        public void Show()
        {
            Console.Clear();

            try
            {
                userRepository = new UserRepository();
                Console.WriteLine("Для обновления пользователя введите его Id");
                var id = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Введите новое имя");
                var name = Console.ReadLine();

                Console.WriteLine("Введите новую почту,если имеется");
                var email = Console.ReadLine();

                userRepository.UpdateUserById(id, name);

                if (id == 0) return;

                Console.WriteLine($"Пользователь изменен");
                Console.WriteLine();
            }
            catch (NullIdException)
            {
                AlertMessage.Show($"Пользователь НЕ изменен, т.к. Id не найден");
                Console.WriteLine();
            }
        }
    }
}