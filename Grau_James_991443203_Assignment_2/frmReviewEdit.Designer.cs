namespace Grau_James_991443203_Assignment_2 {
    partial class frmReviewEdit {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmReviewEdit));
            this.trbRating = new System.Windows.Forms.TrackBar();
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.rtbReview = new System.Windows.Forms.RichTextBox();
            this.dtpReviewDate = new System.Windows.Forms.DateTimePicker();
            this.txtRating = new System.Windows.Forms.TextBox();
            this.txtReviewer = new System.Windows.Forms.TextBox();
            this.txtId = new System.Windows.Forms.TextBox();
            this.lblReviewer = new System.Windows.Forms.Label();
            this.lblReview = new System.Windows.Forms.Label();
            this.lblId = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblRating = new System.Windows.Forms.Label();
            this.lblBook = new System.Windows.Forms.Label();
            this.txtBook = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.trbRating)).BeginInit();
            this.SuspendLayout();
            // 
            // trbRating
            // 
            this.trbRating.LargeChange = 1;
            this.trbRating.Location = new System.Drawing.Point(150, 155);
            this.trbRating.Name = "trbRating";
            this.trbRating.Size = new System.Drawing.Size(309, 45);
            this.trbRating.TabIndex = 1;
            this.trbRating.Scroll += new System.EventHandler(this.trbRating_Scroll);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold);
            this.lblTitle.Location = new System.Drawing.Point(167, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(169, 31);
            this.lblTitle.TabIndex = 31;
            this.lblTitle.Text = "Edit Review";
            // 
            // btnSave
            // 
            this.btnSave.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnSave.Location = new System.Drawing.Point(428, 429);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(71, 35);
            this.btnSave.TabIndex = 3;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnCancel.Location = new System.Drawing.Point(345, 429);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(77, 35);
            this.btnCancel.TabIndex = 4;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // rtbReview
            // 
            this.rtbReview.Location = new System.Drawing.Point(150, 241);
            this.rtbReview.Name = "rtbReview";
            this.rtbReview.Size = new System.Drawing.Size(349, 182);
            this.rtbReview.TabIndex = 2;
            this.rtbReview.Text = "";
            // 
            // dtpReviewDate
            // 
            this.dtpReviewDate.Enabled = false;
            this.dtpReviewDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.dtpReviewDate.Location = new System.Drawing.Point(150, 200);
            this.dtpReviewDate.Name = "dtpReviewDate";
            this.dtpReviewDate.Size = new System.Drawing.Size(349, 26);
            this.dtpReviewDate.TabIndex = 26;
            // 
            // txtRating
            // 
            this.txtRating.Enabled = false;
            this.txtRating.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtRating.Location = new System.Drawing.Point(465, 157);
            this.txtRating.Name = "txtRating";
            this.txtRating.ReadOnly = true;
            this.txtRating.Size = new System.Drawing.Size(34, 26);
            this.txtRating.TabIndex = 25;
            this.txtRating.Text = "0";
            this.txtRating.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtReviewer
            // 
            this.txtReviewer.Enabled = false;
            this.txtReviewer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtReviewer.Location = new System.Drawing.Point(150, 123);
            this.txtReviewer.MaxLength = 100;
            this.txtReviewer.Name = "txtReviewer";
            this.txtReviewer.ReadOnly = true;
            this.txtReviewer.Size = new System.Drawing.Size(349, 26);
            this.txtReviewer.TabIndex = 2;
            // 
            // txtId
            // 
            this.txtId.Enabled = false;
            this.txtId.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtId.Location = new System.Drawing.Point(150, 57);
            this.txtId.Name = "txtId";
            this.txtId.ReadOnly = true;
            this.txtId.Size = new System.Drawing.Size(349, 26);
            this.txtId.TabIndex = 24;
            // 
            // lblReviewer
            // 
            this.lblReviewer.AutoSize = true;
            this.lblReviewer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.lblReviewer.Location = new System.Drawing.Point(6, 126);
            this.lblReviewer.Name = "lblReviewer";
            this.lblReviewer.Size = new System.Drawing.Size(138, 20);
            this.lblReviewer.TabIndex = 23;
            this.lblReviewer.Text = "Reviewer Name:";
            // 
            // lblReview
            // 
            this.lblReview.AutoSize = true;
            this.lblReview.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.lblReview.Location = new System.Drawing.Point(27, 241);
            this.lblReview.Name = "lblReview";
            this.lblReview.Size = new System.Drawing.Size(117, 20);
            this.lblReview.TabIndex = 22;
            this.lblReview.Text = "Book Review:";
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.lblId.Location = new System.Drawing.Point(114, 60);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(30, 20);
            this.lblId.TabIndex = 21;
            this.lblId.Text = "Id:";
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.lblDate.Location = new System.Drawing.Point(29, 205);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(115, 20);
            this.lblDate.TabIndex = 19;
            this.lblDate.Text = "Review Date:";
            // 
            // lblRating
            // 
            this.lblRating.AutoSize = true;
            this.lblRating.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.lblRating.Location = new System.Drawing.Point(31, 160);
            this.lblRating.Name = "lblRating";
            this.lblRating.Size = new System.Drawing.Size(113, 20);
            this.lblRating.TabIndex = 18;
            this.lblRating.Text = "Book Rating:";
            // 
            // lblBook
            // 
            this.lblBook.AutoSize = true;
            this.lblBook.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.lblBook.Location = new System.Drawing.Point(38, 92);
            this.lblBook.Name = "lblBook";
            this.lblBook.Size = new System.Drawing.Size(106, 20);
            this.lblBook.TabIndex = 16;
            this.lblBook.Text = "Book Name:";
            // 
            // txtBook
            // 
            this.txtBook.Enabled = false;
            this.txtBook.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtBook.Location = new System.Drawing.Point(150, 92);
            this.txtBook.MaxLength = 100;
            this.txtBook.Name = "txtBook";
            this.txtBook.ReadOnly = true;
            this.txtBook.Size = new System.Drawing.Size(349, 26);
            this.txtBook.TabIndex = 32;
            // 
            // frmReviewEdit
            // 
            this.AcceptButton = this.btnSave;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(506, 470);
            this.Controls.Add(this.txtBook);
            this.Controls.Add(this.trbRating);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.btnSave);
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
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmReviewEdit";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.frmReviewEdit_Load);
            ((System.ComponentModel.ISupportInitialize)(this.trbRating)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TrackBar trbRating;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.RichTextBox rtbReview;
        private System.Windows.Forms.DateTimePicker dtpReviewDate;
        private System.Windows.Forms.TextBox txtRating;
        private System.Windows.Forms.TextBox txtReviewer;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label lblReviewer;
        private System.Windows.Forms.Label lblReview;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblRating;
        private System.Windows.Forms.Label lblBook;
        private System.Windows.Forms.TextBox txtBook;
    }
}