using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;
using EntityFrameworkSQL.BLL;
using EntityFrameworkSQL.BLL.Models;
using EntityFrameworkSQL.DAL.Repositories;

namespace EntityFrameworkSQL.PLL.Views
{
    internal class SelectAllUsersView
    {
        public UserRepository UserRepository;

        public void Show()
        {
            UserRepository = new UserRepository();

            Console.Clear();

            var users = UserRepository.SelectAllUser();

            ShowConsoleUsers.Show(users);

            Console.WriteLine();
        }
    }
}