/**
 * 
 * File: frmAdd.cs
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
    public partial class frmBookAdd : Form {
        // Create needed class variables
        private frmBooks booksForm;

        /**
         * 
         * This method is used to initialize the form
         * 
         * @param frmBooks: is the form that holds needed objects
         * 
         **/
        public frmBookAdd(frmBooks booksForm) {
            // Initialize the Form
            InitializeComponent();

            // Set the class variable
            this.booksForm = booksForm;
        }

        /**
         * 
         * This methos is used to initialize items of the form on load
         * 
         **/
        private void frmAdd_Load(object sender, EventArgs e) {
            // Dynamically set the form title
            Text = "Add Book | " + Properties.Settings.Default.ApplicationName;

            // Call the form to set the Id textbox with the next Id
            setId();
        }

        /**
         * 
         * This method is sued for when a user desides to cancel/close the form
         * 
         **/
        private void btnCancel_Click(object sender, EventArgs e) {
            // Close the Form
            Close();
        }

        /**
         * 
         * This method is used for handling the addition of a new book the the "club" haha
         * 
         **/
        private void btnAdd_Click(object sender, EventArgs e) {
            // Check if validation passed
            if (checkValidInput()) {
                // Check if the book has been added
                if(addBook()) {
                    // Close the add form
                    Close();
                }
            }
        }

        /**
         * 
         * This method is sued to handle adding another book to the table
         * 
         **/
        private void btnAddAnother_Click(object sender, EventArgs e) {
            // Check if validation passed
            if (checkValidInput()) {
                // Check if the book has been added
                if(addBook()) {
                    // Clear all textboxes
                    txtName.Text = "";
                    txtAuthor.Text = "";
                    dtpDate.Value = DateTime.Now.Date;
                    mtbISBN.Text = "";

                    // Call Method to reset ID
                    setId();

                    // Set the Focus on the Name field
                    txtName.Focus();
                }
            }
        }

        /**
         * 
         * This method is used to amke sure that all fields are filled out.
         * 
         * @return Boolean [true - Validation Pass | fail - Validation Fail]
         * 
         **/
        private Boolean checkValidInput() {
            // Check if the input values are empty
            if (string.IsNullOrWhiteSpace(txtName.Text) || string.IsNullOrWhiteSpace(txtAuthor.Text) || string.IsNullOrWhiteSpace(dtpDate.ToString()) || string.IsNullOrWhiteSpace(mtbISBN.Text)) {
                // Display error message
                MessageBox.Show("Oops.. Some values are not filled out.  All fields must be filled out before adding a new book.  Please fill out the fields and try again!", "Empty Input Values", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                // Return false on error
                return false;
            }

            // Check if the ISBN was filled out in full
            if (mtbISBN.Text.Length != 17) {
                // Display error message
                MessageBox.Show("Oops.. The ISBN number is not fully filled out.  Please enter all ISBN numbers and try again!", "ISBN Input Length", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                // Set focus onto the ISBN input
                mtbISBN.Focus();

                // Return false on error
                return false;
            }

            // Return true on validation success
            return true;
        }

        /**
         * 
         * This method is used to add a new book to the list & DB
         * 
         **/
        private Boolean addBook() {
            // Try and open a connection to the database
            using (SqlConnection conn = new SqlConnection(Properties.Settings.Default.MegaBooksDBConnectionString)) {
                // Open the connection to the database
                conn.Open();

                // Perform the insert of the book into the database
                using (SqlCommand command = new SqlCommand("INSERT INTO books (name, author, date, isbn) VALUES (@name, @author, @date, @isbn)", conn)) {
                    // Append the values to the insert query string
                    command.Parameters.AddWithValue("@name", txtName.Text);
                    command.Parameters.AddWithValue("@author", txtAuthor.Text);
                    command.Parameters.AddWithValue("@date", dtpDate.Value.ToShortDateString());
                    command.Parameters.AddWithValue("@isbn", mtbISBN.Text);

                    // Check to see if the insert worked
                    if (command.ExecuteNonQuery() > 0) {
                        // Set the Status strip to display that the book was added
                        booksForm.tsslStatusLabel.Text = "Book (" + txtName.Text + ") Added Successfully!";
                    } else {
                        // Set the Status strip to display that the book was not added
                        booksForm.tsslStatusLabel.Text = "Book (" + txtName.Text + ") Failed to Add...";

                        // Display an addition failure message
                        MessageBox.Show("Hmm... Adding the book failed.  Please try again.", "Book Addition Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);

                        // Cancel further method processing
                        return false;
                    }

                    // Refresh the DataGrid on the books form
                    booksForm.booksTableAdapter.Fill(booksForm.megaBooksDBDataSet.Books);
                    booksForm.dgvBooks.Refresh();
                    booksForm.dgvBooks.Parent.Refresh();

                    // Close the connection to the database
                    conn.Close();
                }
            }

            // Return true on addition success
            return true;
        }

        /**
         * 
         * This method is used to set the Id textbox of the addition form
         * 
         **/
        private void setId() {
            // Try and open a connection to the database
            using (SqlConnection conn = new SqlConnection(Properties.Settings.Default.MegaBooksDBConnectionString)) {
                // Open the connection to the database
                conn.Open();

                // Perform the retrival of the next id
                using (SqlCommand command = new SqlCommand("SELECT TOP(1) IDENT_CURRENT('Books') + IDENT_INCR('Books') AS 'nextId' FROM Books", conn)) {
                    // Try using the SqlDataReader to read the next id
                    using (SqlDataReader reader = command.ExecuteReader()) {
                        // Check to see if the data can be read
                        if (reader.Read()) {
                            // Set the id text are with the respective value
                            txtId.Text = reader["nextId"].ToString();
                        }
                    }

                    // Close the connection to the database
                    conn.Close();
                }
            }
        }
    }
}