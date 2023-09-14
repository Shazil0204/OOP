using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stack.Controller
{
    internal class Controller
    {
        View.Views view = new View.Views();
     
        Model.Book cBook = new Model.Book();


        #region Main Controller
        public void MainController()
        {
            Combiner();
        }
        #endregion

        #region Combiner
        void Combiner()
        {
            InsertData();
            
            while (true)
            {
                Options();
                view.ConsoleReadKey();
                view.ClearConsole();
            }
        }
        #endregion

        #region Insert Data
        void InsertData()
        {
            Model.Book book1 = new Model.Book
            {
                TotalPages = 300,
                Price = 25,
                Title = "Simple Book",
                Author = "John Doe",
                Language = "English",
                ReleaseDate = "01-01-2023"

            };

            Model.Book book2 = new Model.Book
            {
                TotalPages = 450,
                Price = 30,
                Title = "Another Book",
                Author = "Jane Smith",
                Language = "France",
                ReleaseDate = "25-08-2023"
            };

            Model.Book book3 = new Model.Book
            {
                TotalPages = 50,
                Price = 10000,
                Title = "Shazil's Book",
                Author = "Shazil Shahid Qayyum Abdul Aziz Muhammad Ali",
                Language = "Urdu",
                ReleaseDate = "23-01-2004"
            };

            Model.Book book4 = new Model.Book
            {
                TotalPages = 600,
                Price = 9999,
                Title = "Jonas' Book",
                Author = "Jonas Kristian Anders Torben",
                Language = "Deutch",
                ReleaseDate = "01-09-1939"
            };

            cBook.books.Add(book1);
            cBook.books.Add(book2);
            cBook.books.Add(book3);
            cBook.books.Add(book4);
        }
        #endregion

        #region Options

        void Options()
        {
            ushort totalBooks = ushort.Parse(cBook.books.Count().ToString());

            view.StartView(totalBooks);

            byte input1 = view.FirstOption();

            //ushort input2 = view.SecondOption();

            switch (input1)
            {
                case 1:
                    view.ClearConsole();
                    // This will show all the books
                    ShowAllBooks();
                    break;

                case 2:
                    view.ClearConsole();
                    // This will let user choose books
                    UserChoice();
                    break;

                case 3:
                    view.ClearConsole();
                    // This will show user all the book he has choosen
                    ShowLoanBooks();
                    break;

                case 4:
                    PayAutomatically();
                    break;

                case 5:
                    // exit program
                    Environment.Exit(0);
                    break;

                default:
                    // default output!
                    break;
            }
        }

        void ShowAllBooks()
        {
            foreach (Model.Book book in cBook.books)
            {
                view.AllBooks(book.Title, book.Author, book.Language, book.TotalPages, book.Price, book.ReleaseDate);
            }
        }

        void UserChoice()
        {
            string userChoice = view.LoanMessage();

            bool result =false;

            // Use a for loop to iterate through the list in reverse order
            for (int i = cBook.books.Count - 1; i >= 0; i--)
            {
                if (cBook.books[i].Title == userChoice)
                {
                    Model.Book removedBook = cBook.books[i];
                    cBook.books.RemoveAt(i);

                    // Push the removed book onto the stack
                    cBook.loanBook.Push(removedBook);

                    result = true;

                    break; // Remove only the first matching book and exit the loop
                }
            }

            if (!result)
            {
                view.NoSuchBook();
            }
        }

        void ShowLoanBooks()
        {
            if (cBook.loanBook.Count > 0)
            {
                Model.Book topBook = cBook.loanBook.Peek();

                view.LoanedBook(topBook.Title);
            }
            else
            {
                view.EmptyStack();
            }
        }

        void PayAutomatically()
        {
            if (cBook.loanBook.Count > 0)
            {
                Model.Book poppedBook = cBook.loanBook.Pop();

                view.PayBook(poppedBook.Title);
            }
            else
            {
                view.EmptyStack();
            }

        }

        #endregion
    }
}
