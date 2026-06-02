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
            grpPreferenceAnalysis = new GroupBox();
            lblAverageAmount = new Label();
            label3 = new Label();
            lblFavoriteRestaurant = new Label();
            lblFavoriteMeal = new Label();
            lblTotalAmount = new Label();
            label8 = new Label();
            lblTotalCount = new Label();
            label7 = new Label();
            label2 = new Label();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvOrderRecords).BeginInit();
            grpPreferenceAnalysis.SuspendLayout();
            SuspendLayout();
            // 
            // IblOrderRecordForm
            // 
            IblOrderRecordForm.AutoSize = true;
            IblOrderRecordForm.BackColor = Color.Transparent;
            IblOrderRecordForm.Font = new Font("微軟正黑體", 18F, FontStyle.Bold, GraphicsUnit.Point, 136);
            IblOrderRecordForm.Location = new Point(135, 21);
            IblOrderRecordForm.Name = "IblOrderRecordForm";
            IblOrderRecordForm.Size = new Size(158, 31);
            IblOrderRecordForm.TabIndex = 0;
            IblOrderRecordForm.Text = "歷史訂單紀錄";
            // 
            // IblSearchDate
            // 
            IblSearchDate.AutoSize = true;
            IblSearchDate.Location = new Point(43, 83);
            IblSearchDate.Name = "IblSearchDate";
            IblSearchDate.Size = new Size(55, 15);
            IblSearchDate.TabIndex = 1;
            IblSearchDate.Text = "查詢日期";
            // 
            // txtSearchDate
            // 
            txtSearchDate.Location = new Point(104, 79);
            txtSearchDate.Name = "txtSearchDate";
            txtSearchDate.Size = new Size(127, 23);
            txtSearchDate.TabIndex = 2;
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(237, 79);
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
            IblExDate.Location = new Point(104, 62);
            IblExDate.Name = "IblExDate";
            IblExDate.Size = new Size(63, 14);
            IblExDate.TabIndex = 5;
            IblExDate.Text = "西元/00/00";
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(310, 79);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(75, 23);
            btnDelete.TabIndex = 3;
            btnDelete.Text = "刪除紀錄";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // grpPreferenceAnalysis
            // 
            grpPreferenceAnalysis.Controls.Add(lblAverageAmount);
            grpPreferenceAnalysis.Controls.Add(label3);
            grpPreferenceAnalysis.Controls.Add(lblFavoriteRestaurant);
            grpPreferenceAnalysis.Controls.Add(lblFavoriteMeal);
            grpPreferenceAnalysis.Controls.Add(lblTotalAmount);
            grpPreferenceAnalysis.Controls.Add(label8);
            grpPreferenceAnalysis.Controls.Add(lblTotalCount);
            grpPreferenceAnalysis.Controls.Add(label7);
            grpPreferenceAnalysis.Controls.Add(label2);
            grpPreferenceAnalysis.Controls.Add(label1);
            grpPreferenceAnalysis.Location = new Point(426, 12);
            grpPreferenceAnalysis.Name = "grpPreferenceAnalysis";
            grpPreferenceAnalysis.Size = new Size(395, 109);
            grpPreferenceAnalysis.TabIndex = 6;
            grpPreferenceAnalysis.TabStop = false;
            grpPreferenceAnalysis.Text = "喜好分析";
            // 
            // lblAverageAmount
            // 
            lblAverageAmount.AutoSize = true;
            lblAverageAmount.Location = new Point(96, 75);
            lblAverageAmount.Name = "lblAverageAmount";
            lblAverageAmount.Size = new Size(79, 15);
            lblAverageAmount.TabIndex = 1;
            lblAverageAmount.Text = "平均單筆消費";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(17, 75);
            label3.Name = "label3";
            label3.Size = new Size(79, 15);
            label3.TabIndex = 1;
            label3.Text = "平均單筆消費";
            // 
            // lblFavoriteRestaurant
            // 
            lblFavoriteRestaurant.AutoSize = true;
            lblFavoriteRestaurant.Location = new Point(275, 50);
            lblFavoriteRestaurant.Name = "lblFavoriteRestaurant";
            lblFavoriteRestaurant.Size = new Size(67, 15);
            lblFavoriteRestaurant.TabIndex = 1;
            lblFavoriteRestaurant.Text = "最常去餐廳";
            // 
            // lblFavoriteMeal
            // 
            lblFavoriteMeal.AutoSize = true;
            lblFavoriteMeal.Location = new Point(275, 23);
            lblFavoriteMeal.Name = "lblFavoriteMeal";
            lblFavoriteMeal.Size = new Size(67, 15);
            lblFavoriteMeal.TabIndex = 1;
            lblFavoriteMeal.Text = "最常吃餐點";
            // 
            // lblTotalAmount
            // 
            lblTotalAmount.AutoSize = true;
            lblTotalAmount.Location = new Point(96, 50);
            lblTotalAmount.Name = "lblTotalAmount";
            lblTotalAmount.Size = new Size(67, 15);
            lblTotalAmount.TabIndex = 1;
            lblTotalAmount.Text = "消費總金額";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(196, 50);
            label8.Name = "label8";
            label8.Size = new Size(67, 15);
            label8.TabIndex = 1;
            label8.Text = "最常去餐廳";
            // 
            // lblTotalCount
            // 
            lblTotalCount.AutoSize = true;
            lblTotalCount.Location = new Point(96, 23);
            lblTotalCount.Name = "lblTotalCount";
            lblTotalCount.Size = new Size(67, 15);
            lblTotalCount.TabIndex = 1;
            lblTotalCount.Text = "消費總次數";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(196, 23);
            label7.Name = "label7";
            label7.Size = new Size(67, 15);
            label7.TabIndex = 1;
            label7.Text = "最常吃餐點";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(17, 50);
            label2.Name = "label2";
            label2.Size = new Size(67, 15);
            label2.TabIndex = 1;
            label2.Text = "消費總金額";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(17, 23);
            label1.Name = "label1";
            label1.Size = new Size(67, 15);
            label1.TabIndex = 1;
            label1.Text = "消費總次數";
            // 
            // OrderRecordForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(864, 447);
            Controls.Add(grpPreferenceAnalysis);
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
            grpPreferenceAnalysis.ResumeLayout(false);
            grpPreferenceAnalysis.PerformLayout();
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
        private GroupBox grpPreferenceAnalysis;
        private Label lblAverageAmount;
        private Label label3;
        private Label lblFavoriteRestaurant;
        private Label lblFavoriteMeal;
        private Label lblTotalAmount;
        private Label label8;
        private Label lblTotalCount;
        private Label label7;
        private Label label2;
        private Label label1;
    }
}