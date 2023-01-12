using System.Net.Mail;
using System.Reflection;
using System.Runtime.InteropServices.JavaScript;
using EntityFrameworkSQL.BLL.Models;
using EntityFrameworkSQL.DAL.Repositories;
using EntityFrameworkSQL.PLL;
using EntityFrameworkSQL.PLL.Views;
using EntityFrameworkSQL.PLL.ViewsBooks;
using EntityFrameworkSQL.PLL.ViewsUser;
using EntityFrameworkSQL.PLL.ViewsUsers;

namespace EntityFrameworkSQL
{
    internal class Program
    {
        public static MainView? MainView;
        public static UserView? UserView;
        public static BookView? BookView;
        public static AddUserView? AddUser;
        public static RemoveUserView? RemoveUser;
        public static SelectUserView? SelectUser;
        public static UpdateUserByIdView? UpdateUserById;
        public static SelectAllUsersView? SelectAllUsers;
        public static AddBookView? AddBook;
        public static RemoveBookView? RemoveBook;
        public static SelectBookView? SelectBook;
        public static SelectAllBooksView? SelectAllBooks;
        public static UpdateBookByIdView? UpdateBookById;
        public static PickUpBookView? PickUpBookView;
        public static NextPageView? NextPageView;
        public static SelectBookGenreAndDateView? SelectBookGenreAndDate;
        public static CountBooksAuthorView? CountBooksAuthor;
        public static CountBooksGenreView? CountBooksGenre;
        public static GetBookTitleAndAuthorView? GetBookTitleAndAuthor;
        public static GetBookInUserView? GetBookInUser;
        public static CountBookInUserView? CountBookInUser;
        public static GetLastBookView? GetLastBook;
        public static GetAllBooksSortTitleView? GetAllBooksSortTitle;
        public static GetAllBooksSortDateDescView? GetAllBooksSortDateDesc;


        static void Main(string[] args)
        {
            SelectBookGenreAndDate = new SelectBookGenreAndDateView();
            CountBooksAuthor = new CountBooksAuthorView();
            CountBooksGenre = new CountBooksGenreView();
            GetBookTitleAndAuthor = new GetBookTitleAndAuthorView();
            GetBookInUser = new GetBookInUserView();
            CountBookInUser = new CountBookInUserView();
            GetLastBook = new GetLastBookView();
            GetAllBooksSortTitle = new GetAllBooksSortTitleView();
            GetAllBooksSortDateDesc = new GetAllBooksSortDateDescView();
            MainView = new MainView();
            UserView = new UserView();
            BookView = new BookView();
            AddUser = new AddUserView();
            RemoveUser = new RemoveUserView();
            SelectUser = new SelectUserView();
            UpdateUserById = new UpdateUserByIdView();
            SelectAllUsers = new SelectAllUsersView();
            AddBook = new AddBookView();
            RemoveBook = new RemoveBookView();
            SelectBook = new SelectBookView();
            SelectAllBooks = new SelectAllBooksView();
            UpdateBookById = new UpdateBookByIdView();
            PickUpBookView = new PickUpBookView();
            NextPageView = new NextPageView();

            MainView.Show();
        }
    }
}