/**
 * 
 * File: Book.cs
 * Date: June 16, 2018
 * Name: James Grau
 * Student Id: 991443203
 * 
 **/

// Include needed packages
using System;

// Declare Namespace 
namespace Grau_James_991443203_Assignment_2 {
    // Class to handle Book Object
    public class Book {
        // Create public object items with their respective getter methods
        public int id { get; }
        public string name { get; }
        public string author { get; }
        public DateTime date { get; }
        public string isbn { get; }

        /**
         * 
         * This method is used to create a Book instance
         * 
         * @param id: is the book id
         * @param name: is the name fo the book
         * @param author: is the author of the book
         * @param date: is the publis data of the book
         * @param isbn: is the books ISBN number
         * 
         **/
        public Book(int id, string name, string author, DateTime date, string isbn) {
            // Set the class variables
            this.id = id;
            this.name = name;
            this.author = author;
            this.date = date;
            this.isbn = isbn;
        }
    }
}
