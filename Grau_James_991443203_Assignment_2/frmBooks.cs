/**
 * 
 * File: frmBooks.cs
 * Date: June 16, 2018
 * Name: James Grau
 * Student Id: 991443203
 * 
 **/

// Include required packages
using System;
using System.Data.SqlClient;
using System.Windows.Forms;

// Declare class namespace
namespace Grau_James_991443203_Assignment_2 {
    // Declare the form class
    public partial class frmBooks : Form {
        /**
         * 
         * This method is used to initialize the form
         * 
         **/
        public frmBooks() {
            // Initialize the Form
            InitializeComponent();
        }

        /**
         * 
         * This methos is used to initialize items of the form on load
         * 
         **/
        private void frmBooks_Load(object sender, EventArgs e) {
            // Load megaBooksDatSet into the booksTableAdapter
            booksTableAdapter.Fill(megaBooksDBDataSet.Books);
        }     

        /**
         * 
         * This methos is used to handle when a user desires to delete a book from the database
         * 
         **/
        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e) {
            // Confirm that the user does want to delete the book record
            if(MessageBox.Show("Are you sure you want to delete the selected book?", "Delete Book Record?", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Exclamation) == DialogResult.Yes) {
                // Try connecting to the database
                using (SqlConnection conn = new SqlConnection(Properties.Settings.Default.MegaBooksDBConnectionString)) {
                    // Open the connection to the database
                    conn.Open();

                    // Try using a SqlCommand to delete the item from the database
                    using (SqlCommand command = new SqlCommand("DELETE FROM books WHERE id = @id", conn)) {
                        // Append the parameter to the query string and execute the query
                        command.Parameters.AddWithValue("@id", dgvBooks.CurrentRow.Cells[0].Value);
                        command.ExecuteNonQuery();

                        // Delete row from dataset
                        megaBooksDBDataSet.Books.Rows.RemoveAt(dgvBooks.CurrentCell.RowIndex);

                        // Close the connection to the database
                        conn.Close();
                    }
                }
            }
        }

        /**
         * 
         * This method is used when a user desires to edit a book record
         * 
         **/ 
        private void tsbEdit_Click(object sender, EventArgs e) {
            // Select the curret row and store it into a general variable
            var selectedBook = dgvBooks.CurrentRow;
            
            // Based on the selected row, create a new Book instance
            Book editBook = new Book(int.Parse(selectedBook.Cells[0].Value.ToString()), selectedBook.Cells[1].Value.ToString(), selectedBook.Cells[2].Value.ToString(), DateTime.Parse(selectedBook.Cells[3].Value.ToString()), selectedBook.Cells[4].Value.ToString());

            // Display the edit form and pass in the desires book to edit and this form
            new frmEdit(editBook, this).Show();
        }

        /**
         * 
         * This method is sued for when a user desires adding in a book
         * 
         **/
        private void bngAdd_Click(object sender, EventArgs e) {
            // Display the add form and pass in this form
            new frmAdd(this).Show();
        }
    }
}
