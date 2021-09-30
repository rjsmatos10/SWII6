//Leandro Pereira dos Santos CB3005372
//Renan Josué Silva de Matos CB3007162

using System;
using System.Collections.Generic;
using System.Text;

namespace Trab01
{
    interface IRepositoryBook
    {
        BookList ToRead { get; }

        BookList Reading { get; }

        BookList Read { get; }

        IEnumerable<Book> All { get; }

        void Add(Book book);
    }
}
