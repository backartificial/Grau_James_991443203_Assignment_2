using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Grau_James_991443203_Assignment_2 {
    public partial class frmBooks : Form {
        private static SqlConnection conn = new SqlConnection(Properties.Settings.Default.MegaBooksDBConnectionString);
        private SqlDataAdapter apt = new SqlDataAdapter("SELECT * FROM books", conn);

        public frmBooks() {
            InitializeComponent();
        }

        private void frmBooks_Load(object sender, EventArgs e) {
            DataTable dt = new DataTable();
            apt.Fill(dt);
            dgvBooks.DataSource = dt;
            BindingSource bs = new BindingSource();
            bs.DataSource = dgvBooks.DataSource;

            bngBooks.BindingSource = bs;
        }

        /**
         * 
         * This method is used for providing the click event to refresh database data to the datagridview
         * 
         **/
        private void tsbRefresh_Click(object sender, EventArgs e) {
            // Set the data source to null for the datagridview datasource
            dgvBooks.DataSource = null;

            // Perform Update and refresh on data table
            dgvBooks.Update();
            dgvBooks.Refresh();
            dgvBooks.Parent.Refresh();

            // Initialize a new datatable
            DataTable dt = new DataTable();
            
            // Fill data table with the database items
            apt.Fill(dt);

            // Set the datagridview datasource to the datatable
            dgvBooks.DataSource = dt;
        }

        /**
         * 
         * This method is used for providing the click event to add a new book
         * 
         **/
        private void bsnAdd_Click(object sender, EventArgs e) {
            // Display the new book form passing inthe current form for access to the datagridview
            new frmAdd(this).Show();
        }
    }
}
