/*//Leandro Pereira dos Santos CB3005372
//Renan Josué Silva de Matos CB3007162

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace Trab01
{
    class BookRepositoryCSV// : IRepositoryBook
    {
        private static readonly string CSVArchiveName = ".\\livros.csv";

        private BookList _ToRead;

        private BookList _Reading;

        private BookList _Read;

        public BookRepositoryCSV()
        {
            var arrayToRead = new List<Book>();
            var arrayReading = new List<Book>();
            var arrayRead = new List<Book>();

            using (var file = File.OpenText(BookRepositoryCSV.CSVArchiveName))
            {
                while (!file.EndOfStream)
               {
                    var textoLivro = file.ReadLine();
                    if (string.IsNullOrEmpty(textoLivro))
                    {
                       continue;
                    }
                    var infoBook = textoLivro.Split(';');
                    var book = new Book
                    (
                        name = infoBook[1],
                        authors = infoBook[2],
                        price = Convert.ToDouble(infoBook[3]),
                        qty = Convert.ToInt32(infoBook[4])

                    );

                   switch (infoBook[0])
                    {
                        case "para-ler":
                            arrayToRead.Add(book);
                            break;
                        case "lendo":
                            arrayReading.Add(book);
                            break;
                        case "lidos":
                            arrayRead.Add(book);
                            break;
                    }
                }
            }

            _ToRead = new BookList("Para ler", arrayToRead.ToArray());
            _Reading = new BookList("lendo", arrayToRead.ToArray());
            _Read = new BookList("lidos", arrayToRead.ToArray());
        }

        public BookList ToRead => _ToRead;
        public BookList Reading => _Reading;
        public BookList Read => _Read;

        public IEnumerable<Book> All => _ToRead.Books.Union(_Reading.Books).Union(_Read.Books);

        public void Add(Book book)
        {
            var id = All.Select(b => b.name).Max();
            using (var file = File.AppendText(BookRepositoryCSV.CSVArchiveName))
            {
                file.WriteLine($"para-ler;{book.name};{book.authors};{book.price};{book.qty};");
            }
        }

    }
}
*/