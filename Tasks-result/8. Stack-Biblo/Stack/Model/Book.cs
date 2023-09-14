using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stack.Model
{
    internal class Book
    {

        #region Variables
        private short totalPages;
        private short price;
        private string title;
        private string author;
        private string language;
        private string releaseDate;
        #endregion

        #region Properties
        public short TotalPages { get { return totalPages; } set { totalPages = value; } }

        public short Price { get { return price; } set { price = value; } }

        public string Title { get { return title; } set { title = value; } }

        public string Author { get { return author; } set { author = value; } }

        public string Language { get { return language; } set {  language = value; } }

        public string ReleaseDate { get { return releaseDate; } set {  releaseDate = value; } }
        #endregion

        #region List
        public List<Book> books = new List<Book>();
        #endregion

        #region Stack
        public Stack<Book> loanBook = new Stack<Book>();
        #endregion
    }
}
