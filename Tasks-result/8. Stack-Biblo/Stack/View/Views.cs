using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stack.View
{
    internal class Views
    {

        public byte FirstOption()
        {
            byte firstoption = byte.Parse(Console.ReadLine());

            return firstoption;
        } 

        public void StartView(ushort totalBooks)
        {
            Console.Title = "Loan books and pay now";
            Console.WriteLine($"Hello and welcome to our Library here you can loan up to {totalBooks} book at a time\n" +
                $"\n1. See all the books" +
                $"\n2. Loan a book" +
                $"\n3. Show a loaned book" +
                $"\n4. Pay automatically" +
                $"\n5. Exit");
        }

        public void ShowStack(string title, string author, string language, short totalPages, short price, string releaseDate)
        {
            Console.Title = "Shows all the loaned books";
            Console.WriteLine($"> {title}\n{author}\n{language}\n{totalPages}\n${price}\n{releaseDate}\n");
        }

        public void EmptyStack()
        {
            Console.WriteLine("The stack is empty");
        }

        public void NoSuchBook()
        {
            Console.WriteLine("There is no such book in our library");
        }

        public string LoanMessage()
        {
            Console.Title = "Loan a book";
            Console.Write("What books do you want loan? (Please write the name of the book - Max 4): ");

            string secondoption = Console.ReadLine();

            return secondoption;
        }

        public void LoanedBook(string bookName)
        {
            Console.Write($"You have loaned: {bookName}");
        }

        public void AllBooks(string title, string author, string language, short totalPages, short price, string releaseDate)
        {
            Console.Title = "Shows all the books";
            Console.WriteLine($"> {title}\n{author}\n{language}\n{totalPages}\n${price}\n{releaseDate}\n");
        }

        public void SuccessLoan(string bookName)
        {
            Console.Write($"You just loan: {bookName}");
        }

        public void ErrorLoan(string bookName)
        {
            Console.Write($"You can't loan this book: {bookName}");
        }

        public void PayBook(string title)
        {
            Console.Write($"You have paid for book: {title}");
        }

        public void ClearConsole()
        {
            Console.Clear();
        }

        public void ConsoleReadKey()
        {
            Console.ReadKey();
        }
    }
}
