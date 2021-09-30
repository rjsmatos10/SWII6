//Leandro Pereira dos Santos CB3005372
//Renan Josué Silva de Matos CB3007162

using System;
using System.Collections.Generic;
using System.Text;

namespace Trab01
{
    class FakeBookRepository : IRepositoryBook
    {
        private BookList _ToRead;

        private BookList _Reading;

        private BookList _Read;


        public FakeBookRepository()
        {
            FakeAuthorRepository autFake = new FakeAuthorRepository();
            Author[] aupl1 = new Author[2];
            Author[] aupl2 = new Author[1];
            Author[] aule1 = new Author[1];
            Author[] aule2 = new Author[1];
            Author[] auli1 = new Author[2];
            Author[] auli2 = new Author[1];

            aupl1[0] = autFake.authors[0];
            aupl1[1] = autFake.authors[1];
            aupl2[0] = autFake.authors[2];
            aule1[0] = autFake.authors[3];
            aule2[0] = autFake.authors[1];
            auli1[0] = autFake.authors[0];
            auli1[1] = autFake.authors[2];
            auli2[0] = autFake.authors[3];


            var l1 = new Book("newbook1", aupl1, 35.15, 115);
            var l2 = new Book("newbook2", aupl2, 95.12, 4);
            var l3 = new Book("newbook1", aule1, 39.99, 57);
            var l4 = new Book("newbook2", aule2, 64.50, 63);
            var l5 = new Book("newbook1", auli1, 100.00, 24);
            var l6 = new Book("newbook2", auli2, 33.00, 5);

            _ToRead = new BookList("Para Ler", l1, l2);
            _Reading = new BookList("Lendo", l3, l4);
            _Read = new BookList("Lidos", l5, l6);

        }

        public BookList ToRead => _ToRead;
        public BookList Reading => _Reading;
        public BookList Read => _Read;

        public IEnumerable<Book> All => throw new System.NotImplementedException();

        public void Add(Book book)
        {
            throw new System.NotImplementedException();
        }

    }
}
