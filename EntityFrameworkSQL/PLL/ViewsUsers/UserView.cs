using EntityFrameworkSQL.BLL.Models;
using EntityFrameworkSQL.DAL.Repositories;

namespace EntityFrameworkSQL.PLL.ViewsUsers
{
    public class UserView
    {
        public void Show()
        {
            while (true)
            {
                Console.WriteLine("Добавить пользователя нажмите           1");
                Console.WriteLine("Удалить пользователя по его Id нажмите  2");
                Console.WriteLine("Выбрать пользователя по его Id нажмите  3");
                Console.WriteLine("Изменить пользователя по его Id нажмите 4");
                Console.WriteLine("Показать всех пользователей нажмите     5");
                Console.WriteLine();
                Console.WriteLine("Вернуться назад нажмите                 6");

                var keyValue = Console.ReadLine();

                switch (keyValue)
                {
                    case "1":
                    {
                        Program.AddUser?.Show();
                        break;
                    }
                    case "2":
                    {
                        Program.RemoveUser?.Show();
                        break;
                    }
                    case "3":
                    {
                        Program.SelectUser?.Show();
                        break;
                    }
                    case "4":
                    {
                        Program.UpdateUserById?.Show();
                        break;
                    }
                    case "5":
                    {
                        Program.SelectAllUsers?.Show();
                        break;
                    }
                    case "6":
                    {
                        Program.MainView?.Show();
                        break;
                    }
                }
            }
        }
    }
}