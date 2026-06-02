namespace Meal_Recommendation_And_Accounting.Forms
{
    partial class OrderRecordForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            IblOrderRecordForm = new Label();
            IblSearchDate = new Label();
            txtSearchDate = new TextBox();
            btnSearch = new Button();
            dgvOrderRecords = new DataGridView();
            IblExDate = new Label();
            btnDelete = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvOrderRecords).BeginInit();
            SuspendLayout();
            // 
            // IblOrderRecordForm
            // 
            IblOrderRecordForm.AutoSize = true;
            IblOrderRecordForm.BackColor = Color.Transparent;
            IblOrderRecordForm.Font = new Font("微軟正黑體", 18F, FontStyle.Bold, GraphicsUnit.Point, 136);
            IblOrderRecordForm.Location = new Point(363, 23);
            IblOrderRecordForm.Name = "IblOrderRecordForm";
            IblOrderRecordForm.Size = new Size(158, 31);
            IblOrderRecordForm.TabIndex = 0;
            IblOrderRecordForm.Text = "歷史訂單紀錄";
            // 
            // IblSearchDate
            // 
            IblSearchDate.AutoSize = true;
            IblSearchDate.Location = new Point(271, 85);
            IblSearchDate.Name = "IblSearchDate";
            IblSearchDate.Size = new Size(55, 15);
            IblSearchDate.TabIndex = 1;
            IblSearchDate.Text = "查詢日期";
            // 
            // txtSearchDate
            // 
            txtSearchDate.Location = new Point(332, 81);
            txtSearchDate.Name = "txtSearchDate";
            txtSearchDate.Size = new Size(127, 23);
            txtSearchDate.TabIndex = 2;
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(465, 81);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(56, 23);
            btnSearch.TabIndex = 3;
            btnSearch.Text = "查詢";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // dgvOrderRecords
            // 
            dgvOrderRecords.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvOrderRecords.Location = new Point(45, 126);
            dgvOrderRecords.Name = "dgvOrderRecords";
            dgvOrderRecords.Size = new Size(776, 292);
            dgvOrderRecords.TabIndex = 4;
            // 
            // IblExDate
            // 
            IblExDate.AutoSize = true;
            IblExDate.Font = new Font("Microsoft JhengHei UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 136);
            IblExDate.Location = new Point(332, 64);
            IblExDate.Name = "IblExDate";
            IblExDate.Size = new Size(63, 14);
            IblExDate.TabIndex = 5;
            IblExDate.Text = "西元/00/00";
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(538, 81);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(75, 23);
            btnDelete.TabIndex = 3;
            btnDelete.Text = "刪除紀錄";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // OrderRecordForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(864, 447);
            Controls.Add(IblExDate);
            Controls.Add(dgvOrderRecords);
            Controls.Add(btnDelete);
            Controls.Add(btnSearch);
            Controls.Add(txtSearchDate);
            Controls.Add(IblSearchDate);
            Controls.Add(IblOrderRecordForm);
            Name = "OrderRecordForm";
            Text = "OrderRecordForm";
            ((System.ComponentModel.ISupportInitialize)dgvOrderRecords).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label IblOrderRecordForm;
        private Label IblSearchDate;
        private TextBox txtSearchDate;
        private Button btnSearch;
        private DataGridView dgvOrderRecords;
        private Label IblExDate;
        private Button btnDelete;
    }
}