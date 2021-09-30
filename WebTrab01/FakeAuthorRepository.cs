//Leandro Pereira dos Santos CB3005372
//Renan Josué Silva de Matos CB3007162

using System;
using System.Collections.Generic;
using System.Text;

namespace WebTrab01
{
    class FakeAuthorRepository
    {
        public Author[] authors = new Author[4];

        public FakeAuthorRepository()
        {
            authors[0] = new Author("Pedro Jose", "pedroca@gmail.com", 'M');
            authors[1] = new Author("Fernanda Paula", "paulafer@hotmail.com", 'F');
            authors[2] = new Author("Roberto Pinheiro", "robertin@outlook.com", 'M');
            authors[3] = new Author("Ana Clara Lima", "limaoclarinha@gmail.com", 'F');
        }
    }
}
