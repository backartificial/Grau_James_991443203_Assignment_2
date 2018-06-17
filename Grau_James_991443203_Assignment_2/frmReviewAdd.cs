using System;
using System.Windows.Forms;

namespace Grau_James_991443203_Assignment_2 {
    public partial class frmReviewAdd : Form {
        public frmReviewAdd() {
            InitializeComponent();
        }

        /**
         * 
         * This method is called to initialize form elements on form load
         * 
         **/
        private void frmReviewAdd_Load(object sender, EventArgs e) {
            // Set the from title dynamically
            Text = "Add Review | " + Properties.Settings.Default.ApplicationName;
            
            // Load megaBooksDatSet into the booksTableAdapter
            booksTableAdapter.Fill(megaBooksDBDataSet.Books);

            // Load megaBooksDatSet into the reviewsTableAdapter
            reviewsTableAdapter.Fill(megaBooksDBDataSet.Reviews);

        }

        private void trbReview_Scroll(object sender, EventArgs e) {
            // Set txtReview value to te value of the slider for visual understanding of rating value
            txtReview.Text = trbReview.Value.ToString();
        }
    }
}
