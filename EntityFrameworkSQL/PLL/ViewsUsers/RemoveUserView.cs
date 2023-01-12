using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityFrameworkSQL.BLL.Exception;
using EntityFrameworkSQL.BLL.Models;
using EntityFrameworkSQL.DAL.Repositories;
using EntityFrameworkSQL.PLL.Helpers;

namespace EntityFrameworkSQL.PLL.Views
{
    public class RemoveUserView
    {
        public UserRepository userRepository;
        //public User User;

        public void Show()
        {
            try
            {
                userRepository = new UserRepository();

                Console.WriteLine("Введите Id пользователя");
                var id = Convert.ToInt32(Console.ReadLine());

                userRepository.RemoveUserById(id);

                if (id == 0) return;

                Console.WriteLine($"Пользователь с ID: {id} удален");
                Console.WriteLine();
            }
            catch (NullIdException)
            {
                AlertMessage.Show("Пользователь не удален, т.к. Id не найден");
                Console.WriteLine();
            }
        }
    }
}