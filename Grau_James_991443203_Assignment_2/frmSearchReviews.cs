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
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

// Declare Namespace 
namespace Grau_James_991443203_Assignment_2 {
    // Class to handle frmSearchReviews
    public partial class frmSearchReviews : Form {
        // Create class variables
        DataTable dtReviews = new DataTable();

        /**
         * 
         * This method is called when initializeing the form
         * 
         **/
        public frmSearchReviews() {
            // Initialize the form component
            InitializeComponent();
        }

        /**
         * 
         * This method is called when loading the form
         * 
         **/
        private void frmSearchReviews_Load(object sender, EventArgs e) {
            // Set the form Title
            Text = "Search Reviews | " + Properties.Settings.Default.ApplicationName;

            // Try and connect to the database
            using (SqlConnection conn = new SqlConnection(Properties.Settings.Default.MegaBooksDBConnectionString)) {
                // Try and execute the query
                using (SqlDataAdapter adapter = new SqlDataAdapter("SELECT r.id AS 'Review Id', r.book_id AS 'Book Id', b.name AS 'Book Name', r.reviewer AS 'Reviewer Name', r.review AS 'Review', r.date AS 'Review Date', r.rating AS 'Book Rating' FROM Reviews r INNER JOIN Books b ON r.book_id = b.id", conn)) {
                    // Fill the datatable with the returned data
                    adapter.Fill(dtReviews);
                }
            }

            // Initialize the datasource of the dataviewGrid
            dgvReviews.DataSource = dtReviews;
        }

        /**
         * 
         * This method is used to perform an advanced filter on the reviews data provided
         * 
         **/
        private void btnSearch_Click(object sender, EventArgs e) {
            // Create needed method values
            int numberOfQueries = 1;
            string query = "", choice1 = "{2} ", choice2 = "{6} ", choice3 = "{10} ";

            // Check to see if the the user decided to add a second query
            if (cmbColumn1.SelectedItem == null || cmbOptions1.SelectedItem == null || string.IsNullOrWhiteSpace(txtValue1.Text)) {
                // Display error message
                MessageBox.Show("Oops... You must apply filter options inorder to filter the table..  Please enter at least one filter to continue.", "Invalid Query", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                // Return to quit further processing
                return;
            }else {
                // Check to see if the valid column/operator is compatible
                if (cmbColumn1.SelectedItem.ToString().Equals("Book Id") && cmbOptions1.SelectedItem.ToString().Equals("LIKE")) {
                    // Display Error Message
                    MessageBox.Show("Oops... You cannot use the 'LIKE' operator on the 'Book Id' column.  Please select another operator.", "Invalid Operator", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                    // Return to not continue filtering
                    return;
                }

                // Check to see if the valid column/operator is compatible
                if (cmbColumn1.SelectedItem.ToString().Equals("Book Name") && !(cmbOptions1.SelectedItem.ToString().Equals("<>") || cmbOptions1.SelectedItem.ToString().Equals("=") || cmbOptions1.SelectedItem.ToString().Equals("LIKE"))) {
                    // Display Error Message
                    MessageBox.Show("Oops... You cannot use any other operator other than ('<>', '=', or 'LIKE') on the 'Book Name' column.  Please select an operator listed previously.", "Invalid Operator", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                    // Return to not continue filtering
                    return;
                }

                // Check to see if the valid column/operator is compatible
                if (cmbColumn1.SelectedItem.ToString().Equals("Reviewer Name") && !(cmbOptions1.SelectedItem.ToString().Equals("<>") || cmbOptions1.SelectedItem.ToString().Equals("=") || cmbOptions1.SelectedItem.ToString().Equals("LIKE"))) {
                    // Display Error Message
                    MessageBox.Show("Oops... You cannot use any other operator other than ('<>', '=', or 'LIKE') on the 'Reviewer Name' column.  Please select an operator listed previously", "Invalid Operator", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                    // Return to not continue filtering
                    return;
                }

                // Check if the LIKE operator has been selected
                if (cmbOptions1.SelectedItem.ToString().Equals("LIKE")) {
                    // Set the sub choice for query display
                    choice1 = "'%{2}%' ";
                }

                // Append to the query string
                query = "[{0}] {1} " + choice1;
            }

            // Check to see if the the user decided to add a second query
            if (cmbJoin1.SelectedItem != null) {
                // Check to make sure that the user enter a second query
                if (cmbColumn2.SelectedItem == null || cmbOptions2.SelectedItem == null || string.IsNullOrWhiteSpace(txtValue2.Text)) {
                    // Display error message
                    MessageBox.Show("Oops... You have decided to add a second item to the filter but not all fields for the second filter are complete.  Please fill out all of the items for the second query to properly filter.", "Invalid Query", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                    // Return to quit further processing
                    return;
                } else {
                    // Check to see if the valid column/operator is compatible
                    if (cmbColumn2.SelectedItem.ToString().Equals("Book Id") && cmbOptions2.SelectedItem.ToString().Equals("LIKE")) {
                        // Display Error Message
                        MessageBox.Show("Oops... You cannot use the 'LIKE' operator on the 'Book Id' column.  Please select another operator.", "Invalid Operator", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                        // Return to not continue filtering
                        return;
                    }

                    // Check to see if the valid column/operator is compatible
                    if (cmbColumn2.SelectedItem.ToString().Equals("Book Name") && !(cmbOptions2.SelectedItem.ToString().Equals("<>") || cmbOptions2.SelectedItem.ToString().Equals("=") || cmbOptions2.SelectedItem.ToString().Equals("LIKE"))) {
                        // Display Error Message
                        MessageBox.Show("Oops... You cannot use any other operator other than ('<>', '=', or 'LIKE') on the 'Book Name' column.  Please select an operator listed previously.", "Invalid Operator", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                        // Return to not continue filtering
                        return;
                    }

                    // Check to see if the valid column/operator is compatible
                    if (cmbColumn2.SelectedItem.ToString().Equals("Reviewer Name") && !(cmbOptions2.SelectedItem.ToString().Equals("<>") || cmbOptions2.SelectedItem.ToString().Equals("=") || cmbOptions2.SelectedItem.ToString().Equals("LIKE"))) {
                        // Display Error Message
                        MessageBox.Show("Oops... You cannot use any other operator other than ('<>', '=', or 'LIKE') on the 'Reviewer Name' column.  Please select an operator listed previously.", "Invalid Operator", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                        // Return to not continue filtering
                        return;
                    }

                    // Increment the number of queries to perform
                    numberOfQueries++;

                    // Check if the LIKE operator has been selected
                    if (cmbOptions2.SelectedItem.ToString().Equals("LIKE")) {
                        // Set the sub choice for query display
                        choice2 = "'%{6}%' ";
                    }

                    // Append to the query string
                    query = query + "{3} [{4}] {5} " + choice2;
                }
            }

            // Check to see if the the user decided to add a third query
            if (cmbJoin2.SelectedItem != null) {
                // Check to make sure that the user enter a third query
                if (cmbColumn3.SelectedItem == null || cmbOptions3.SelectedItem == null || string.IsNullOrWhiteSpace(txtValue3.Text)) {
                    // Display error message
                    MessageBox.Show("Oops... You have decided to add a third item to the filter but not all fields for the third filter are complete.  Please fill out all of the items for the third query to properly filter.", "Invalid Query", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                    // Return to quit further processing
                    return;
                } else {
                    // Check to see if the valid column/operator is compatible
                    if(cmbColumn3.SelectedItem.ToString().Equals("Book Id") && cmbOptions3 .SelectedItem.ToString().Equals("LIKE")) {
                        // Display Error Message
                        MessageBox.Show("Oops... You cannot use the 'LIKE' operator on the 'Book Id' column.  Please select another operator.", "Invalid Operator", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                        // Return to not continue filtering
                        return;
                    }

                    // Check to see if the valid column/operator is compatible
                    if (cmbColumn3.SelectedItem.ToString().Equals("Book Name") && !(cmbOptions3.SelectedItem.ToString().Equals("<>") || cmbOptions3.SelectedItem.ToString().Equals("=") || cmbOptions3.SelectedItem.ToString().Equals("LIKE"))) {
                        // Display Error Message
                        MessageBox.Show("Oops... You cannot use any other operator other than ('<>', '=', or 'LIKE') on the 'Book Name' column.  Please select an operator listed previously.", "Invalid Operator", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                        // Return to not continue filtering
                        return;
                    }

                    // Check to see if the valid column/operator is compatible
                    if (cmbColumn3.SelectedItem.ToString().Equals("Reviewer Name") && !(cmbOptions3.SelectedItem.ToString().Equals("<>") || cmbOptions3.SelectedItem.ToString().Equals("=") || cmbOptions3.SelectedItem.ToString().Equals("LIKE"))) {
                        // Display Error Message
                        MessageBox.Show("Oops... You cannot use any other operator other than ('<>', '=', or 'LIKE') on the 'Reviewer Name' column.  Please select an operator listed previously.", "Invalid Operator", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                        // Return to not continue filtering
                        return;
                    }

                    // Increment the number of queries to perform
                    numberOfQueries++;

                    // Check if the LIKE operator has been selected
                    if (cmbOptions3.SelectedItem.ToString().Equals("LIKE")) {
                        // Set the sub choice for query display
                        choice3 = "'%{10}%'";
                    }

                    // Append to the query string
                    query = query + "{7} [{8}] {9} " + choice3;
                }
            }

            // Initialize a new DataView to be filtered
            DataView filterView = new DataView(dtReviews);

            // Switch based on number of queries
            switch (numberOfQueries) {
                // Case for if one filter is applied
                case 1:
                    // Apply Filter for 1 filter query
                    filterView.RowFilter = string.Format(query, cmbColumn1.SelectedItem.ToString(), cmbOptions1.SelectedItem.ToString(), txtValue1.Text);
                break;

                // Case for if two filters are applied
                case 2:
                    // Apply Filter for 2 filter queries
                    filterView.RowFilter = string.Format(query, cmbColumn1.SelectedItem.ToString(), cmbOptions1.SelectedItem.ToString(), txtValue1.Text, cmbJoin1.SelectedItem.ToString(), cmbColumn2.SelectedItem.ToString(), cmbOptions2.SelectedItem.ToString(), txtValue2.Text);
                break;

                // Case for if three filters are applied
                case 3:
                    // Apply Filter for 3 filter queries
                    filterView.RowFilter = string.Format(query, cmbColumn1.SelectedItem.ToString(), cmbOptions1.SelectedItem.ToString(), txtValue1.Text, cmbJoin1.SelectedItem.ToString(), cmbColumn2.SelectedItem.ToString(), cmbOptions2.SelectedItem.ToString(), txtValue2.Text, cmbJoin2.SelectedItem.ToString(), cmbColumn3.SelectedItem.ToString(), cmbOptions3.SelectedItem.ToString(), txtValue3.Text);
                break;
            }
            
            // Re-initialize filtered data to datagridview
            dgvReviews.DataSource = filterView;
        }

        /**
         * 
         * This method is used to clear the current applied filter
         * 
         **/
        private void btnClear_Click(object sender, EventArgs e) {
            // Clear the Filter Option
            cmbColumn1.SelectedIndex = -1;
            cmbColumn2.SelectedIndex = -1;
            cmbColumn3.SelectedIndex = -1;
            cmbJoin1.SelectedIndex = -1;
            cmbJoin2.SelectedIndex = -1;
            cmbOptions1.SelectedIndex = -1;
            cmbOptions2.SelectedIndex = -1;
            cmbOptions3.SelectedIndex = -1;
            txtValue1.Text = "";
            txtValue2.Text = "";
            txtValue3.Text = "";

            // Set the Datagrid back to unfiltered
            dgvReviews.DataSource = dtReviews;
        }
    }
}
