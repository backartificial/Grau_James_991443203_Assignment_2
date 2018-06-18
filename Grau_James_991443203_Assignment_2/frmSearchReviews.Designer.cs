namespace Grau_James_991443203_Assignment_2 {
    partial class frmSearchReviews {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSearchReviews));
            this.dgvReviews = new System.Windows.Forms.DataGridView();
            this.grbSearch = new System.Windows.Forms.GroupBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.lblDesc3 = new System.Windows.Forms.Label();
            this.lblDesc2 = new System.Windows.Forms.Label();
            this.lblDesc1 = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtValue3 = new System.Windows.Forms.TextBox();
            this.cmbOptions3 = new System.Windows.Forms.ComboBox();
            this.cmbColumn3 = new System.Windows.Forms.ComboBox();
            this.cmbJoin2 = new System.Windows.Forms.ComboBox();
            this.txtValue2 = new System.Windows.Forms.TextBox();
            this.txtValue1 = new System.Windows.Forms.TextBox();
            this.cmbOptions2 = new System.Windows.Forms.ComboBox();
            this.cmbColumn2 = new System.Windows.Forms.ComboBox();
            this.cmbJoin1 = new System.Windows.Forms.ComboBox();
            this.cmbOptions1 = new System.Windows.Forms.ComboBox();
            this.cmbColumn1 = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReviews)).BeginInit();
            this.grbSearch.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvReviews
            // 
            this.dgvReviews.AllowUserToAddRows = false;
            this.dgvReviews.AllowUserToDeleteRows = false;
            this.dgvReviews.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvReviews.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvReviews.Location = new System.Drawing.Point(0, 201);
            this.dgvReviews.Name = "dgvReviews";
            this.dgvReviews.ReadOnly = true;
            this.dgvReviews.Size = new System.Drawing.Size(847, 335);
            this.dgvReviews.TabIndex = 0;
            this.dgvReviews.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvReviews_CellMouseDoubleClick);
            // 
            // grbSearch
            // 
            this.grbSearch.Controls.Add(this.btnClear);
            this.grbSearch.Controls.Add(this.lblDesc3);
            this.grbSearch.Controls.Add(this.lblDesc2);
            this.grbSearch.Controls.Add(this.lblDesc1);
            this.grbSearch.Controls.Add(this.btnSearch);
            this.grbSearch.Controls.Add(this.txtValue3);
            this.grbSearch.Controls.Add(this.cmbOptions3);
            this.grbSearch.Controls.Add(this.cmbColumn3);
            this.grbSearch.Controls.Add(this.cmbJoin2);
            this.grbSearch.Controls.Add(this.txtValue2);
            this.grbSearch.Controls.Add(this.txtValue1);
            this.grbSearch.Controls.Add(this.cmbOptions2);
            this.grbSearch.Controls.Add(this.cmbColumn2);
            this.grbSearch.Controls.Add(this.cmbJoin1);
            this.grbSearch.Controls.Add(this.cmbOptions1);
            this.grbSearch.Controls.Add(this.cmbColumn1);
            this.grbSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.grbSearch.Location = new System.Drawing.Point(12, 12);
            this.grbSearch.Name = "grbSearch";
            this.grbSearch.Size = new System.Drawing.Size(570, 183);
            this.grbSearch.TabIndex = 1;
            this.grbSearch.TabStop = false;
            this.grbSearch.Text = "Advanced Search";
            // 
            // btnClear
            // 
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnClear.Location = new System.Drawing.Point(416, 141);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(62, 32);
            this.btnClear.TabIndex = 17;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // lblDesc3
            // 
            this.lblDesc3.AutoSize = true;
            this.lblDesc3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.lblDesc3.Location = new System.Drawing.Point(367, 19);
            this.lblDesc3.Name = "lblDesc3";
            this.lblDesc3.Size = new System.Drawing.Size(131, 20);
            this.lblDesc3.TabIndex = 16;
            this.lblDesc3.Text = "Operator/Value";
            // 
            // lblDesc2
            // 
            this.lblDesc2.AutoSize = true;
            this.lblDesc2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.lblDesc2.Location = new System.Drawing.Point(153, 19);
            this.lblDesc2.Name = "lblDesc2";
            this.lblDesc2.Size = new System.Drawing.Size(145, 20);
            this.lblDesc2.TabIndex = 15;
            this.lblDesc2.Text = "Column/Operator";
            // 
            // lblDesc1
            // 
            this.lblDesc1.AutoSize = true;
            this.lblDesc1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.lblDesc1.Location = new System.Drawing.Point(6, 19);
            this.lblDesc1.Name = "lblDesc1";
            this.lblDesc1.Size = new System.Drawing.Size(127, 20);
            this.lblDesc1.TabIndex = 14;
            this.lblDesc1.Text = "Column/Option";
            // 
            // btnSearch
            // 
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnSearch.Location = new System.Drawing.Point(484, 141);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(76, 32);
            this.btnSearch.TabIndex = 2;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtValue3
            // 
            this.txtValue3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtValue3.Location = new System.Drawing.Point(416, 109);
            this.txtValue3.Name = "txtValue3";
            this.txtValue3.Size = new System.Drawing.Size(144, 26);
            this.txtValue3.TabIndex = 13;
            // 
            // cmbOptions3
            // 
            this.cmbOptions3.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.cmbOptions3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbOptions3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.cmbOptions3.FormattingEnabled = true;
            this.cmbOptions3.Items.AddRange(new object[] {
            "<",
            ">",
            "<=",
            ">=",
            "<>",
            "=",
            "LIKE"});
            this.cmbOptions3.Location = new System.Drawing.Point(304, 109);
            this.cmbOptions3.Name = "cmbOptions3";
            this.cmbOptions3.Size = new System.Drawing.Size(106, 28);
            this.cmbOptions3.TabIndex = 12;
            // 
            // cmbColumn3
            // 
            this.cmbColumn3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbColumn3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.cmbColumn3.FormattingEnabled = true;
            this.cmbColumn3.Items.AddRange(new object[] {
            "Book Id",
            "Book Name",
            "Reviewer Name"});
            this.cmbColumn3.Location = new System.Drawing.Point(157, 109);
            this.cmbColumn3.Name = "cmbColumn3";
            this.cmbColumn3.Size = new System.Drawing.Size(141, 28);
            this.cmbColumn3.TabIndex = 11;
            // 
            // cmbJoin2
            // 
            this.cmbJoin2.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.cmbJoin2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbJoin2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.cmbJoin2.FormattingEnabled = true;
            this.cmbJoin2.Items.AddRange(new object[] {
            "AND",
            "OR"});
            this.cmbJoin2.Location = new System.Drawing.Point(10, 109);
            this.cmbJoin2.Name = "cmbJoin2";
            this.cmbJoin2.Size = new System.Drawing.Size(141, 28);
            this.cmbJoin2.TabIndex = 10;
            // 
            // txtValue2
            // 
            this.txtValue2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtValue2.Location = new System.Drawing.Point(416, 75);
            this.txtValue2.Name = "txtValue2";
            this.txtValue2.Size = new System.Drawing.Size(144, 26);
            this.txtValue2.TabIndex = 9;
            // 
            // txtValue1
            // 
            this.txtValue1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtValue1.Location = new System.Drawing.Point(304, 41);
            this.txtValue1.Name = "txtValue1";
            this.txtValue1.Size = new System.Drawing.Size(256, 26);
            this.txtValue1.TabIndex = 4;
            // 
            // cmbOptions2
            // 
            this.cmbOptions2.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.cmbOptions2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbOptions2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.cmbOptions2.FormattingEnabled = true;
            this.cmbOptions2.Items.AddRange(new object[] {
            "<",
            ">",
            "<=",
            ">=",
            "<>",
            "=",
            "LIKE"});
            this.cmbOptions2.Location = new System.Drawing.Point(304, 75);
            this.cmbOptions2.Name = "cmbOptions2";
            this.cmbOptions2.Size = new System.Drawing.Size(106, 28);
            this.cmbOptions2.TabIndex = 8;
            // 
            // cmbColumn2
            // 
            this.cmbColumn2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbColumn2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.cmbColumn2.FormattingEnabled = true;
            this.cmbColumn2.Items.AddRange(new object[] {
            "Book Id",
            "Book Name",
            "Reviewer Name"});
            this.cmbColumn2.Location = new System.Drawing.Point(157, 75);
            this.cmbColumn2.Name = "cmbColumn2";
            this.cmbColumn2.Size = new System.Drawing.Size(141, 28);
            this.cmbColumn2.TabIndex = 6;
            // 
            // cmbJoin1
            // 
            this.cmbJoin1.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.cmbJoin1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbJoin1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.cmbJoin1.FormattingEnabled = true;
            this.cmbJoin1.Items.AddRange(new object[] {
            "AND",
            "OR"});
            this.cmbJoin1.Location = new System.Drawing.Point(10, 75);
            this.cmbJoin1.Name = "cmbJoin1";
            this.cmbJoin1.Size = new System.Drawing.Size(141, 28);
            this.cmbJoin1.TabIndex = 5;
            // 
            // cmbOptions1
            // 
            this.cmbOptions1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbOptions1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.cmbOptions1.FormattingEnabled = true;
            this.cmbOptions1.Items.AddRange(new object[] {
            "<",
            ">",
            "<=",
            ">=",
            "<>",
            "=",
            "LIKE"});
            this.cmbOptions1.Location = new System.Drawing.Point(157, 41);
            this.cmbOptions1.Name = "cmbOptions1";
            this.cmbOptions1.Size = new System.Drawing.Size(141, 28);
            this.cmbOptions1.TabIndex = 3;
            // 
            // cmbColumn1
            // 
            this.cmbColumn1.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.cmbColumn1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbColumn1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.cmbColumn1.FormattingEnabled = true;
            this.cmbColumn1.Items.AddRange(new object[] {
            "Book Id",
            "Book Name",
            "Reviewer Name"});
            this.cmbColumn1.Location = new System.Drawing.Point(10, 41);
            this.cmbColumn1.Name = "cmbColumn1";
            this.cmbColumn1.Size = new System.Drawing.Size(141, 28);
            this.cmbColumn1.TabIndex = 2;
            // 
            // frmSearchReviews
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(847, 536);
            this.Controls.Add(this.grbSearch);
            this.Controls.Add(this.dgvReviews);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmSearchReviews";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.frmSearchReviews_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvReviews)).EndInit();
            this.grbSearch.ResumeLayout(false);
            this.grbSearch.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvReviews;
        private System.Windows.Forms.GroupBox grbSearch;
        private System.Windows.Forms.ComboBox cmbOptions1;
        private System.Windows.Forms.ComboBox cmbColumn1;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.ComboBox cmbOptions2;
        private System.Windows.Forms.ComboBox cmbColumn2;
        private System.Windows.Forms.ComboBox cmbJoin1;
        private System.Windows.Forms.TextBox txtValue2;
        private System.Windows.Forms.TextBox txtValue1;
        private System.Windows.Forms.TextBox txtValue3;
        private System.Windows.Forms.ComboBox cmbOptions3;
        private System.Windows.Forms.ComboBox cmbColumn3;
        private System.Windows.Forms.ComboBox cmbJoin2;
        private System.Windows.Forms.Label lblDesc1;
        private System.Windows.Forms.Label lblDesc2;
        private System.Windows.Forms.Label lblDesc3;
        private System.Windows.Forms.Button btnClear;
    }
}