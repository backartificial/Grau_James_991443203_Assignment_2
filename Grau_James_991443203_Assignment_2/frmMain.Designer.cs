namespace Grau_James_991443203_Assignment_2 {
    partial class frmMain {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblHealper = new System.Windows.Forms.Label();
            this.btnHandleBooks = new System.Windows.Forms.Button();
            this.btnHandleReviews = new System.Windows.Forms.Button();
            this.btnSearchReviews = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(12, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(492, 31);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Welcome to the Trafalgar Book Club!";
            // 
            // lblHealper
            // 
            this.lblHealper.AutoSize = true;
            this.lblHealper.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblHealper.Location = new System.Drawing.Point(83, 53);
            this.lblHealper.Name = "lblHealper";
            this.lblHealper.Size = new System.Drawing.Size(351, 20);
            this.lblHealper.TabIndex = 1;
            this.lblHealper.Text = "Click on a button below to Perform Desired Task.";
            // 
            // btnHandleBooks
            // 
            this.btnHandleBooks.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnHandleBooks.Location = new System.Drawing.Point(56, 91);
            this.btnHandleBooks.Name = "btnHandleBooks";
            this.btnHandleBooks.Size = new System.Drawing.Size(126, 35);
            this.btnHandleBooks.TabIndex = 2;
            this.btnHandleBooks.Text = "Handle Books";
            this.btnHandleBooks.UseVisualStyleBackColor = true;
            this.btnHandleBooks.Click += new System.EventHandler(this.btnHandleBooks_Click);
            // 
            // btnHandleReviews
            // 
            this.btnHandleReviews.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnHandleReviews.Location = new System.Drawing.Point(188, 91);
            this.btnHandleReviews.Name = "btnHandleReviews";
            this.btnHandleReviews.Size = new System.Drawing.Size(141, 35);
            this.btnHandleReviews.TabIndex = 3;
            this.btnHandleReviews.Text = "Handle Reviews";
            this.btnHandleReviews.UseVisualStyleBackColor = true;
            this.btnHandleReviews.Click += new System.EventHandler(this.btnHandleReviews_Click);
            // 
            // btnSearchReviews
            // 
            this.btnSearchReviews.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnSearchReviews.Location = new System.Drawing.Point(335, 91);
            this.btnSearchReviews.Name = "btnSearchReviews";
            this.btnSearchReviews.Size = new System.Drawing.Size(141, 35);
            this.btnSearchReviews.TabIndex = 4;
            this.btnSearchReviews.Text = "Search Reviews";
            this.btnSearchReviews.UseVisualStyleBackColor = true;
            this.btnSearchReviews.Click += new System.EventHandler(this.btnSearchReviews_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(507, 133);
            this.Controls.Add(this.btnSearchReviews);
            this.Controls.Add(this.btnHandleReviews);
            this.Controls.Add(this.btnHandleBooks);
            this.Controls.Add(this.lblHealper);
            this.Controls.Add(this.lblTitle);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblHealper;
        private System.Windows.Forms.Button btnHandleBooks;
        private System.Windows.Forms.Button btnHandleReviews;
        private System.Windows.Forms.Button btnSearchReviews;
    }
}