//Leandro Pereira dos Santos CB3005372
//Renan Josué Silva de Matos CB3007162
using System;
using System.Collections.Generic;
using System.Text;
namespace Trab01
{
    class Author
    {
        public string name { get; set; }
        public string email { get; set; }
        public char gender { get; set; }

        public Author(string n, string e, char g)
        {
            name = n;
            email = e;
            gender = g;

        }
        public Author()
        {
            name = "nomeTeste";
            email = "EmailTeste";
            gender = 'T';

        }
    }
}
