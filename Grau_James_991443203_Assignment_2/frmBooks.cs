using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Grau_James_991443203_Assignment_2 {
    public partial class frmBooks : Form {
        public frmBooks() {
            InitializeComponent();
        }

        private void booksBindingNavigatorSaveItem_Click(object sender, EventArgs e) {
            Validate();
            booksBindingSource.EndEdit();
            tableAdapterManager.UpdateAll(megaBooksDBDataSet);
        }

        private void frmBooks_Load(object sender, EventArgs e) {
            // TODO: This line of code loads data into the 'megaBooksDBDataSet.Books' table. You can move, or remove it, as needed.
            booksTableAdapter.Fill(this.megaBooksDBDataSet.Books);
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
    }
}
