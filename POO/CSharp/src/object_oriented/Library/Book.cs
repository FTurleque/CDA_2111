using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    class Book
    {
        string title;
        string autorFirstName;
        string autorLastName;
        string publisher;
        int numberOfBook;

        public Book(string _title, string _autorFirstName, string _autorLastName, string _publisher, int _numberOfBook)
        {
            title = _title;
            autorFirstName = _autorFirstName;
            autorLastName = _autorLastName;
            publisher = _publisher;
            numberOfBook = _numberOfBook;
        }
    }
}
