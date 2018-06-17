namespace Grau_James_991443203_Assignment_2 {
    partial class frmReviews {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmReviews));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.megaBooksDBDataSet = new Grau_James_991443203_Assignment_2.MegaBooksDBDataSet();
            this.reviewsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.reviewsTableAdapter = new Grau_James_991443203_Assignment_2.MegaBooksDBDataSetTableAdapters.ReviewsTableAdapter();
            this.tableAdapterManager = new Grau_James_991443203_Assignment_2.MegaBooksDBDataSetTableAdapters.TableAdapterManager();
            this.bngReviews = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.dgvReviews = new System.Windows.Forms.DataGridView();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bngReviewDelete = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.stsReviews = new System.Windows.Forms.StatusStrip();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tsslReviews = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsslReviewsMade = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)(this.megaBooksDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reviewsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bngReviews)).BeginInit();
            this.bngReviews.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReviews)).BeginInit();
            this.stsReviews.SuspendLayout();
            this.SuspendLayout();
            // 
            // megaBooksDBDataSet
            // 
            this.megaBooksDBDataSet.DataSetName = "MegaBooksDBDataSet";
            this.megaBooksDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reviewsBindingSource
            // 
            this.reviewsBindingSource.DataMember = "Reviews";
            this.reviewsBindingSource.DataSource = this.megaBooksDBDataSet;
            // 
            // reviewsTableAdapter
            // 
            this.reviewsTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.BooksTableAdapter = null;
            this.tableAdapterManager.ReviewsTableAdapter = this.reviewsTableAdapter;
            this.tableAdapterManager.UpdateOrder = Grau_James_991443203_Assignment_2.MegaBooksDBDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // bngReviews
            // 
            this.bngReviews.AddNewItem = null;
            this.bngReviews.BindingSource = this.reviewsBindingSource;
            this.bngReviews.CountItem = this.bindingNavigatorCountItem;
            this.bngReviews.DeleteItem = null;
            this.bngReviews.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.bngReviews.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.toolStripButton1,
            this.bngReviewDelete});
            this.bngReviews.Location = new System.Drawing.Point(0, 0);
            this.bngReviews.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.bngReviews.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.bngReviews.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.bngReviews.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.bngReviews.Name = "bngReviews";
            this.bngReviews.PositionItem = this.bindingNavigatorPositionItem;
            this.bngReviews.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.bngReviews.Size = new System.Drawing.Size(800, 25);
            this.bngReviews.TabIndex = 0;
            this.bngReviews.Text = "bindingNavigator1";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // dgvReviews
            // 
            this.dgvReviews.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvReviews.AutoGenerateColumns = false;
            this.dgvReviews.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dgvReviews.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvReviews.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6});
            this.dgvReviews.DataSource = this.reviewsBindingSource;
            this.dgvReviews.Location = new System.Drawing.Point(0, 28);
            this.dgvReviews.Name = "dgvReviews";
            this.dgvReviews.Size = new System.Drawing.Size(800, 397);
            this.dgvReviews.TabIndex = 1;
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bngReviewDelete
            // 
            this.bngReviewDelete.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bngReviewDelete.Image = ((System.Drawing.Image)(resources.GetObject("bngReviewDelete.Image")));
            this.bngReviewDelete.Name = "bngReviewDelete";
            this.bngReviewDelete.RightToLeftAutoMirrorImage = true;
            this.bngReviewDelete.Size = new System.Drawing.Size(23, 22);
            this.bngReviewDelete.Text = "Delete";
            this.bngReviewDelete.Click += new System.EventHandler(this.bngReviewDelete_Click);
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // stsReviews
            // 
            this.stsReviews.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsslReviews,
            this.tsslReviewsMade});
            this.stsReviews.Location = new System.Drawing.Point(0, 428);
            this.stsReviews.Name = "stsReviews";
            this.stsReviews.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.stsReviews.Size = new System.Drawing.Size(800, 22);
            this.stsReviews.TabIndex = 2;
            this.stsReviews.Text = "statusStrip1";
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.dataGridViewTextBoxColumn1.DataPropertyName = "id";
            this.dataGridViewTextBoxColumn1.HeaderText = "Id";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.ToolTipText = "Is the Review Id";
            this.dataGridViewTextBoxColumn1.Width = 41;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.dataGridViewTextBoxColumn2.DataPropertyName = "reviewer";
            this.dataGridViewTextBoxColumn2.HeaderText = "Reviewer";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ToolTipText = "Is the Person who wrote the Review";
            this.dataGridViewTextBoxColumn2.Width = 77;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.dataGridViewTextBoxColumn3.DataPropertyName = "review";
            this.dataGridViewTextBoxColumn3.HeaderText = "Review";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ToolTipText = "Is the Persons Review";
            this.dataGridViewTextBoxColumn3.Width = 68;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.dataGridViewTextBoxColumn4.DataPropertyName = "date";
            dataGridViewCellStyle3.Format = "D";
            dataGridViewCellStyle3.NullValue = null;
            this.dataGridViewTextBoxColumn4.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewTextBoxColumn4.HeaderText = "Review Date";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ToolTipText = "Is the Date the Review was Published";
            this.dataGridViewTextBoxColumn4.Width = 87;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.dataGridViewTextBoxColumn5.DataPropertyName = "rating";
            dataGridViewCellStyle4.Format = "N2";
            dataGridViewCellStyle4.NullValue = null;
            this.dataGridViewTextBoxColumn5.DefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridViewTextBoxColumn5.HeaderText = "Book Rating";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ToolTipText = "Is the Review for the Book";
            this.dataGridViewTextBoxColumn5.Width = 84;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.dataGridViewTextBoxColumn6.DataPropertyName = "book_id";
            this.dataGridViewTextBoxColumn6.HeaderText = "Reviewed Book";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ToolTipText = "Is the Book the Review is made for";
            this.dataGridViewTextBoxColumn6.Width = 99;
            // 
            // tsslReviews
            // 
            this.tsslReviews.Name = "tsslReviews";
            this.tsslReviews.Size = new System.Drawing.Size(0, 17);
            // 
            // tsslReviewsMade
            // 
            this.tsslReviewsMade.Name = "tsslReviewsMade";
            this.tsslReviewsMade.Size = new System.Drawing.Size(228, 17);
            this.tsslReviewsMade.Text = "Reviews Published Since Program Open: 0";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton1.Text = "toolStripButton1";
            // 
            // frmReviews
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.stsReviews);
            this.Controls.Add(this.dgvReviews);
            this.Controls.Add(this.bngReviews);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmReviews";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.frmReviews_Load);
            ((System.ComponentModel.ISupportInitialize)(this.megaBooksDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reviewsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bngReviews)).EndInit();
            this.bngReviews.ResumeLayout(false);
            this.bngReviews.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReviews)).EndInit();
            this.stsReviews.ResumeLayout(false);
            this.stsReviews.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MegaBooksDBDataSet megaBooksDBDataSet;
        private System.Windows.Forms.BindingSource reviewsBindingSource;
        private MegaBooksDBDataSetTableAdapters.ReviewsTableAdapter reviewsTableAdapter;
        private MegaBooksDBDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator bngReviews;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bngReviewDelete;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.DataGridView dgvReviews;
        private System.Windows.Forms.StatusStrip stsReviews;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.ToolStripStatusLabel tsslReviews;
        private System.Windows.Forms.ToolStripStatusLabel tsslReviewsMade;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
    }
}