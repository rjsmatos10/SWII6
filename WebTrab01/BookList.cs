//Leandro Pereira dos Santos CB3005372
//Renan Josué Silva de Matos CB3007162

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WebTrab01
{
    class BookList
    {
        private List<Book> _books;

        public string Title { get; set;}

        public BookList(string title, params Book[] books)
        {
            Title = title;
            _books = books.ToList();
            _books.ForEach(b => b.list = this);
        }

        public IEnumerable<Book> Books
        {
            get { return _books; }
        }

        public override string ToString()
        {
            var linhas = new StringBuilder();
            linhas.AppendLine(Title);
            linhas.AppendLine("====================");
            foreach (var book in Books)
            {
                linhas.AppendLine(book.ToString());
            }
            return linhas.ToString();
        }
    }
}
