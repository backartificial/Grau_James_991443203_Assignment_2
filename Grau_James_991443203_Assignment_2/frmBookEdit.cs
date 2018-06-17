/**
 * 
 * File: frmEdit.cs
 * Date: June 16, 2018
 * Name: James Grau
 * Student Id: 991443203
 * 
 **/

// Include needed packages
using System;
using System.Data.SqlClient;
using System.Windows.Forms;

// Declare Namespace 
namespace Grau_James_991443203_Assignment_2 {
    // Class to handle frmEdit
    public partial class frmBookEdit : Form {
        // Create needed class variables
        private Book editBook;
        private frmBooks booksForm;

        /**
         * 
         * This method is used to initialize the edit book form
         * 
         * @param editBook: is the book that is to be edited
         * @param booksFrom: is the books form that hold some needed objects for data handling
         * 
         **/
        public frmBookEdit(Book editBook, frmBooks booksForm) {
            // Initialize the form
            InitializeComponent();

            // Set the class variables
            this.editBook = editBook;
            this.booksForm = booksForm;
        }

        /**
         * 
         * This method is used to handle initializing the form when loading
         * 
         **/
        private void frmEdit_Load(object sender, EventArgs e) {
            // Dynamically set the form title
            Text = "Editing Book (" + editBook.name + ") | " + Properties.Settings.Default.ApplicationName;

            // Set the values of the textfields to the book being edited values
            txtId.Text = editBook.id.ToString();
            txtName.Text = editBook.name;
            txtAuthor.Text = editBook.author;
            dtpDate.Value = DateTime.Parse(editBook.date.ToString()).Date;
            mtbISBN.Text = editBook.isbn;
        }

        /**
         * 
         * This method is used to handel when the user click close to cancel editing
         * 
         **/
        private void btnCancel_Click(object sender, EventArgs e) {
            // Close the form
            Close();
        }

        /**
         * 
         * This method is used to save the edited book info
         * 
         **/
        private void btnUpdate_Click(object sender, EventArgs e) {
            // Check for valid input
            if(checkValidInput()) {
                // Try and open a connection to the database
                using (SqlConnection conn = new SqlConnection(Properties.Settings.Default.MegaBooksDBConnectionString)) {
                    // Open the connection to the database
                    conn.Open();

                    // Perform the update of the book into the database
                    using (SqlCommand command = new SqlCommand("UPDATE books SET name = @name, author = @author, date = @date, isbn = @isbn WHERE id = @id", conn)) {
                        // Append the values to be updated to the query string
                        command.Parameters.AddWithValue("@name", txtName.Text);
                        command.Parameters.AddWithValue("@author", txtAuthor.Text);
                        command.Parameters.AddWithValue("@date", dtpDate.Value.ToShortDateString());
                        command.Parameters.AddWithValue("@isbn", mtbISBN.Text);
                        command.Parameters.AddWithValue("@id", editBook.id);

                        // Check to see if the update worked
                        if (command.ExecuteNonQuery() > 0) {
                            // Set the Status strip to display that the book was updated
                            booksForm.tsslStatusLabel.Text = "Book (" + txtName.Text + ") Updated Successfully!";
                        } else {
                            // Set the Status strip to display that the book was not updated
                            booksForm.tsslStatusLabel.Text = "Book (" + txtName.Text + ") Failed to Update...";

                            // Display an update failure message
                            MessageBox.Show("Hmm... Updating the book failed.  Please try again.", "Book Update Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);

                            // Cancel further method processing
                            return;
                        }

                        // Refresh the DataGrid on the books form
                        booksForm.booksTableAdapter.Fill(booksForm.megaBooksDBDataSet.Books);
                        booksForm.dgvBooks.Refresh();
                        booksForm.dgvBooks.Parent.Refresh();

                        // Close the connection to the database
                        conn.Close();

                        // Close the edit form
                        Close();
                    }
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
    }
}
