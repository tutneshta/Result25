using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityFrameworkSQL.BLL.Models;
using EntityFrameworkSQL.DAL.Repositories;
using Microsoft.Identity.Client;

namespace EntityFrameworkSQL.PLL.ViewsBooks
{
    public class BookView
    {
        public void Show()
        {
            Console.Clear();

            while (true)
            {
                Console.WriteLine("Добавить книгу нажмите           1");
                Console.WriteLine("Удалить книгу по ее Id нажмите   2");
                Console.WriteLine("Выбрать книгу по ее Id нажмите   3");
                Console.WriteLine("Изменить книгу по ее Id нажмите  4");
                Console.WriteLine("Показать все книги нажмите       5");
                Console.WriteLine();
                Console.WriteLine("На следующую страницу нажмите    6");
                Console.WriteLine("Вернуться в главное меню нажмите 7");


                var keyValue = Console.ReadLine();

                switch (keyValue)
                {
                    case "1":
                    {
                        Program.AddBook?.Show();
                        break;
                    }
                    case "2":
                    {
                        Program.RemoveBook?.Show();
                        break;
                    }
                    case "3":
                    {
                        Program.SelectBook?.Show();
                        break;
                    }
                    case "4":
                    {
                        Program.UpdateBookById?.Show();
                        break;
                    }
                    case "5":
                    {
                        Program.SelectAllBooks?.Show();
                        break;
                    }
                    case "6":
                    {
                        Program.NextPageView?.Show();
                        break;
                    }
                    case "7":
                    {
                        Program.MainView?.Show();
                        break;
                    }
                }
            }
        }
    }
}