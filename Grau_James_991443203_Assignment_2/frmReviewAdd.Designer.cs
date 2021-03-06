﻿namespace Grau_James_991443203_Assignment_2 {
    partial class frmReviewAdd {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmReviewAdd));
            this.cmbBooks = new System.Windows.Forms.ComboBox();
            this.lblBook = new System.Windows.Forms.Label();
            this.lblRating = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblId = new System.Windows.Forms.Label();
            this.lblReview = new System.Windows.Forms.Label();
            this.lblReviewer = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.txtReviewer = new System.Windows.Forms.TextBox();
            this.txtRating = new System.Windows.Forms.TextBox();
            this.dtpReviewDate = new System.Windows.Forms.DateTimePicker();
            this.rtbReview = new System.Windows.Forms.RichTextBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnAddReview = new System.Windows.Forms.Button();
            this.btnAddAnotherReview = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.trbRating = new System.Windows.Forms.TrackBar();
            ((System.ComponentModel.ISupportInitialize)(this.trbRating)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbBooks
            // 
            this.cmbBooks.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cmbBooks.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.cmbBooks.FormattingEnabled = true;
            this.cmbBooks.Location = new System.Drawing.Point(156, 89);
            this.cmbBooks.Name = "cmbBooks";
            this.cmbBooks.Size = new System.Drawing.Size(349, 28);
            this.cmbBooks.TabIndex = 0;
            // 
            // lblBook
            // 
            this.lblBook.AutoSize = true;
            this.lblBook.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.lblBook.Location = new System.Drawing.Point(44, 92);
            this.lblBook.Name = "lblBook";
            this.lblBook.Size = new System.Drawing.Size(106, 20);
            this.lblBook.TabIndex = 1;
            this.lblBook.Text = "Book Name:";
            // 
            // lblRating
            // 
            this.lblRating.AutoSize = true;
            this.lblRating.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.lblRating.Location = new System.Drawing.Point(37, 160);
            this.lblRating.Name = "lblRating";
            this.lblRating.Size = new System.Drawing.Size(113, 20);
            this.lblRating.TabIndex = 2;
            this.lblRating.Text = "Book Rating:";
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.lblDate.Location = new System.Drawing.Point(35, 205);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(115, 20);
            this.lblDate.TabIndex = 3;
            this.lblDate.Text = "Review Date:";
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.lblId.Location = new System.Drawing.Point(120, 60);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(30, 20);
            this.lblId.TabIndex = 4;
            this.lblId.Text = "Id:";
            // 
            // lblReview
            // 
            this.lblReview.AutoSize = true;
            this.lblReview.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.lblReview.Location = new System.Drawing.Point(33, 241);
            this.lblReview.Name = "lblReview";
            this.lblReview.Size = new System.Drawing.Size(117, 20);
            this.lblReview.TabIndex = 5;
            this.lblReview.Text = "Book Review:";
            // 
            // lblReviewer
            // 
            this.lblReviewer.AutoSize = true;
            this.lblReviewer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.lblReviewer.Location = new System.Drawing.Point(12, 126);
            this.lblReviewer.Name = "lblReviewer";
            this.lblReviewer.Size = new System.Drawing.Size(138, 20);
            this.lblReviewer.TabIndex = 6;
            this.lblReviewer.Text = "Reviewer Name:";
            // 
            // txtId
            // 
            this.txtId.Enabled = false;
            this.txtId.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtId.Location = new System.Drawing.Point(156, 57);
            this.txtId.Name = "txtId";
            this.txtId.ReadOnly = true;
            this.txtId.Size = new System.Drawing.Size(349, 26);
            this.txtId.TabIndex = 7;
            // 
            // txtReviewer
            // 
            this.txtReviewer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtReviewer.Location = new System.Drawing.Point(156, 123);
            this.txtReviewer.MaxLength = 100;
            this.txtReviewer.Name = "txtReviewer";
            this.txtReviewer.Size = new System.Drawing.Size(349, 26);
            this.txtReviewer.TabIndex = 1;
            // 
            // txtRating
            // 
            this.txtRating.Enabled = false;
            this.txtRating.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtRating.Location = new System.Drawing.Point(471, 157);
            this.txtRating.Name = "txtRating";
            this.txtRating.ReadOnly = true;
            this.txtRating.Size = new System.Drawing.Size(34, 26);
            this.txtRating.TabIndex = 8;
            this.txtRating.Text = "0";
            this.txtRating.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // dtpReviewDate
            // 
            this.dtpReviewDate.Enabled = false;
            this.dtpReviewDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.dtpReviewDate.Location = new System.Drawing.Point(156, 200);
            this.dtpReviewDate.Name = "dtpReviewDate";
            this.dtpReviewDate.Size = new System.Drawing.Size(349, 26);
            this.dtpReviewDate.TabIndex = 9;
            // 
            // rtbReview
            // 
            this.rtbReview.Location = new System.Drawing.Point(156, 241);
            this.rtbReview.Name = "rtbReview";
            this.rtbReview.Size = new System.Drawing.Size(349, 182);
            this.rtbReview.TabIndex = 10;
            this.rtbReview.Text = "";
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnCancel.Location = new System.Drawing.Point(156, 429);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(77, 35);
            this.btnCancel.TabIndex = 11;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnAddReview
            // 
            this.btnAddReview.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnAddReview.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnAddReview.Location = new System.Drawing.Point(305, 429);
            this.btnAddReview.Name = "btnAddReview";
            this.btnAddReview.Size = new System.Drawing.Size(77, 35);
            this.btnAddReview.TabIndex = 12;
            this.btnAddReview.Text = "Add";
            this.btnAddReview.UseVisualStyleBackColor = true;
            this.btnAddReview.Click += new System.EventHandler(this.btnAddReview_Click);
            // 
            // btnAddAnotherReview
            // 
            this.btnAddAnotherReview.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnAddAnotherReview.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnAddAnotherReview.Location = new System.Drawing.Point(388, 429);
            this.btnAddAnotherReview.Name = "btnAddAnotherReview";
            this.btnAddAnotherReview.Size = new System.Drawing.Size(117, 35);
            this.btnAddAnotherReview.TabIndex = 13;
            this.btnAddAnotherReview.Text = "Add Another";
            this.btnAddAnotherReview.UseVisualStyleBackColor = true;
            this.btnAddAnotherReview.Click += new System.EventHandler(this.btnAddAnotherReview_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold);
            this.lblTitle.Location = new System.Drawing.Point(173, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(169, 31);
            this.lblTitle.TabIndex = 14;
            this.lblTitle.Text = "Add Review";
            // 
            // trbRating
            // 
            this.trbRating.LargeChange = 1;
            this.trbRating.Location = new System.Drawing.Point(156, 155);
            this.trbRating.Name = "trbRating";
            this.trbRating.Size = new System.Drawing.Size(309, 45);
            this.trbRating.TabIndex = 3;
            this.trbRating.Scroll += new System.EventHandler(this.trbReview_Scroll);
            // 
            // frmReviewAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(511, 472);
            this.Controls.Add(this.trbRating);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.btnAddAnotherReview);
            this.Controls.Add(this.btnAddReview);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.rtbReview);
            this.Controls.Add(this.dtpReviewDate);
            this.Controls.Add(this.txtRating);
            this.Controls.Add(this.txtReviewer);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.lblReviewer);
            this.Controls.Add(this.lblReview);
            this.Controls.Add(this.lblId);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.lblRating);
            this.Controls.Add(this.lblBook);
            this.Controls.Add(this.cmbBooks);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmReviewAdd";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.frmReviewAdd_Load);
            ((System.ComponentModel.ISupportInitialize)(this.trbRating)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbBooks;
        private System.Windows.Forms.Label lblBook;
        private System.Windows.Forms.Label lblRating;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.Label lblReview;
        private System.Windows.Forms.Label lblReviewer;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.TextBox txtReviewer;
        private System.Windows.Forms.TextBox txtRating;
        private System.Windows.Forms.DateTimePicker dtpReviewDate;
        private System.Windows.Forms.RichTextBox rtbReview;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnAddReview;
        private System.Windows.Forms.Button btnAddAnotherReview;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.TrackBar trbRating;
    }
}