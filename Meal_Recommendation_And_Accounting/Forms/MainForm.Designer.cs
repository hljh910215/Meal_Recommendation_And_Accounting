namespace Meal_Recommendation_And_Accounting.Forms
{
    partial class MainForm
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
            btnGenerateMeal = new Button();
            btnMemberManage = new Button();
            dgvResult = new DataGridView();
            cboArea = new ComboBox();
            cboMealTime = new ComboBox();
            cboRestaurantType = new ComboBox();
            cboMealType = new ComboBox();
            IblArea = new Label();
            IblMealTime = new Label();
            IblMealType = new Label();
            IblItemType = new Label();
            btnAddOrderRecord = new Button();
            cboPriceRange = new ComboBox();
            IblPriceRange = new Label();
            IbllblResult = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvResult).BeginInit();
            SuspendLayout();
            // 
            // btnGenerateMeal
            // 
            btnGenerateMeal.Location = new Point(418, 97);
            btnGenerateMeal.Name = "btnGenerateMeal";
            btnGenerateMeal.Size = new Size(97, 23);
            btnGenerateMeal.TabIndex = 1;
            btnGenerateMeal.Text = "餐點產生";
            btnGenerateMeal.UseVisualStyleBackColor = true;
            btnGenerateMeal.Click += btnGenerateMeal_Click;
            // 
            // btnMemberManage
            // 
            btnMemberManage.Location = new Point(642, 97);
            btnMemberManage.Name = "btnMemberManage";
            btnMemberManage.Size = new Size(97, 23);
            btnMemberManage.TabIndex = 2;
            btnMemberManage.Text = "會員頁面";
            btnMemberManage.UseVisualStyleBackColor = true;
            btnMemberManage.Click += btnMemberManage_Click;
            // 
            // dgvResult
            // 
            dgvResult.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvResult.Location = new Point(30, 190);
            dgvResult.Name = "dgvResult";
            dgvResult.Size = new Size(1071, 264);
            dgvResult.TabIndex = 3;
            
            // 
            // cboArea
            // 
            cboArea.FormattingEnabled = true;
            cboArea.Location = new Point(307, 51);
            cboArea.Name = "cboArea";
            cboArea.Size = new Size(95, 23);
            cboArea.TabIndex = 7;
            // 
            // cboMealTime
            // 
            cboMealTime.FormattingEnabled = true;
            cboMealTime.Location = new Point(419, 51);
            cboMealTime.Name = "cboMealTime";
            cboMealTime.Size = new Size(95, 23);
            cboMealTime.TabIndex = 7;
            // 
            // cboRestaurantType
            // 
            cboRestaurantType.FormattingEnabled = true;
            cboRestaurantType.Location = new Point(531, 51);
            cboRestaurantType.Name = "cboRestaurantType";
            cboRestaurantType.Size = new Size(95, 23);
            cboRestaurantType.TabIndex = 7;
            // 
            // cboMealType
            // 
            cboMealType.FormattingEnabled = true;
            cboMealType.Location = new Point(642, 51);
            cboMealType.Name = "cboMealType";
            cboMealType.Size = new Size(95, 23);
            cboMealType.TabIndex = 7;
            // 
            // IblArea
            // 
            IblArea.AutoSize = true;
            IblArea.Location = new Point(338, 23);
            IblArea.Name = "IblArea";
            IblArea.Size = new Size(31, 15);
            IblArea.TabIndex = 8;
            IblArea.Text = "地區";
            // 
            // IblMealTime
            // 
            IblMealTime.AutoSize = true;
            IblMealTime.Location = new Point(439, 23);
            IblMealTime.Name = "IblMealTime";
            IblMealTime.Size = new Size(55, 15);
            IblMealTime.TabIndex = 8;
            IblMealTime.Text = "用餐時段";
            // 
            // IblMealType
            // 
            IblMealType.AutoSize = true;
            IblMealType.Location = new Point(551, 23);
            IblMealType.Name = "IblMealType";
            IblMealType.Size = new Size(55, 15);
            IblMealType.TabIndex = 8;
            IblMealType.Text = "餐點類型";
            // 
            // IblItemType
            // 
            IblItemType.AutoSize = true;
            IblItemType.Location = new Point(661, 23);
            IblItemType.Name = "IblItemType";
            IblItemType.Size = new Size(55, 15);
            IblItemType.TabIndex = 8;
            IblItemType.Text = "品項類型";
            // 
            // btnAddOrderRecord
            // 
            btnAddOrderRecord.Location = new Point(532, 97);
            btnAddOrderRecord.Name = "btnAddOrderRecord";
            btnAddOrderRecord.Size = new Size(95, 23);
            btnAddOrderRecord.TabIndex = 1;
            btnAddOrderRecord.Text = "加入訂單紀錄";
            btnAddOrderRecord.UseVisualStyleBackColor = true;
            btnAddOrderRecord.Click += btnAddOrderRecord_Click;
            // 
            // cboPriceRange
            // 
            cboPriceRange.FormattingEnabled = true;
            cboPriceRange.Location = new Point(754, 51);
            cboPriceRange.Name = "cboPriceRange";
            cboPriceRange.Size = new Size(95, 23);
            cboPriceRange.TabIndex = 7;
            // 
            // IblPriceRange
            // 
            IblPriceRange.AutoSize = true;
            IblPriceRange.Location = new Point(773, 23);
            IblPriceRange.Name = "IblPriceRange";
            IblPriceRange.Size = new Size(55, 15);
            IblPriceRange.TabIndex = 8;
            IblPriceRange.Text = "價格區間";
            // 
            // IbllblResult
            // 
            IbllblResult.AutoSize = true;
            IbllblResult.Font = new Font("微軟正黑體", 18F, FontStyle.Bold, GraphicsUnit.Point, 136);
            IbllblResult.Location = new Point(532, 146);
            IbllblResult.Name = "IbllblResult";
            IbllblResult.Size = new Size(110, 31);
            IbllblResult.TabIndex = 8;
            IbllblResult.Text = "推薦結果";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1132, 480);
            Controls.Add(IblPriceRange);
            Controls.Add(IblItemType);
            Controls.Add(IblMealType);
            Controls.Add(IbllblResult);
            Controls.Add(IblMealTime);
            Controls.Add(IblArea);
            Controls.Add(cboPriceRange);
            Controls.Add(cboMealType);
            Controls.Add(cboRestaurantType);
            Controls.Add(cboMealTime);
            Controls.Add(cboArea);
            Controls.Add(dgvResult);
            Controls.Add(btnMemberManage);
            Controls.Add(btnAddOrderRecord);
            Controls.Add(btnGenerateMeal);
            Name = "MainForm";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dgvResult).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnPreferencesanalyze;
        private Button btnGenerateMeal;
        private Button btnMemberManage;
        private DataGridView dgvResult;
        private ComboBox cboArea;
        private ComboBox cboMealTime;
        private ComboBox cboRestaurantType;
        private ComboBox cboMealType;
        private Label IblArea;
        private Label IblMealTime;
        private Label IblMealType;
        private Label IblItemType;
        private Button btnAddOrderRecord;
        private ComboBox cboPriceRange;
        private Label IblPriceRange;
        private Label IbllblResult;
    }
}