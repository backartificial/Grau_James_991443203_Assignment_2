/**
 * 
 * File: frmReviewEdit.cs
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
    // Class to handle frmEdit
    public partial class frmReviewEdit : Form {
        // Create needed class variables
        private Review editReview;
        private frmReviews reviewsForm;
        
        /**
         * 
         * This method is used to initialize frmReviewEdit form
         * 
         **/
        public frmReviewEdit(Review editReview, frmReviews reviewsForm) {
            // Initialize the form component
            InitializeComponent();

            // Set the class variables
            this.editReview = editReview;
            this.reviewsForm = reviewsForm;
        }

        /**
         * 
         * This methos is used to handle closing the add form
         * 
         **/
        private void btnCancel_Click(object sender, EventArgs e) {
            // Close the form 
            Close();
        }

        /**
         * 
         * This method is called when loading the form
         * 
         **/
        private void frmReviewEdit_Load(object sender, EventArgs e) {
            // Dynamically set the form title
            Text = "Editing Review (" + editReview.id + ") | " + Properties.Settings.Default.ApplicationName;

            // Set the values of the textfields to the book being edited values
            txtId.Text = editReview.id.ToString();
            txtBook.Text = editReview.book.name;
            txtReviewer.Text = editReview.reviewer;
            trbRating.Value = editReview.rating;
            txtRating.Text = editReview.rating.ToString();
            dtpReviewDate.Value = DateTime.Parse(editReview.date.ToString()).Date;
            rtbReview.Text = editReview.review;
        }

        /**
         * 
         * This method is used to perform the update of the review in the database and reviews table
         * 
         **/
        private void btnSave_Click(object sender, EventArgs e) {
            // Check for valid input
            if (checkValidInput()) {
                // Try and open a connection to the database
                using (SqlConnection conn = new SqlConnection(Properties.Settings.Default.MegaBooksDBConnectionString)) {
                    // Open the connection to the database
                    conn.Open();

                    // Perform the update of the review into the database
                    using (SqlCommand command = new SqlCommand("UPDATE Reviews SET rating = @rating, review = @review WHERE id = @id", conn)) {
                        // Append the values to be updated to the query string
                        command.Parameters.AddWithValue("@rating", trbRating.Value.ToString());
                        command.Parameters.AddWithValue("@review", rtbReview.Text);
                        command.Parameters.AddWithValue("@id", editReview.id);

                        // Check to see if the update worked
                        if (command.ExecuteNonQuery() > 0) {
                            // Set the Status strip to display that the review was updated
                            reviewsForm.tsslReviews.Text = "Review (" + txtId.Text + ") Updated Successfully!";
                        } else {
                            // Set the Status strip to display that the review was not updated
                            reviewsForm.tsslReviews.Text = "Review (" + txtId.Text + ") Failed to Update...";

                            // Display an update failure message
                            MessageBox.Show("Hmm... Updating the review failed.  Please try again.", "Review Update Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);

                            // Cancel further method processing
                            return;
                        }

                        // Refresh the DataGrid on the reviews form
                        reviewsForm.reviewsTableAdapter.Fill(reviewsForm.megaBooksDBDataSet.Reviews);
                        reviewsForm.dgvReviews.Refresh();
                        reviewsForm.dgvReviews.Parent.Refresh();

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
         * This method is used to make sure that all fields are filled out
         * 
         * @return Boolean [true - Validation Pass | fail - Validation Fail]
         * 
         **/
        private Boolean checkValidInput() {
            // Check if the input values are empty
            if (string.IsNullOrWhiteSpace(txtRating.Text) || trbRating.Value == 0 || string.IsNullOrWhiteSpace(txtReviewer.Text) || string.IsNullOrWhiteSpace(dtpReviewDate.ToString()) || string.IsNullOrWhiteSpace(rtbReview.Text)) {
                // Display error message
                MessageBox.Show("Oops.. Some values are not filled out.  All fields must be filled out before adding a new review.  Please fill out the fields and try again!", "Empty Input Values", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                // Return false on error
                return false;
            }

            // Return true on validation success
            return true;
        }

        /**
         * 
         * This method is used to update the review txt ov slider change
         * 
         **/
        private void trbRating_Scroll(object sender, EventArgs e) {
            // Change the visual display of the review value
            txtRating.Text = trbRating.Value.ToString();
        }
    }
}
