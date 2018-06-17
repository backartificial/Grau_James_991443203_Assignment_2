using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Grau_James_991443203_Assignment_2 {
    public partial class frmBooks : Form {
        public frmBooks() {
            InitializeComponent();
        }

        private void frmBooks_Load(object sender, EventArgs e) {
            // TODO: This line of code loads data into the 'megaBooksDBDataSet.Books' table. You can move, or remove it, as needed.
            booksTableAdapter.Fill(megaBooksDBDataSet.Books);
        }

        private void booksBindingNavigatorSaveItem_Click(object sender, EventArgs e) {
            Validate();
            booksBindingSource.EndEdit();
            tableAdapterManager.UpdateAll(megaBooksDBDataSet);
        }        

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e) {
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to delete the selected book?", "Delete Book Record?", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Exclamation);

            if(dialogResult == DialogResult.Yes) {
                using (SqlConnection conn = new SqlConnection(Properties.Settings.Default.MegaBooksDBConnectionString)) { 
                    conn.Open();

                    using (SqlCommand command = new SqlCommand("DELETE FROM books WHERE id = @id", conn)) {
                        // delete item from database
                        command.Parameters.AddWithValue("@id", dgvBooks.CurrentRow.Cells[0].Value);
                        command.ExecuteNonQuery();

                        // delete item from datasource and update DGV
                        megaBooksDBDataSet.Books.Rows.RemoveAt(dgvBooks.CurrentCell.RowIndex);
                    }
                }
            }
        }

        private void tsbEdit_Click(object sender, EventArgs e) {
            var selectedBook = dgvBooks.CurrentRow;
            Book editBook = new Book(int.Parse(selectedBook.Cells[0].Value.ToString()), selectedBook.Cells[1].Value.ToString(), selectedBook.Cells[2].Value.ToString(), DateTime.Parse(selectedBook.Cells[3].Value.ToString()), selectedBook.Cells[4].Value.ToString());

            new frmEdit(editBook, this).Show();
        }
    }
}
