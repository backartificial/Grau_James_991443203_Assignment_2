using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Grau_James_991443203_Assignment_2 {
    public partial class frmReviews : Form {
        public frmReviews() {
            InitializeComponent();
        }

        private void reviewsBindingNavigatorSaveItem_Click(object sender, EventArgs e) {
            this.Validate();
            this.reviewsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.megaBooksDBDataSet);

        }

        private void frmReviews_Load(object sender, EventArgs e) {
            // Dynamically set the form title
            Text = "Reviews | " + Properties.Settings.Default.ApplicationName;

            // Load megaBooksDatSet into the reviewsTableAdapter
            reviewsTableAdapter.Fill(megaBooksDBDataSet.Reviews);

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
    }
}
