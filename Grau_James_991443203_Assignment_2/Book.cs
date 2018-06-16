using System;

namespace Grau_James_991443203_Assignment_2 {
    class Book {
        public int id { get; }
        public string name { get; }
        public string author { get; }
        public DateTime date { get; }
        public string isbn { get; }

        public Book(int id, string name, string author, DateTime date, string isbn) {
            this.id = id;
            this.name = name;
            this.author = author;
            this.date = date;
            this.isbn = isbn;
        }        
    }
}
