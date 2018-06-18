/**
 * 
 * File: frmMain.cs
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
    // Class to handle frmSearchReviews
    public partial class frmMain : Form {
        /**
         * 
         * This method is called when initializeing the form
         * 
         **/
        public frmMain() {
            // Initialize the form component
            InitializeComponent();
        }

        /**
         * 
         * This method is called when the form is loading
         * 
         **/
        private void frmMain_Load(object sender, EventArgs e) {
            // Set form title
            Text = Properties.Settings.Default.ApplicationName;
        }

        /**
         * 
         * This method is used for handling the display of the books form
         * 
         **/
        private void btnHandleBooks_Click(object sender, EventArgs e) {
            // Show the Books from
            new frmBooks().Show();
        }

        /**
         * 
         * This method is used for handling the display of the reviews form
         * 
         **/
        private void btnHandleReviews_Click(object sender, EventArgs e) {
            // Show the Reviews from
            new frmReviews().Show();
        }

        /**
         * 
         * This method is used for handling the display of the search reviews form
         * 
         **/
        private void btnSearchReviews_Click(object sender, EventArgs e) {
            // Show the Reviews from
            new frmSearchReviews().Show();
        }
    }
}
