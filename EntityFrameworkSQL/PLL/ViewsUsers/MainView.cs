using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityFrameworkSQL.PLL.ViewsUsers;

namespace EntityFrameworkSQL.PLL.ViewsUsers
{
    public class MainView
    {
        private UserView userView;

        public void Show()
        {
            userView = new UserView();
            Console.Clear();
            Console.WriteLine("Пользователи введите 1");
            Console.WriteLine("Книги введите        2");

            switch (Console.ReadLine())
            {
                case "1":
                {
                    Program.UserView?.Show();
                    break;
                }

                case "2":
                {
                    Program.BookView?.Show();
                    break;
                }
            }
        }
    }
}