using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Grau_James_991443203_Assignment_2 {
    public partial class frmEdit : Form {
        private Book editBook;
        private frmBooks booksForm;

        public frmEdit(Book editBook, frmBooks booksForm) {
            InitializeComponent();

            this.editBook = editBook;
            this.booksForm = booksForm;
        }

        private void frmEdit_Load(object sender, EventArgs e) {
            Text = "Editing Book (" + editBook.name + ") | " + Properties.Settings.Default.ApplicationName;

            txtId.Text = editBook.id.ToString();
            txtName.Text = editBook.name;
            txtAuthor.Text = editBook.author;
            dtpDate.Value = DateTime.Parse(editBook.date.ToString()).Date;
            mtbISBN.Text = editBook.isbn;
        }

        /**
         * 
         * This method is used to handel when the user click close to cancel editing
         * 
         **/
        private void btnCancel_Click(object sender, EventArgs e) {
            // Close the form
            Close();
        }

        /**
         * 
         * This method is used to save the edited book info
         * 
         **/
        private void btnSave_Click(object sender, EventArgs e) {
            // Try and open a connection to the database
            using (SqlConnection conn = new SqlConnection(Properties.Settings.Default.MegaBooksDBConnectionString)) {
                // Open the connection to the database
                conn.Open();

                // Perform the update of the book into the database
                using (SqlCommand command = new SqlCommand("UPDATE books SET name = @name, author = @author, date = @date, isbn = @isbn WHERE id = @id", conn)) {
                    // Append the values to be updated to the query string
                    command.Parameters.AddWithValue("@name", txtName.Text);
                    command.Parameters.AddWithValue("@author", txtAuthor.Text);
                    command.Parameters.AddWithValue("@date", dtpDate.Value.ToShortDateString());
                    command.Parameters.AddWithValue("@isbn", mtbISBN.Text);
                    command.Parameters.AddWithValue("@id", editBook.id);

                    // Execute auery
                    command.ExecuteNonQuery();

                    // Refresh the DataGrid on the books form
                    booksForm.booksTableAdapter.Fill(booksForm.megaBooksDBDataSet.Books);
                    booksForm.dgvBooks.Refresh();
                    booksForm.dgvBooks.Parent.Refresh();

                    Close();
                }
            }
        }
    }
}
