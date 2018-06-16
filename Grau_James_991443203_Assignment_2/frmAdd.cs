using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Grau_James_991443203_Assignment_2 {
    public partial class frmAdd : Form {
        private frmBooks bookForm;
        private static SqlConnection conn = new SqlConnection(Properties.Settings.Default.MegaBooksDBConnectionString);
        private SqlDataAdapter apt = new SqlDataAdapter("SELECT * FROM books", conn);


        public frmAdd(frmBooks frm) {
            InitializeComponent();

            bookForm = frm;
        }

        private void btnAdd_Click(object sender, EventArgs e) {
            // Check if fields are ready to be processed for adding book
            if (checkFilledFields()) {
                // Create a new Book instance
                Book newBook = new Book(int.Parse(txtId.Text), txtName.Text, txtAuthor.Text, DateTime.Parse(dtpDate.Text).Date, mtxtISBN.Text);

                // Set the data source to null for the datagridview datasource
                bookForm.dgvBooks.DataSource = null;

                // Perform Update and refresh on data table
                bookForm.dgvBooks.Update();
                bookForm.dgvBooks.Refresh();
                bookForm.dgvBooks.Parent.Refresh();

                // Initialize a new datatable
                DataTable dt = new DataTable();
                apt.Fill(dt);

                DataRow newRow = dt.NewRow();

                newRow["id"] = newBook.id;
                newRow["name"] = newBook.name;
                newRow["author"] = newBook.author;
                newRow["date"] = newBook.date;
                newRow["isbn"] = newBook.isbn;

                dt.Rows.Add(newRow);

                bookForm.dgvBooks.DataSource = dt;
            }   
        }

        private Boolean checkFilledFields() {
            if (string.IsNullOrWhiteSpace(txtName.Text) || string.IsNullOrWhiteSpace(txtAuthor.Text) || string.IsNullOrWhiteSpace(txtName.Text) || string.IsNullOrWhiteSpace(mtxtISBN.Text)) {
                MessageBox.Show("Oops.. Before you can add a new book, all fields need to be filled out.  Please ensure that all fields ar filled out and try again!", "Fill All Fields", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                return false;
            }

            return true;
        }

        private void frmAdd_Load(object sender, EventArgs e) {
            using(SqlConnection conn = new SqlConnection("Data Source=JAMES-SHERIDAN-\\JAMESGRAUSQLSERV;Initial Catalog=MegaBooksDB;Integrated Security=True;")) {
                SqlCommand cmd = new SqlCommand("SELECT IDENT_CURRENT('Books') + IDENT_INCR('Books') AS \"nextId\"", conn);
                conn.Open();
                
                using (SqlDataReader reader = cmd.ExecuteReader()) {
                    if (reader.Read()) {
                        txtId.Text = reader["nextId"].ToString();
                    }
                }
            }
        }
    }
}
