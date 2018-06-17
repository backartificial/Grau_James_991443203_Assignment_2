/**
 * 
 * File: frmReviews.cs
 * Date: June 17, 2018
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
    // Class to handle frmReviews
    public partial class frmReviews : Form {

        /**
         * 
         * This method is used to initialize the reviews form
         * 
         **/
        public frmReviews() {
            // Initialize the Form
            InitializeComponent();
        }

        /**
         * 
         * This method is called when the form is loading to initialize components
         * 
         **/
        private void frmReviews_Load(object sender, EventArgs e) {
            // TODO: This line of code loads data into the 'megaBooksDBDataSet.Books' table. You can move, or remove it, as needed.
            booksTableAdapter.Fill(megaBooksDBDataSet.Books);
            // Dynamically set the form title
            Text = "Reviews | " + Properties.Settings.Default.ApplicationName;

            // Load megaBooksDatSet into the reviewsTableAdapter
            reviewsTableAdapter.Fill(megaBooksDBDataSet.Reviews);

            dgbReviewsBookColLinkColumn.DisplayStyle = DataGridViewComboBoxDisplayStyle.Nothing;
        }

        /**
         * 
         * This method is used to handle when a user desires to delete a review from the database
         * 
         **/
        private void bngReviewDelete_Click(object sender, EventArgs e) {
            // Confirm that the user does want to delete the review record
            if (MessageBox.Show("Are you sure you want to delete the selected review?", "Delete Review Record?", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Exclamation) == DialogResult.Yes) {
                // Try connecting to the database
                using (SqlConnection conn = new SqlConnection(Properties.Settings.Default.MegaBooksDBConnectionString)) {
                    // Open the connection to the database
                    conn.Open();

                    // Try using a SqlCommand to delete the item from the database
                    using (SqlCommand command = new SqlCommand("DELETE FROM reviews WHERE id = @id", conn)) {
                        // Append the parameter to the query string and execute the query
                        command.Parameters.AddWithValue("@id", dgvReviews.CurrentRow.Cells[0].Value);

                        // Check to make sure that the delete went through
                        if (command.ExecuteNonQuery() == 0) {
                            // Display an error message
                            MessageBox.Show("Oops... Something happened and the selected review (" + dgvReviews.CurrentRow.Cells[0].Value + ") cannot be deleted.  Please try again.", "Deleteing Review Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);

                            // Display error also in the status strip
                            tsslReviews.Text = "Deleteing Review (" + dgvReviews.CurrentRow.Cells[0].Value + ") Failed.";

                            // Return to not process any more of the method
                            return;
                        }

                        // Delete row from dataset
                        megaBooksDBDataSet.Reviews.Rows.RemoveAt(dgvReviews.CurrentCell.RowIndex);

                        // Close the connection to the database
                        conn.Close();
                    }
                }
            }
        }

        /**
         * 
         * This method is used to handle the click event of adding a new review
         * 
         **/
        private void bngReviewAdd_Click(object sender, EventArgs e) {
            // Open the form to add a new review and pass in this form
            new frmReviewAdd(this).Show();
        }

        /**
         * 
         * This method is used to handle the click event of editing a review
         * 
         **/
        private void tsbReviewEdit_Click(object sender, EventArgs e) {
            // Call the cell edit function
            editReview();
        }

        /**
         * 
         * This method is used to handle the double-click event of a table cell
         * 
         **/
        private void dgvReviews_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e) {
            // Call the cell edit function
            editReview();
        }

        /**
         * 
         * This method is used to perform the pre-editing of a review
         * 
         **/
        private void editReview() {
            // Select the curret row and store it into a variable
            DataGridViewRow selectedReview = dgvReviews.CurrentRow;

            // Create a Review book instance
            Book reviewBook = null;

            // Try and open a connection to the database
            using (SqlConnection conn = new SqlConnection(Properties.Settings.Default.MegaBooksDBConnectionString)) {
                // Open the connection to the database
                conn.Open();

                // Perform the retrival of a book from the DB
                using (SqlCommand command = new SqlCommand("SELECT * FROM books WHERE id = @id", conn)) {
                    // Append the values to be updated to the query string
                    command.Parameters.AddWithValue("@id", int.Parse(selectedReview.Cells[5].Value.ToString()));

                    // Try using the SqlDataReader to read the books
                    using (SqlDataReader reader = command.ExecuteReader()) {
                        // Check to make sure that the data can be read
                        if (reader.Read()) {
                            // Create the reviewBook instance
                            reviewBook = new Book(int.Parse(reader["id"].ToString()), reader["name"].ToString(), reader["author"].ToString(), DateTime.Parse(reader["date"].ToString()), reader["isbn"].ToString());
                        }
                    }

                    // Close the connection to the database
                    conn.Close();
                }
            }

            // Based on the selected row, create a new Review instance
            Review editReview = new Review(int.Parse(selectedReview.Cells[0].Value.ToString()), selectedReview.Cells[1].Value.ToString(), selectedReview.Cells[2].Value.ToString(), DateTime.Parse(selectedReview.Cells[3].Value.ToString()), int.Parse(selectedReview.Cells[4].Value.ToString()), reviewBook);

            // Display the edit form and pass in the desires review to edit and this form
            new frmReviewEdit(editReview, this).Show();
        }

        /**
         * 
         * This method is used to hack around the exception thrown when closing the orm because of the combobox addition of the book name
         * 
         **/
        private void dgvReviews_DataError(object sender, DataGridViewDataErrorEventArgs e) {
            // Return to do no processsing
            return;
        }
    }
}
