/**
 * 
 * File: frmReviewAdd.cs
 * Date: June 17, 2018
 * Name: James Grau
 * Student Id: 991443203
 * 
 **/

// Include needed packages
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Windows.Forms;

// Declare Namespace 
namespace Grau_James_991443203_Assignment_2 {
    // Class to handle frmReviewAdd
    public partial class frmReviewAdd : Form {
        // Create needed class variables
        private frmReviews reviewsForm;

        /**
         * 
         * This method is used to initialized the form
         * 
         **/
        public frmReviewAdd(frmReviews reviewsForm) {
            // Initialize the form component
            InitializeComponent();

            // Set class variables
            this.reviewsForm = reviewsForm;
        }

        /**
         * 
         * This method is called to initialize form elements on form load
         * 
         **/
        private void frmReviewAdd_Load(object sender, EventArgs e) {
            /// Set the from title dynamically
            Text = "Add Review | " + Properties.Settings.Default.ApplicationName;

            // Set the Id
            setId();

            // Create a new dictionary of books
            Dictionary<int, string> cmbBooksSource = new Dictionary<int, string>();

            // Try and open a connection to the database
            using (SqlConnection conn = new SqlConnection(Properties.Settings.Default.MegaBooksDBConnectionString)) {
                // Open the connection to the database
                conn.Open();

                // Perform the retrival of books from the DB
                using (SqlCommand command = new SqlCommand("SELECT DISTINCT id, name FROM books", conn)) {
                    // Try using the SqlDataReader to read the books
                    using (SqlDataReader reader = command.ExecuteReader()) {
                        // Loop over the returned data
                        while(reader.Read()) {
                            // Add the book to the dictionary
                            cmbBooksSource.Add(int.Parse(reader["id"].ToString()), reader["name"].ToString());
                        }
                    }

                    // Close the connection to the database
                    conn.Close();
                }
            }

            // Initialize the bcombobox to use the dictionary for key, value pair
            cmbBooks.DataSource = new BindingSource(cmbBooksSource, null);
            cmbBooks.DisplayMember = "Value";
            cmbBooks.ValueMember = "Key";

            // Disable typing in a value into the combobox
            cmbBooks.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        /**
         * 
         * This method is used to handle when the slider value changes
         * 
         **/
        private void trbReview_Scroll(object sender, EventArgs e) {
            // Set txtReview value to te value of the slider for visual understanding of rating value
            txtRating.Text = trbRating.Value.ToString();
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
         * This method is used to handle the addition of a new review
         * 
         **/
        private void btnAddReview_Click(object sender, EventArgs e) {
            // Check if validation passed
            if (checkValidInput()) {
                // Check if the Review has been added
                if (addReview()) {
                    // Close the add form
                    Close();
                }
            }
        }

        /**
         * 
         * This method is used to add another review
         * 
         **/
        private void btnAddAnotherReview_Click(object sender, EventArgs e) {
            // Check if validation passed
            if (checkValidInput()) {
                // Check if the book has been added
                if (addReview()) {
                    // Clear all textboxes
                    cmbBooks.SelectionLength = 0;
                    txtReviewer.Text = "";
                    txtRating.Text = "0";
                    dtpReviewDate.Value = DateTime.Now.Date;
                    rtbReview.Text = "";

                    // Call Method to reset ID
                    setId();

                    // Set the Focus on the Name field
                    txtReviewer.Focus();
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
            if (string.IsNullOrWhiteSpace(txtRating.Text) || string.IsNullOrWhiteSpace(txtReviewer.Text) || string.IsNullOrWhiteSpace(dtpReviewDate.ToString()) || string.IsNullOrWhiteSpace(rtbReview.Text)) {
                // Display error message
                MessageBox.Show("Oops.. Some values are not filled out.  All fields (except rating) must be filled out before adding a new review.  Please fill out the fields and try again!", "Empty Input Values", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                // Return false on error
                return false;
            }

            // Return true on validation success
            return true;
        }

        /**
         * 
         * This method is used to add a new review to the list & DB
         * 
         **/
        private Boolean addReview() {
            // Try and open a connection to the database
            using (SqlConnection conn = new SqlConnection(Properties.Settings.Default.MegaBooksDBConnectionString)) {
                // Open the connection to the database
                conn.Open();

                // Perform the insert of the book into the database
                using (SqlCommand command = new SqlCommand("INSERT INTO Reviews (reviewer, review, date, rating, book_id) VALUES (@reviewer, @review, @date, @rating, @book_id)", conn)) {
                    // Append the values to the insert query string
                    command.Parameters.AddWithValue("@reviewer", txtReviewer.Text);
                    command.Parameters.AddWithValue("@review", rtbReview.Text);
                    command.Parameters.AddWithValue("@date", dtpReviewDate.Value.ToShortDateString());
                    command.Parameters.AddWithValue("@rating", trbRating.Value);
                    command.Parameters.AddWithValue("@book_id", ((KeyValuePair<int, string>)cmbBooks.SelectedItem).Key);

                    // Check to see if the insert worked
                    if (command.ExecuteNonQuery() > 0) {
                        // Set the Status strip to display that the review was added
                        reviewsForm.tsslReviews.Text = "Review Added Successfully!";
                    } else {
                        // Set the Status strip to display that the review was not added
                        reviewsForm.tsslReviews.Text = "Review Failed to Add...";

                        // Display an addition failure message
                        MessageBox.Show("Hmm... Adding the review failed.  Please try again.", "Review Addition Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);

                        // Cancel further method processing
                        return false;
                    }

                    // Increment reviews added since program open
                    Properties.Settings.Default.ReviewsAdded++;

                    // Refresh Footer on reviews table
                    reviewsForm.tsslReviewsMade.Text = "Reviews Published Since Program Open: " + Properties.Settings.Default.ReviewsAdded;

                    // Display MessageBox with review ID
                    MessageBox.Show("Thanks for adding a review! Your Review Id is " + txtId.Text, "Review Id", MessageBoxButtons.OK, MessageBoxIcon.Information);


                    // Refresh the DataGrid on the reviews form
                    reviewsForm.reviewsTableAdapter.Fill(reviewsForm.megaBooksDBDataSet.Reviews);
                    reviewsForm.dgvReviews.Refresh();
                    reviewsForm.dgvReviews.Parent.Refresh();

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
                using (SqlCommand command = new SqlCommand("SELECT TOP(1) IDENT_CURRENT('Reviews') + IDENT_INCR('Reviews') AS 'nextId' FROM Reviews", conn)) {
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
