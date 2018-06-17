/**
 * 
 * File: Review.cs
 * Date: June 17, 2018
 * Name: James Grau
 * Student Id: 991443203
 * 
 **/

// Include needed packages
using System;

// Declare Namespace 
namespace Grau_James_991443203_Assignment_2 {
    // Class to handle Book Object
    public class Review {
        // Create public object items with their respective getter methods
        public int id { get; }
        public string reviewer { get; }
        public string review { get;  }
        public DateTime date { get; }
        public int rating { get; }
        public Book book { get; }

        /**
         * 
         * This method is used to create a Review instance
         * 
         * @param id: is the review id
         * @param reviewer: is the name of the reviewer
         * @param review: is the book review
         * @param date: is the published data of the book
         * @param rating: is the rating of the book
         * @param book: is the book being reviewed
         * 
         **/
        public Review(int id, string reviewer, string review, DateTime date, int rating, Book book) {
            // Set the class variables
            this.id = id;
            this.reviewer = reviewer;
            this.review = review;
            this.date = date;
            this.rating = rating;
            this.book = book;
        }
    }
}
