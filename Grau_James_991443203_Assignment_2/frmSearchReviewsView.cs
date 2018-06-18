/**
 * 
 * File: frmSearchReviews.cs
 * Date: June 17, 2018
 * Name: James Grau
 * Student Id: 991443203
 * 
 **/

// Include needed packages
using System;
using System.Windows.Forms;

// Declare Namespace 
namespace Grau_James_991443203_Assignment_2 {
    // Class to handle frmSearchReviewsView
    public partial class frmSearchReviewsView : Form {
        // Create needed class variables
        private Review viewReview;
        private frmSearchReviews searchReviewsForm;

        /**
         * 
         * This method is called when initializeing the form
         * 
         * @param viewReview: is the review being viewed
         * @param searchReviewsForm: is the reviews form that is needed for some controls
         * 
         **/
        public frmSearchReviewsView(Review viewReview, frmSearchReviews searchReviewsForm) {
            // Initialize the form component
            InitializeComponent();

            // Set the class variables
            this.viewReview = viewReview;
            this.searchReviewsForm = searchReviewsForm;

            // Set the values of the textfields to the book being edited values
            txtId.Text = viewReview.id.ToString();
            txtBook.Text = viewReview.book.name;
            txtReviewer.Text = viewReview.reviewer;
            txtRating.Text = viewReview.rating.ToString();
            dtpReviewDate.Value = DateTime.Parse(viewReview.date.ToString()).Date;
            rtbReview.Text = viewReview.review;
        }

        /**
         * 
         * This method is called when the form is loading
         * 
         **/
        private void frmSearchReviewsView_Load(object sender, EventArgs e) {
            // Set form titles
            Text = "Viewing Reivew (" + viewReview.id.ToString() + ") | " + Properties.Settings.Default.ApplicationName;
            lblTitle.Text = "Viewing Review (" + viewReview.id.ToString() + ")";
        }

        /**
         * 
         * This method is used when the user wantes to close the form
         * 
         **/
        private void btnClose_Click(object sender, EventArgs e) {
            // Close the Form
            Close();
        }
    }
}
